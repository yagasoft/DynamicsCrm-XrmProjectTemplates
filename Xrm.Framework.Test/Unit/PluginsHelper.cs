// Project / File: Tests.Plugins.UnitTests / PluginsHelper.cs
//         Author: Ahmed Elsawalhy (Yagasoft.com)
//        Created: 2015 / 04 / 02 (11:05 AM)
//       Modified: 2015 / 04 / 06 (1:08 PM)

#region Imports

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

#endregion

namespace Xrm.Framework.Test.Unit
{
	/// <summary>
	///     Helper methods related to plugins.<br />
	///     Version: 1.1.20
	/// </summary>
	[ExcludeFromCodeCoverage]
	internal class PluginsHelper : Helper
	{
		#region Plugin class

		internal class PluginShell : IPlugin
		{
			public void Execute(IServiceProvider serviceProvider)
			{ }
		}

		#endregion

		#region Plugin steps

		internal static void SetStepsState(bool isEnabled, string[] pluginPatternsToToggle)
		{
			foreach (var step in GetMatchingSteps(!isEnabled, pluginPatternsToToggle))
			{
				Service.Update(
					new Entity(SdkMessageProcessingStep.EntityLogicalName)
					{
						Id = step.Id,
						["statecode"] = new OptionSetValue((int)(
							isEnabled
								? SdkMessageProcessingStepState.Enabled
								: SdkMessageProcessingStepState.Disabled)),
						["statuscode"] = new OptionSetValue((int)(
							isEnabled
								? SdkMessageProcessingStepEnums.StatusCode.Enabled
								: SdkMessageProcessingStepEnums.StatusCode.Disabled))
					});
			}
		}

		private static EntityReference[] GetMatchingSteps(bool isEnabled, string[] pluginPatternsToToggle)
		{
			var stepQuery = new QueryExpression("sdkmessageprocessingstep");
			stepQuery.ColumnSet.AddColumns("sdkmessageprocessingstepid", "name");
			stepQuery.Criteria.AddCondition("statecode", ConditionOperator.Equal, isEnabled ? 0 : 1);
			var typeLink = stepQuery.AddLink("plugintype", "eventhandler", "plugintypeid");
			typeLink.EntityAlias = "typeAliased";
			typeLink.Columns.AddColumns("name");
			var assemblyLink = typeLink.AddLink("pluginassembly", "pluginassemblyid", "pluginassemblyid");
			assemblyLink.EntityAlias = "assemblyAliased";
			assemblyLink.Columns.AddColumns("name");

			return Service.RetrieveMultiple(stepQuery).Entities
				.Select(step =>
					new
					{
						stepId = step.Id,
						stepName = step.GetAttributeValue<string>("name"),
						typeName = (string)step.GetAttributeValue<AliasedValue>("typeAliased.name").Value,
						assemblyName = (string)step.GetAttributeValue<AliasedValue>("assemblyAliased.name").Value
					})
				.ToArray()
				.Where(s => pluginPatternsToToggle.Any(n => Regex.IsMatch(s.stepName, n))
					|| pluginPatternsToToggle.Any(n => Regex.IsMatch(s.typeName, n))
					|| pluginPatternsToToggle.Any(n => Regex.IsMatch(s.assemblyName, n)))
				.Select(s => new EntityReference(SdkMessageProcessingStep.EntityLogicalName, s.stepId))
				.ToArray();
		}

		#endregion
	}
}
