﻿// this file was generated by the xRM Test Framework VS Extension

#region Imports

using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using Yagasoft.Libraries.Common;

#endregion

namespace $rootnamespace$
{
	/// <summary>
	///     This custom workflow step ... .<br />
	///     Version: 0.1.1
	/// </summary>
	public class $safeitemrootname$ : CodeActivity
	{
		#region Arguments
		
		////[RequiredArgument]
		////[Input("Bool input"), Default("True")]
		////public InArgument<bool> Bool { get; set; }

		////[RequiredArgument]
		////[Input("DateTime input")]
		////[Default("2013-07-09T02:54:00Z")]
		////public InArgument<DateTime> DateTime { get; set; }

		////[RequiredArgument]
		////[Input("Decimal input")]
		////[Default("20.75")]
		////public InArgument<decimal> Decimal { get; set; }

		////[RequiredArgument]
		////[Input("Double input")]
		////[Default("200.2")]
		////public InArgument<double> Double { get; set; }

		////[RequiredArgument]
		////[Input("Int input")]
		////[Default("2322")]
		////public InArgument<int> Int { get; set; }

		////[RequiredArgument]
		////[Input("Money input")]
		////[Default("232.3")]
		////public InArgument<Money> Money { get; set; }

		////[RequiredArgument]
		////[Input("OptionSetValue input")]
		////[AttributeTarget("account", "industrycode")]
		////[Default("3")]
		////public InArgument<OptionSetValue> OptionSetValue { get; set; }

		////[RequiredArgument]
		////[Input("String input")]
		////[Default("string default")]
		////public InArgument<string> String { get; set; }

		////[RequiredArgument]
		////[Input("EntityReference input")]
		////[ReferenceTarget("account")]
		////[Default("3B036E3E-94F9-DE11-B508-00155DBA2902", "account")]
		////public InArgument<EntityReference> AccountReference { get; set; }


		////[Output("Credit Score")]
		////[AttributeTarget("new_credit", "new_creditscore")]
		////public OutArgument<int> CreditScore {get;set;}
		
		#endregion

		protected override void Execute(CodeActivityContext context)
		{
			////var wfContext = context.GetExtension<IWorkflowContext>();
			new $safeitemrootname$Logic().Execute(this, context, PluginUser.ContextUser);
		}
	}

	internal class $safeitemrootname$Logic : StepLogic<$safeitemrootname$>
	{
		protected override void ExecuteLogic()
		{
			// get the triggering record
			////var target = (Entity)context.InputParameters["Target"];
			////var typedTarget = target.ToEntity<Entity>();

			////Yagasoft.Libraries.Common.CrmHelpers.LogAttributeValues(target.Attributes, target, log);

			// WF logic ...

		}
	}
}
