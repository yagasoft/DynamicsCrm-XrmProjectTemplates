// Project / File: Tests.Plugins.UnitTests / PluginsHelper.cs
//         Author: Ahmed el-Sawalhy (LINK Development - MBS)
//        Created: 2015 / 04 / 02 (11:05 AM)
//       Modified: 2015 / 04 / 06 (1:08 PM)

#region Imports

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

#endregion

namespace Xrm.Framework.Test.Unit
{
	/// <summary>
	/// Helper methods related to plugins.<br />
	/// Version: 1.1.20
	/// </summary>
	[ExcludeFromCodeCoverage]
	internal class PluginsHelper : Helper
	{
		#region Plugin class


		internal class PluginShell : IPlugin
		{
			public void Execute(IServiceProvider serviceProvider)
			{
			}
		}

		#endregion
		
		#region Plugin steps

		/// <summary>
		///     Disables enabled steps under the registered plugin passed as argument,
		///     and adds those steps to a list to be enabled later (saving state).
		/// </summary>
		/// <param name="assemblyName">File name of the plugin without the extension.</param>
		/// <param name="primaryEntityName"></param>
		/// <param name="messageName"></param>
		/// <param name="enabledSteps">List to save enabled steps in.</param>
		internal static void DisableSteps(string assemblyName, string primaryEntityName, string messageName
			, List<SdkMessageProcessingStep> enabledSteps)
		{
			// get only enabled steps under the plugin
			var query = new QueryExpression(SdkMessageProcessingStep.EntityLogicalName);
			query.AddLink(PluginType.EntityLogicalName
				, SdkMessageProcessingStepFields.EventHandler, PluginTypeFields.PluginTypeId)
				.AddLink(PluginAssembly.EntityLogicalName
				, PluginTypeFields.PluginAssemblyId, PluginAssemblyFields.PluginAssemblyId)
				.LinkCriteria.AddCondition(PluginAssemblyFields.Name, ConditionOperator.Equal, assemblyName);
			query.AddLink(SdkMessageFilter.EntityLogicalName
				, SdkMessageProcessingStepFields.SdkMessageFilterId, SdkMessageFilterFields.SdkMessageFilterId)
				.LinkCriteria.AddCondition(SdkMessageFilterFields.PrimaryObjectTypeCode
				, ConditionOperator.Equal, primaryEntityName);
			query.AddLink(SdkMessage.EntityLogicalName
				, SdkMessageProcessingStepFields.SdkMessageId, SdkMessageFields.SdkMessageId)
				.LinkCriteria.AddCondition(SdkMessageFields.Name, ConditionOperator.Equal, messageName);
			query.Criteria.AddCondition(SdkMessageProcessingStepFields.StatusCode
				, ConditionOperator.Equal, (int)SdkMessageProcessingStepEnums.StatusCode.Enabled);
			query.ColumnSet = new ColumnSet(SdkMessageProcessingStepFields.Name);
			var steps = Service.RetrieveMultiple(query)
				.Entities.Select(step => step.ToEntity<SdkMessageProcessingStep>());

			// disable enabled steps only
			foreach (var assemblyStep in steps)
			{
				// save the steps that are enabled to re-enable them again later
				enabledSteps.Add(assemblyStep);

				var request = new SetStateRequest
				              {
					              EntityMoniker = assemblyStep.ToEntityReference(),
					              State = new OptionSetValue((int) SdkMessageProcessingStepState.Disabled),
					              Status = new OptionSetValue((int) SdkMessageProcessingStepEnums.StatusCode.Disabled)
				              };
				Service.Execute(request);
			}
		}

		/// <summary>
		///     Enable disabled steps that were previously enabled only, using the provided list.
		/// </summary>
		/// <param name="enabledSteps">List of previously enabled steps.</param>
		internal static void EnableSteps(List<SdkMessageProcessingStep> enabledSteps)
		{
			// enabled disabled steps that were 
			foreach (var assemblyStep in enabledSteps)
			{
				var request = new SetStateRequest
				              {
					              EntityMoniker = assemblyStep.ToEntityReference(),
					              State = new OptionSetValue((int) SdkMessageProcessingStepState.Enabled),
					              Status = new OptionSetValue((int) SdkMessageProcessingStepEnums.StatusCode.Enabled)
				              };
				Service.Execute(request);
			}
		}

		#endregion
	}
}
