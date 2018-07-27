using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Xrm.Framework.Test.Integration
{
    #region Enums

    public enum AsyncStatus
    {
        Pass,
        Fail,
        TimeOut
    }

    #endregion
    
    /// <summary>
    /// Base Class for all Asynchronous Operations Integration Tests
    /// </summary>
    public abstract class AsyncIntegrationTest : XrmIntegrationTest
    {
        #region Properties

        protected int TimeOut
        {
            get;
            set;
        }

        protected int SleepInterval
        {
            get;
            set;
        }

        private int SleptInterval
        {
            get;
            set;
        }

        protected AsyncStatus Status
        {
            get;
            private set;
        }

        #endregion

        #region Constructors

        public AsyncIntegrationTest()
            : base()
        {
        }

        public AsyncIntegrationTest(IOrganizationService service)
            : base(service)
        {
        }

        #endregion

        #region Override Test Methods

        protected override void Setup()
        {
            base.Setup();
            TimeOut = 60 * 1000;
            SleepInterval = 2 * 1000;
        }

        protected override void Verify()
        {
            while (SleptInterval <= TimeOut)
            {
                CheckAsyncStatus();
                if (Status == AsyncStatus.Fail || Status == AsyncStatus.Pass)
                {
                    break;
                }
                else
                {
                    Thread.Sleep(SleepInterval);
                    SleptInterval += SleepInterval;
                }
            }   
            VerifyStatus();
        }

        #endregion

        #region Abstract Methods

        protected abstract int AsyncOperationType { get; }
        protected abstract string AsyncOperationName { get; }
        protected abstract void VerifyStatus();

        #endregion

        #region Private Methods

        private void CheckAsyncStatus()
        {
            Entity asyncOperation = RetrieveAsyncOperation();

            if (asyncOperation != null)
            {
                int status = (int)((OptionSetValue)asyncOperation["statuscode"]).Value;

                if (status == 30)
                {
                    Status = AsyncStatus.Pass;
                }
                else if (status == 0 || status == 20)
                {
                    Status = AsyncStatus.TimeOut;
                }
                else
                {
                    Status = AsyncStatus.Fail;
                }
            }
            else
            {
                Status = AsyncStatus.TimeOut;
            }
        }

        private Entity RetrieveAsyncOperation()
        {
            QueryByAttribute query = new QueryByAttribute("asyncoperation");
            query.ColumnSet = new ColumnSet("asyncoperationid", "statuscode");
            query.Attributes.AddRange(new string[] { "name", "operationtype", "requestid" });
            query.Values.AddRange(new object[] { AsyncOperationName, AsyncOperationType, TriggerRequest.RequestId });

            EntityCollection ec = OrganizationService.RetrieveMultiple(query);

            if (ec.Entities.Count == 1)
            {
                return ec[0];
            }
            return null;
        }

        #endregion
    }
}
