using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Moq;
using Microsoft.Xrm.Sdk.Messages;
using Xrm.Framework.Test.Integration;

namespace Xrm.Framework.UnitTests.Test
{
    [TestClass]
    public class TestPluginIntegrationTest
    {
        private Mock<IOrganizationService> organizationServiceMock;
        
        [TestMethod]
        public void TestPluginIntegration()
        {
            Setup();
            Do();
            Verify();
        }

        private void Setup()
        {
            organizationServiceMock = new Mock<IOrganizationService>();

            organizationServiceMock.Setup(service => service.Execute(It.Is<CreateRequest>(q => q.Target.LogicalName == "contact"))).Returns(new CreateResponse());
        }

        private void Do()
        {
            SampleTest test = new SampleTest(organizationServiceMock.Object);
            test.TestSample();
        }

        private void Verify()
        {
            organizationServiceMock.Verify(service => service.Execute(It.Is<CreateRequest>(q => q.Target.LogicalName == "contact")), Times.Exactly(1));
        }

        #region Sample Test Class

        private class SampleTest : PluginIntegrationTest
        {
            public SampleTest(IOrganizationService service)
                : base(service)
            {
            }

            public void TestSample()
            {
                base.Test();
            }

            protected override void Verify()
            {
            }

            protected override OrganizationRequest SetupTriggerRequest()
            {
                return new CreateRequest() {Target = new Entity("contact")};
            }
        }

        #endregion
    }
}
