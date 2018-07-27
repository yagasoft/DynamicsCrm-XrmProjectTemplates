using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;

namespace Xrm.Framework.Test.Integration
{
    /// <summary>
    /// Base Class for all Dynamics CRM Integration Tests
    /// </summary>
    public abstract class XrmIntegrationTest : XrmTest
    {
        #region Enums
        
        /// <summary>
        /// Process ('workflow' as logical name) status
        /// </summary>
        public enum ProcessStatus
        {
            Draft = 0,
            Activated = 1
        }

        /// <summary>
        /// Process ('workflow' as logical name) Type
        /// </summary>
        public enum ProcessType
        {
            Defition = 1,
            Activation = 2,
            Template = 3
        }

        #endregion

        #region Instance Variables

        private IOrganizationService _service;
        private CrmConnection _connection;

        #endregion

        #region Properties

        protected IOrganizationService OrganizationService
        {
            get
            {
                if (_service == null)
                {
                    _service = new OrganizationService(Connection);
                }
                return _service;
            }
        }

        protected CrmConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new CrmConnection("Xrm");
                }
                return _connection;
            }
        }

        protected OrganizationRequest TriggerRequest
        {
            get;
            private set;
        }

        protected OrganizationResponse TriggerResponse
        {
            get;
            private set;
        }

        #endregion

        #region Constructors

        public XrmIntegrationTest()
            : base()
        {
        }

        public XrmIntegrationTest(IOrganizationService service)
            : base()
        {
            _service = service;
        }

        #endregion

        #region Test Methods

        protected override void Setup()
        {
            TriggerRequest = SetupTriggerRequest();

            if (!TriggerRequest.RequestId.HasValue)
            {
                TriggerRequest.RequestId = Guid.NewGuid();
            }
        }

        protected override void Do()
        {
            TriggerResponse = OrganizationService.Execute(TriggerRequest);
        }

        #endregion

        #region Abstract Methods

        protected abstract OrganizationRequest SetupTriggerRequest();

        #endregion
    }
}
