using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;

namespace Xrm.Framework.Test.Unit
{

    #region Enums

    public enum PluginAssembyIsolationMode
    {
        None = 1,
        Sandbox = 2
    }

    public enum PluginMode
    {
        Synchronous = 0,
        Asynchronous = 1
    }

    public enum SdkMessageProcessingStepImageStage
    {
        PreValidation = 10,
        PreOperation = 20,
        PostOperation = 40
    }

    #endregion
    
    /// <summary>
    /// Base Class for all Dynamics CRM Plugin Unit Tests
    /// </summary>
    public abstract class PluginUnitTest : XrmUnitTest
    {
        #region Properties

        protected IServiceProvider ServiceProvider
        {
            get;
            private set;
        }

        protected IPluginExecutionContext PluginExecutionContext
        {
            get
            {
                return ServiceProvider.GetService(typeof(IPluginExecutionContext)) as IPluginExecutionContext;
            }
        }

        protected IPlugin Plugin
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        public PluginUnitTest()
            : base()
        {
            ServiceProvider = CreateServiceProvider();
        }

        #endregion

        #region Test Methods

        protected override void Setup()
        {
            Plugin = SetupPlugin();
        }

        protected override void Do()
        {
            Plugin.Execute(ServiceProvider);
        }

        #endregion

        #region Helper Methods

        protected void SetTarget(object target)
        {
            PluginExecutionContext.InputParameters["Target"] = target;
        }

        protected object GetTarget()
        {
            return PluginExecutionContext.InputParameters["Target"];
        }

        #endregion

        #region Abstract Methods

        protected abstract IPlugin SetupPlugin();
        protected abstract IServiceProvider CreateServiceProvider();
		protected abstract void SetPluginEvent(string primaryEntityName, string messageName, SdkMessageProcessingStepImageStage stage);

        #endregion
    }
}
