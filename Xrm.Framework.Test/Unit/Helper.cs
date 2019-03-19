// Project / File: Tests.Plugins.UnitTests / Helper.cs
//         Author: Ahmed Elsawalhy (Yagasoft.com)
//        Created: 2015 / 04 / 05 (3:37 PM)
//       Modified: 2015 / 04 / 14 (10:13 AM)

#region Imports

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using Yagasoft.Libraries.EnhancedOrgService;
using Yagasoft.Libraries.EnhancedOrgService.Helpers;
using Yagasoft.Libraries.EnhancedOrgService.Params;
using Yagasoft.Libraries.EnhancedOrgService.Pools;
using Yagasoft.Libraries.EnhancedOrgService.Services;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Moq;


#endregion

namespace Xrm.Framework.Test.Unit
{
	/// <summary>
	///     Helper methods related to CRM or testing.<br />
	///     Version: 1.2.10
	/// </summary>
	[ExcludeFromCodeCoverage]
	internal class Helper
	{
		internal static IEnhancedServicePool<EnhancedOrgService> ServicePool =
			EnhancedServiceHelper.GetPool(Defaults.CONNECTION_STRING, 1, new EnhancedServiceParams{IsTransactionsEnabled = true});

		private static EnhancedOrgService service;
		internal static EnhancedOrgService Service => service = service ?? ServicePool.GetService();

		internal static XrmServiceContext Context => new XrmServiceContext(Service);

		#region Assembly

		/// <summary>
		///     Create a new instance of the class using its name and the assembly name.
		/// </summary>
		/// <param name="assemblyName">File name without the extension.</param>
		/// <returns>Object</returns>
		internal static T GetObject<T>(string assemblyName, string className)
		{
			var pluginAssembly = Assembly.LoadFile(new FileInfo(assemblyName + ".dll").FullName);
			var pluginClass = pluginAssembly.GetType(className, true, true);
			return (T)Activator.CreateInstance(pluginClass);
		}

		/// <summary>
		///     Returns the plugin entity, but only the ID is included.
		/// </summary>
		/// <param name="assemblyName">The name of the plugin file without the extension.</param>
		/// <returns>Assembly entity.</returns>
		internal static PluginAssembly GetAssembly(string assemblyName)
		{
			var query = new QueryByAttribute(PluginAssembly.EntityLogicalName);
			query.AddAttributeValue(PluginAssemblyFields.Name, assemblyName);
			query.ColumnSet = new ColumnSet(PluginAssemblyFields.Name);

			// get the plugin ID
			return Service.RetrieveMultiple(query).Entities.First().ToEntity<PluginAssembly>();
		}

		#endregion
	}
}
