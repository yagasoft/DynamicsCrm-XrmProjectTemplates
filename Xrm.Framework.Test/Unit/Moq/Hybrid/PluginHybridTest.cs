// Project / File: Tests.Plugins.UnitTests / PluginHybridTest.cs
//         Author: Ahmed el-Sawalhy (LINK Development - MBS)
//        Created: 2015 / 04 / 14 (9:39 AM)
//       Modified: 2015 / 04 / 19 (1:19 PM)

#region Imports

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using LinkDev.Libraries.EnhancedOrgService;
using LinkDev.Libraries.EnhancedOrgService.Services;
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
	public abstract class PluginHybridTest : Xrm.Framework.Test.Unit.Moq.PluginUnitTest
	{
		#region New properties

		protected string assemblyName;
		protected string className;

		protected Type pluginClass
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

		protected bool disableSteps;
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

			// we need the organisation name to add it to the plugin context
			if (orgName == null)
			{
				var whoAmI = (WhoAmIResponse)service.Execute(new WhoAmIRequest());
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
			PluginExecutionContextMock.Setup(contextT => contextT.UserId).Returns(userId);
			PluginExecutionContextMock.Setup(contextT => contextT.InitiatingUserId).Returns(userId);
			PluginExecutionContextMock.Setup(contextT => contextT.BusinessUnitId).Returns(businessUnitId);
			PluginExecutionContextMock.Setup(contextT => contextT.OrganizationId).Returns(orgId);
			PluginExecutionContextMock.Setup(contextT => contextT.OrganizationName).Returns(orgName);

			// any plugin instance requesting a service will get this one
			OrganizationServiceFactoryMock.Setup(factory => factory.CreateOrganizationService(It.IsAny<Guid?>())).Returns(OrganizationService);
		}

		protected abstract void SetupCommon();

		/// <summary>
		///     Returns an empty plugin, because the framework forces the testing of only one case,
		///     but we want to create more than one test.
		/// </summary>
		/// <returns>Empty plugin</returns>
		protected sealed override IPlugin SetupPlugin()
		{
			return new PluginsHelper.PluginShell();
		}

		#region Plugin context

		/// <summary>
		///     Sets the user ID that the plugin will run under.
		/// </summary>
		/// <param name="userIdL">The user ID</param>
		protected void SetUser(Guid userIdL)
		{
			PluginExecutionContextMock.Setup(contextT => contextT.UserId).Returns(userIdL);
		}

		/// <summary>
		///     Sets the initiating user ID for the plugin.
		/// </summary>
		/// <param name="userIdL">The user ID</param>
		protected void SetInitiatingUser(Guid userIdL)
		{
			PluginExecutionContextMock.Setup(contextT => contextT.InitiatingUserId).Returns(userIdL);
		}

		/// <summary>
		///     Adds a key and value to the input parameters in the context.
		/// </summary>
		/// <param name="key">The key</param>
		/// <param name="value">The value</param>
		protected void AddInputParameter(string key, object value)
		{
			PluginExecutionContext.InputParameters.Add(key, value);
		}

		/// <summary>
		///     Adds a record image to the plugin context as a pre image
		/// </summary>
		/// <param name="imageName">Image name as in the plugin registration tool</param>
		/// <param name="entity">The record image</param>
		protected void AddPreImage(string imageName, Entity entity)
		{
			PluginExecutionContext.PreEntityImages.Add(imageName, entity);
		}

		/// <summary>
		///     Adds a record image to the plugin context as a post image
		/// </summary>
		/// <param name="imageName">Image name as in the plugin registration tool</param>
		/// <param name="entity">The record image</param>
		protected void AddPostImage(string imageName, Entity entity)
		{
			PluginExecutionContext.PostEntityImages.Add(imageName, entity);
		}

		/// <summary>
		///     Adds a collection of target related entities (as references) to the plugin context.
		/// </summary>
		/// <param name="relationshipSchemaName">The relationship's schema name as it appears in the target.</param>
		/// <param name="relatedEntities">The entities related to the plugin target.</param>
		protected void AddAssociation(string relationshipSchemaName, params EntityReference[] relatedEntities)
		{
			PluginExecutionContext.InputParameters
								  .Add("Relationship", new Relationship(relationshipSchemaName));
			PluginExecutionContext.InputParameters
								  .Add("RelatedEntities", new EntityReferenceCollection(relatedEntities));
		}

		/// <summary>
		///     Sets the assignee in the plugin context for the 'Assign' message.
		/// </summary>
		/// <param name="assignee">Entity reference to the assignee record</param>
		protected void SetAssignee(EntityReference assignee)
		{
			PluginExecutionContext.InputParameters.Add("Assignee", assignee);
		}

		/// <summary>
		///     Sets the incident resolution in the plugin context for the 'Close' message.
		/// </summary>
		/// <param name="resolution">Incident resolution entity</param>
		protected void SetIncidentResolution(Entity resolution)
		{
			PluginExecutionContext.InputParameters.Add("IncidentResolution", resolution);
		}

		#endregion

		protected override void SetPluginEvent(string primaryEntityName, string messageName,
			SdkMessageProcessingStepImageStage stage)
		{
			base.SetPluginEvent(primaryEntityName, messageName, stage);

			// it's better to disable steps in this plugin to avoid conflict.
			if (disableSteps)
			{
				PluginsHelper.DisableSteps(assemblyName, primaryEntityName, messageName, disabledSteps);
			}
		}

		protected void PrepareTest()
		{
			try
			{
				Error = null;
				SetupEnvironment();
				Plugin = Helper.GetObject<IPlugin>(assemblyName, className);
			}
			catch
			{
				testFailed = true; // this prevents the test from updating the plugin assembly
				throw;
			}
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
					var setupMethod = GetType().GetMethod("Setup" + testMethod.Name.Replace("Run", "")
						, BindingFlags.NonPublic | BindingFlags.Instance);

					if (setupMethod == null)
					{
						throw new Exception("Couldn't find setup method in test class.");
					}

					// invoke the setup method for this test
					setupMethod.Invoke(this, null);
				}
				catch (Exception ex)
				{
					testFailed = true;
					throw new Exception("Failed to run setup for test.", ex);
				}

				try
				{
					// run the plugin logic
					Plugin.Execute(ServiceProvider);
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

		protected sealed override void Verify()
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

		protected sealed override void CleanUp()
		{
		}

		public static void CleanupCommon()
		{
			PluginsHelper.EnableSteps(disabledSteps);
		}

		#endregion

	}
}
