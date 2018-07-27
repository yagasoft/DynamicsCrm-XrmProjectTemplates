using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;

namespace Xrm.Framework.Test.Integration
{
    /// <summary>
    /// Base Class for all Dynamics CRM Plugin Integration Tests
    /// </summary>
    public abstract class PluginIntegrationTest : XrmIntegrationTest
    {
        #region Constructors

        public PluginIntegrationTest()
            : base()
        {
        }

        public PluginIntegrationTest(IOrganizationService service)
            : base(service)
        {
        }

        #endregion
    }
}
