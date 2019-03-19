// Project / File: Tests.Plugins.UnitTests / PluginHybridTest.cs
//         Author: Ahmed Elsawalhy (Yagasoft.com)
//        Created: 2015 / 04 / 14 (9:39 AM)
//       Modified: 2015 / 04 / 19 (1:19 PM)

#region Imports
using System;
using System.Activities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Yagasoft.Libraries.EnhancedOrgService;
using Yagasoft.Libraries.EnhancedOrgService.Services;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Moq;
using Xrm.Framework.Test.Unit.Moq;

#endregion

namespace Xrm.Framework.Test.Unit.Moq.Hybrid
{
	/// <summary>
	///     Base class for plugin testing. It modifies the framework to allow for multiple testing cases,
	///     disables plugin steps, and updates plugin upon success.<br />
	///     Version: 1.2.15
	/// </summary>
	public abstract class ActivityHybridTest : Xrm.Framework.Test.Unit.Moq.WFActivityUnitTest
	{
		#region New properties

		protected string assemblyName;
		protected string className;

		protected Type activityClass
		{
			set
			{
				className = value.FullName;
				assemblyName = value.Assembly.GetName().Name;
			}
		}

		// get an unmocked version of the service to use for actions that don't need reverting
		protected static IOrganizationService service = Helper.Service;

		protected static Guid userId;
		protected static Guid initiatingUserId;
		protected static Guid businessUnitId;
		protected static Guid orgId;
		protected static string orgName;

		// keep a record of which steps were enabled, in order to revert them to their state after testing
		protected static List<SdkMessageProcessingStep> disabledSteps = new List<SdkMessageProcessingStep>();

		protected static bool testFailed;

		protected static bool commonSetup;

		protected bool undoTestActions;

		#endregion

		#region Prepare

		/// <summary>
		///     Prepare instance variables, plugin context, and mocks.
		/// </summary>
		protected void SetupEnvironment()
		{
			OrganizationService = service;
			SystemOrganizationService = service;
			OrganizationServiceFactoryMock.Setup(factory => factory.CreateOrganizationService(It.IsAny<Guid?>())).Returns(OrganizationService);

			// we need the organisation name to add it to the plugin context
			if (orgName == null)
			{
				var whoAmI = (WhoAmIResponse) service.Execute(new WhoAmIRequest());
				userId = whoAmI.UserId;
				initiatingUserId = whoAmI.UserId;
				businessUnitId = whoAmI.BusinessUnitId;
				orgId = whoAmI.OrganizationId;
				orgName = service.Retrieve("organization", orgId,
					new ColumnSet("name")).GetAttributeValue<string>("name");
			}

			if (!commonSetup)
			{
				SetupCommon();
				commonSetup = true;
			}

			// add user, business unit, and organisation info to the plugin context
			WorkflowContextMock.Setup(contextT => contextT.UserId).Returns(userId);
			WorkflowContextMock.Setup(contextT => contextT.InitiatingUserId).Returns(userId);
			WorkflowContextMock.Setup(contextT => contextT.BusinessUnitId).Returns(businessUnitId);
			WorkflowContextMock.Setup(contextT => contextT.OrganizationId).Returns(orgId);
			WorkflowContextMock.Setup(contextT => contextT.OrganizationName).Returns(orgName);

			// any plugin instance requesting a service will get this one
			OrganizationServiceFactoryMock.Setup(factory => factory.CreateOrganizationService(It.IsAny<Guid?>())).Returns(OrganizationService);
		}

		protected abstract void SetupCommon();

		protected override Activity SetupActivity()
		{
			return Helper.GetObject<Activity>(assemblyName, className);
		}

		protected void PrepareTest()
		{
			Error = null;
			SetupEnvironment();

			// run the superclass setup function to prepare the activity and its invoker
			Setup();
		}

		/// <summary>
		///     Sets the user ID that the workflow will run under.
		/// </summary>
		/// <param name="userIdL">The user ID</param>
		protected void SetUser(Guid userIdL)
		{
			WorkflowContextMock.Setup(contextT => contextT.UserId).Returns(userIdL);
		}

		/// <summary>
		///     Sets the initiating user ID for the workflow.
		/// </summary>
		/// <param name="userIdL">The user ID</param>
		protected void SetInitiatingUser(Guid userIdL)
		{
			WorkflowContextMock.Setup(contextT => contextT.InitiatingUserId).Returns(userIdL);
		}

		protected void SetTarget(Entity target)
		{
			WorkflowContext.InputParameters["Target"] = target;
		}

		protected void SetTarget(EntityReference target)
		{
			WorkflowContext.InputParameters["Target"] = target;
		}

		protected void SetInputParam(string paramName, object value)
		{
			Inputs[paramName] = value;
		}

		#endregion

		#region Test

		/// <summary>
		///     A generic method for running any plugin test.<br />
		///     It uses the test method itself to extract its name,
		///     replace 'Run' with 'Setup' to invoke the setup method for that test,
		///     and replace 'Run' with 'Verify' to invoke the verify method for that test.
		/// </summary>
		/// <param name="testMethod">The method object representing the test method.</param>
		protected void RunTest(MethodBase testMethod)
		{
			if (undoTestActions)
			{
				((EnhancedOrgService)service).BeginTransaction();
			}

			try
			{
			try
			{
				// invoke the setup method for this test
				var setupMethod = GetType().GetMethod("Setup" + testMethod.Name.Replace("Run", "")
					, BindingFlags.NonPublic | BindingFlags.Instance);

				if (setupMethod == null)
				{
					throw new Exception("Couldn't find setup method in test class.");
				}
			}
			catch (Exception ex)
			{
				testFailed = true;
				throw new Exception("Failed to run setup for test.", ex);
			}

			try
			{
				// run the activity logic
				Outputs = Inputs.Count > 0 ? WFInvoker.Invoke(Inputs) : WFInvoker.Invoke();
			}
			catch (Exception ex)
			{
				Error = ex;
				testFailed = true;
				throw new Exception("Failed to run test.", ex);
			}

			try
			{
				// invoke the verify method for this test
				var verifyMethod = GetType().GetMethod("Verify" + testMethod.Name.Replace("Run", "")
					, BindingFlags.NonPublic | BindingFlags.Instance);

				if (verifyMethod == null)
				{
					throw new Exception("Couldn't find verification method in test class.");
				}

				verifyMethod.Invoke(this, null);
			}
			catch (Exception ex)
			{
				testFailed = true;
				throw new Exception("Failed to run verification for test.", ex);
			}
			}
			finally
			{
				if (undoTestActions)
				{
					try
					{
						((EnhancedOrgService)service).EndTransaction();

					}
					catch (Exception ex)
					{
						throw new Exception("Failed to undo test actions on CRM.", ex);
					}
				}
			}
		}

		#endregion

		#region Verify

		protected override sealed void Verify()
		{
		}

		#endregion

		#region Clean up

		/// <summary>
		/// Logic to run after each test, after verification, and before cleanup
		/// </summary>
		public void TestCleanup()
		{
		}

		protected override sealed void CleanUp()
		{
		}

		public static void CleanupCommon()
		{
		}

		#endregion

	}
}
