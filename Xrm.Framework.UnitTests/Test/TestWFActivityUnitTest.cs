using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using Xrm.Framework.Test.Unit;

namespace Xrm.Framework.UnitTests.Test
{
    [TestClass]
    public class MoqTestWFActivityUnitTest : Xrm.Framework.Test.Unit.Moq.WFActivityUnitTest
    {
        [TestMethod]
        public void TestMocks()
        {
            base.Test();
        }

        protected override Activity SetupActivity()
        {
            return new TestActivity() { Input = "Test" };
        }

        protected override void Verify()
        {
            Assert.IsNull(Error);
            Assert.IsNotNull(Outputs);
            Assert.AreEqual("TestModified", Outputs["Output"]);
        }

        private class TestActivity : CodeActivity
        {
            public InArgument<string> Input { get; set; }

            public OutArgument<string> Output { get; set; }

            protected override void Execute(CodeActivityContext context)
            {
                Assert.IsNotNull(context);

                ITracingService tracingService = context.GetExtension<ITracingService>();
                Assert.IsNotNull(tracingService);

                IWorkflowContext workflowContext = context.GetExtension<IWorkflowContext>();
                Assert.IsNotNull(workflowContext);
                Assert.AreNotEqual(workflowContext.BusinessUnitId, Guid.Empty);
                Assert.AreNotEqual(workflowContext.CorrelationId, Guid.Empty);
                Assert.AreEqual(workflowContext.Depth, 0);
                Assert.AreNotEqual(workflowContext.InitiatingUserId, Guid.Empty);
                Assert.IsNotNull(workflowContext.InputParameters);
                Assert.IsFalse(workflowContext.IsExecutingOffline);
                Assert.IsFalse(workflowContext.IsInTransaction);
                Assert.IsFalse(workflowContext.IsOfflinePlayback);
                Assert.AreEqual(workflowContext.MessageName, string.Empty);
                Assert.AreNotEqual(workflowContext.OperationCreatedOn, DateTime.MinValue);
                Assert.AreNotEqual(workflowContext.OperationId, Guid.Empty);
                Assert.AreNotEqual(workflowContext.OrganizationId, Guid.Empty);
                Assert.AreEqual(workflowContext.OrganizationName, string.Empty);
                Assert.IsNotNull(workflowContext.OutputParameters);
                Assert.IsNotNull(workflowContext.OwningExtension);
                Assert.IsNotNull(workflowContext.PreEntityImages);
                Assert.IsNotNull(workflowContext.PostEntityImages);
                Assert.AreNotEqual(workflowContext.PrimaryEntityId, Guid.Empty);
                Assert.AreEqual(workflowContext.PrimaryEntityName, string.Empty);
                Assert.AreNotEqual(workflowContext.RequestId, Guid.Empty);
                Assert.AreEqual(workflowContext.SecondaryEntityName, string.Empty);
                Assert.IsNotNull(workflowContext.SharedVariables);
                Assert.AreNotEqual(workflowContext.UserId, Guid.Empty);
                Assert.AreEqual(workflowContext.StageName, string.Empty);
                Assert.AreEqual(workflowContext.WorkflowCategory, (int)WorkflowCategory.Workflow);

                IOrganizationServiceFactory organizationServiceFactory = context.GetExtension<IOrganizationServiceFactory>();
                Assert.IsNotNull(organizationServiceFactory);

                IOrganizationService systemoOrganizationService = organizationServiceFactory.CreateOrganizationService(null);
                Assert.IsNotNull(systemoOrganizationService);
                Assert.AreNotEqual(systemoOrganizationService.Create(new Entity()), Guid.Empty);

                IOrganizationService organizationService = organizationServiceFactory.CreateOrganizationService(workflowContext.UserId);
                Assert.IsNotNull(organizationService);
                Assert.AreNotEqual(organizationService.Create(new Entity()), Guid.Empty);

                Assert.AreNotSame(organizationService, systemoOrganizationService);

                Assert.IsNotNull(Input.Get(context));
                Assert.AreNotEqual(string.Empty, Input.Get(context));

                Output.Set(context, Input.Get(context) + "Modified");
            }
        }
    }

    [TestClass]
    public class FakesTestWFActivityUnitTest : Xrm.Framework.Test.Unit.Fakes.WFActivityUnitTest
    {
        [TestMethod]
        public void TestFakes()
        {
            base.Test();
        }

        protected override Activity SetupActivity()
        {
            return new TestActivity() { Input = "Test" };
        }

        protected override void Verify()
        {
            Assert.IsNull(Error);
            Assert.IsNotNull(Outputs);
            Assert.AreEqual("TestModified", Outputs["Output"]);
        }

        private class TestActivity : CodeActivity
        {
            public InArgument<string> Input { get; set; }

            public OutArgument<string> Output { get; set; }

            protected override void Execute(CodeActivityContext context)
            {
                Assert.IsNotNull(context);

                ITracingService tracingService = context.GetExtension<ITracingService>();
                Assert.IsNotNull(tracingService);

                IWorkflowContext workflowContext = context.GetExtension<IWorkflowContext>();
                Assert.IsNotNull(workflowContext);
                Assert.AreNotEqual(workflowContext.BusinessUnitId, Guid.Empty);
                Assert.AreNotEqual(workflowContext.CorrelationId, Guid.Empty);
                Assert.AreEqual(workflowContext.Depth, 0);
                Assert.AreNotEqual(workflowContext.InitiatingUserId, Guid.Empty);
                Assert.IsNotNull(workflowContext.InputParameters);
                Assert.IsFalse(workflowContext.IsExecutingOffline);
                Assert.IsFalse(workflowContext.IsInTransaction);
                Assert.IsFalse(workflowContext.IsOfflinePlayback);
                Assert.AreEqual(workflowContext.MessageName, string.Empty);
                Assert.AreNotEqual(workflowContext.OperationCreatedOn, DateTime.MinValue);
                Assert.AreNotEqual(workflowContext.OperationId, Guid.Empty);
                Assert.AreNotEqual(workflowContext.OrganizationId, Guid.Empty);
                Assert.AreEqual(workflowContext.OrganizationName, string.Empty);
                Assert.IsNotNull(workflowContext.OutputParameters);
                Assert.IsNotNull(workflowContext.OwningExtension);
                Assert.IsNotNull(workflowContext.PreEntityImages);
                Assert.IsNotNull(workflowContext.PostEntityImages);
                Assert.AreNotEqual(workflowContext.PrimaryEntityId, Guid.Empty);
                Assert.AreEqual(workflowContext.PrimaryEntityName, string.Empty);
                Assert.AreNotEqual(workflowContext.RequestId, Guid.Empty);
                Assert.AreEqual(workflowContext.SecondaryEntityName, string.Empty);
                Assert.IsNotNull(workflowContext.SharedVariables);
                Assert.AreNotEqual(workflowContext.UserId, Guid.Empty);
                Assert.AreEqual(workflowContext.StageName, string.Empty);
                Assert.AreEqual(workflowContext.WorkflowCategory, (int)WorkflowCategory.Workflow);

                IOrganizationServiceFactory organizationServiceFactory = context.GetExtension<IOrganizationServiceFactory>();
                Assert.IsNotNull(organizationServiceFactory);

                IOrganizationService systemoOrganizationService = organizationServiceFactory.CreateOrganizationService(null);
                Assert.IsNotNull(systemoOrganizationService);
                Assert.AreNotEqual(systemoOrganizationService.Create(new Entity()), Guid.Empty);

                IOrganizationService organizationService = organizationServiceFactory.CreateOrganizationService(workflowContext.UserId);
                Assert.IsNotNull(organizationService);
                Assert.AreNotEqual(organizationService.Create(new Entity()), Guid.Empty);

                Assert.AreNotSame(organizationService, systemoOrganizationService);

                Assert.IsNotNull(Input.Get(context));
                Assert.AreNotEqual(string.Empty, Input.Get(context));

                Output.Set(context, Input.Get(context) + "Modified");
            }
        }
    }
}
