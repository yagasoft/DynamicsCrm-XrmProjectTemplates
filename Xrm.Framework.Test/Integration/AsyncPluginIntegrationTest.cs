using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Xrm.Framework.Test.Integration
{
    /// <summary>
    /// Base Class for all Asynchronous Plugins Integration Tests
    /// </summary>
    public abstract class AsyncPluginIntegrationTest : AsyncIntegrationTest
    {
        #region Properties

        protected override string AsyncOperationName
        {
            get
            {
                return this.GetType().Name.Replace("Test", "");
            }
        }

        protected override int AsyncOperationType
        {
            get
            {
                return 1;
            }
        }

        #endregion

        #region Constructors

        public AsyncPluginIntegrationTest()
            : base()
        {
        }

        public AsyncPluginIntegrationTest(IOrganizationService service)
            : base(service)
        {
        }

        #endregion
    }
}
