using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Moq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Xrm.Framework.Test.Integration;

namespace Xrm.Framework.UnitTests.Test
{
    [TestClass]
    public class TestWFActivityIntegrationTest
    {
        private Mock<IOrganizationService> organizationServiceMock;
        private int count;

        [TestMethod]
        public void TestWFActivityIntegration()
        {
            Setup();
            Do();
            Verify();
        }

        private void Setup()
        {
            organizationServiceMock = new Mock<IOrganizationService>();
            organizationServiceMock.Setup(service => service.Execute(It.IsAny<ExecuteWorkflowRequest>())).Returns(new ExecuteWorkflowResponse());

            organizationServiceMock.Setup
                (service => service.RetrieveMultiple(It.Is<QueryByAttribute>(q => (q.EntityName == "workflow" &&
                                                                                        q.Values[0].Equals("SampleTest") &
                                                                                        q.Values[1].Equals(1)))))
                .Returns(() =>
                {
                    EntityCollection ecc = new EntityCollection();
                    Entity e = new Entity("workflow");
                    e["ondemand"] = true;
                    e["statecode"] = new OptionSetValue((int)Xrm.Framework.Test.Integration.XrmIntegrationTest.ProcessStatus.Activated);
                    ecc.Entities.Add(e);
                    return ecc;
                }
                );

            organizationServiceMock.Setup
                (service => service.RetrieveMultiple(It.Is<QueryByAttribute>(q => (q.EntityName == "asyncoperation"))))
                .Returns(() =>
                {
                    EntityCollection ecc = new EntityCollection();
                    Entity e = new Entity("asyncoperation");
                    e["statuscode"] = (count++ > 1) ? new OptionSetValue(30) : new OptionSetValue(0);
                    ecc.Entities.Add(e);
                    return ecc;
                }
               );
        }

        private void Do()
        {
            SampleTest test = new SampleTest(organizationServiceMock.Object);
            test.TestSample();
        }

        private void Verify()
        {
            organizationServiceMock.Verify(service => service.RetrieveMultiple(It.Is<QueryByAttribute>(q => (q.EntityName == "asyncoperation"))), Times.Exactly(3));
        }

        #region Sample Test Class

        private class SampleTest : WFActivityIntegrationTest
        {
            public SampleTest(IOrganizationService service)
                : base(service)
            {
            }

            public void TestSample()
            {
                base.Test();
            }

            protected override Guid SetupPrimaryEntity()
            {
                return Guid.NewGuid();
            }

            protected override void VerifyStatus()
            {
                Assert.AreEqual(Status, AsyncStatus.Pass);
            }
        }

        #endregion
    }
}
