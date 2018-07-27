using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Moq;
using Microsoft.Xrm.Sdk.Query;
using Xrm.Framework.Test.Integration;

namespace Xrm.Framework.UnitTests.Test
{
    [TestClass]
    public class TestAsyncPluginIntegrationTest
    {
        private Mock<IOrganizationService> organizationServiceMock;
        private int count;

        [TestMethod]
        public void TestAsycPluginIntegration()
        {
            Setup();
            Do();
            Verify();
        }

        private void Setup()
        {
            organizationServiceMock = new Mock<IOrganizationService>();
            
            organizationServiceMock.Setup(service => service.Execute(It.IsAny<CreateRequest>())).Returns(new CreateResponse());

            organizationServiceMock.Setup
                (service => service.RetrieveMultiple(It.Is<QueryByAttribute>(q => (q.Values[0].Equals("Sample") && q.Values[1].Equals(1)))))
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
            organizationServiceMock.Verify(service => service.RetrieveMultiple(It.IsAny<QueryByAttribute>()), Times.Exactly(3));
        }

        private EntityCollection GetEntityCollection()
        {
            EntityCollection asyncOperations = new EntityCollection();
            return asyncOperations;
        }

        #region Sample Test Class

        private class SampleTest : AsyncPluginIntegrationTest
        {
            public SampleTest(IOrganizationService service)
                : base(service)
            {
            }

            public void TestSample()
            {
                base.Test();
            }
            
            protected override void VerifyStatus()
            {
                Assert.AreEqual(Status, AsyncStatus.Pass);
            }

            protected override OrganizationRequest SetupTriggerRequest()
            {
                CreateRequest req = new CreateRequest();
                req.Target = new Entity("contact");
                return req;
            }
        }

        #endregion
    }
}
