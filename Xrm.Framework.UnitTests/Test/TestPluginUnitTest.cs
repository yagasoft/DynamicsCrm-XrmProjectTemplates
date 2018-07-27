using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Xrm.Framework.Test.Unit;

namespace Xrm.Framework.UnitTests.Test
{
    [TestClass]
    public class FakeTestPluginUnitTest : Xrm.Framework.Test.Unit.Fakes.PluginUnitTest
    {
        [TestMethod]
        public void TestFake()
        {
            base.Test();
        }

        protected override IPlugin SetupPlugin()
        {
            return new TestPlugin();
        }

        protected override void Verify()
        {
            Assert.IsNull(Error);
        }

        private class TestPlugin : IPlugin
        {
            public void Execute(IServiceProvider serviceProvider)
            {
                Assert.IsNotNull(serviceProvider);
                
                ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
                Assert.IsNotNull(tracingService);

                IPluginExecutionContext pluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
                Assert.IsNotNull(pluginExecutionContext);
                Assert.AreNotEqual(pluginExecutionContext.BusinessUnitId, Guid.Empty);
                Assert.AreNotEqual(pluginExecutionContext.CorrelationId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.Depth, 0);
                Assert.AreNotEqual(pluginExecutionContext.InitiatingUserId, Guid.Empty);
                Assert.IsNotNull(pluginExecutionContext.InputParameters);
                Assert.IsFalse(pluginExecutionContext.IsExecutingOffline);
                Assert.IsFalse(pluginExecutionContext.IsInTransaction);
                Assert.IsFalse(pluginExecutionContext.IsOfflinePlayback);
                Assert.AreEqual(pluginExecutionContext.IsolationMode, (int) PluginAssembyIsolationMode.Sandbox);
                Assert.AreEqual(pluginExecutionContext.MessageName, string.Empty);
                Assert.AreEqual(pluginExecutionContext.Mode, (int)PluginMode.Synchronous);
                Assert.AreNotEqual(pluginExecutionContext.OperationCreatedOn, DateTime.MinValue);
                Assert.AreNotEqual(pluginExecutionContext.OperationId, Guid.Empty);
                Assert.AreNotEqual(pluginExecutionContext.OrganizationId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.OrganizationName, string.Empty);
                Assert.IsNotNull(pluginExecutionContext.OutputParameters);
                Assert.IsNotNull(pluginExecutionContext.OwningExtension);
                Assert.IsNotNull(pluginExecutionContext.PreEntityImages);
                Assert.IsNotNull(pluginExecutionContext.PostEntityImages);
                Assert.AreNotEqual(pluginExecutionContext.PrimaryEntityId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.PrimaryEntityName, string.Empty);
                Assert.AreNotEqual(pluginExecutionContext.RequestId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.SecondaryEntityName, string.Empty);
                Assert.IsNotNull(pluginExecutionContext.SharedVariables);
                Assert.AreNotEqual(pluginExecutionContext.UserId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.Stage, (int)SdkMessageProcessingStepImageStage.PreValidation);

                IOrganizationServiceFactory organizationServiceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                Assert.IsNotNull(organizationServiceFactory);

                IOrganizationService systemoOrganizationService = organizationServiceFactory.CreateOrganizationService(null);
                Assert.IsNotNull(systemoOrganizationService);
                Assert.AreNotEqual(systemoOrganizationService.Create(new Entity()), Guid.Empty);

                IOrganizationService organizationService = organizationServiceFactory.CreateOrganizationService(pluginExecutionContext.UserId);
                Assert.IsNotNull(organizationService);
                Assert.AreNotEqual(organizationService.Create(new Entity()), Guid.Empty);

                Assert.AreNotSame(organizationService, systemoOrganizationService);
            }
        }
    }

    [TestClass]
    public class MoqTestPluginUnitTest : Xrm.Framework.Test.Unit.Moq.PluginUnitTest
    {
        [TestMethod]
        public void TestMoq()
        {
            base.Test();
        }

        protected override IPlugin SetupPlugin()
        {
            return new TestPlugin();
        }

        protected override void Verify()
        {
            Assert.IsNull(Error);
        }

        private class TestPlugin : IPlugin
        {
            public void Execute(IServiceProvider serviceProvider)
            {
                Assert.IsNotNull(serviceProvider);

                ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
                Assert.IsNotNull(tracingService);

                IPluginExecutionContext pluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
                Assert.IsNotNull(pluginExecutionContext);
                Assert.AreNotEqual(pluginExecutionContext.BusinessUnitId, Guid.Empty);
                Assert.AreNotEqual(pluginExecutionContext.CorrelationId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.Depth, 0);
                Assert.AreNotEqual(pluginExecutionContext.InitiatingUserId, Guid.Empty);
                Assert.IsNotNull(pluginExecutionContext.InputParameters);
                Assert.IsFalse(pluginExecutionContext.IsExecutingOffline);
                Assert.IsFalse(pluginExecutionContext.IsInTransaction);
                Assert.IsFalse(pluginExecutionContext.IsOfflinePlayback);
                Assert.AreEqual(pluginExecutionContext.IsolationMode, (int)PluginAssembyIsolationMode.Sandbox);
                Assert.AreEqual(pluginExecutionContext.MessageName, string.Empty);
                Assert.AreEqual(pluginExecutionContext.Mode, (int)PluginMode.Synchronous);
                Assert.AreNotEqual(pluginExecutionContext.OperationCreatedOn, DateTime.MinValue);
                Assert.AreNotEqual(pluginExecutionContext.OperationId, Guid.Empty);
                Assert.AreNotEqual(pluginExecutionContext.OrganizationId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.OrganizationName, string.Empty);
                Assert.IsNotNull(pluginExecutionContext.OutputParameters);
                Assert.IsNotNull(pluginExecutionContext.OwningExtension);
                Assert.IsNotNull(pluginExecutionContext.PreEntityImages);
                Assert.IsNotNull(pluginExecutionContext.PostEntityImages);
                Assert.AreNotEqual(pluginExecutionContext.PrimaryEntityId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.PrimaryEntityName, string.Empty);
                Assert.AreNotEqual(pluginExecutionContext.RequestId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.SecondaryEntityName, string.Empty);
                Assert.IsNotNull(pluginExecutionContext.SharedVariables);
                Assert.AreNotEqual(pluginExecutionContext.UserId, Guid.Empty);
                Assert.AreEqual(pluginExecutionContext.Stage, (int)SdkMessageProcessingStepImageStage.PreValidation);

                IOrganizationServiceFactory organizationServiceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                Assert.IsNotNull(organizationServiceFactory);

                IOrganizationService systemoOrganizationService = organizationServiceFactory.CreateOrganizationService(null);
                Assert.IsNotNull(systemoOrganizationService);
                Assert.AreNotEqual(systemoOrganizationService.Create(new Entity()), Guid.Empty);

                IOrganizationService organizationService = organizationServiceFactory.CreateOrganizationService(pluginExecutionContext.UserId);
                Assert.IsNotNull(organizationService);
                Assert.AreNotEqual(organizationService.Create(new Entity()), Guid.Empty);

                Assert.AreNotSame(organizationService, systemoOrganizationService);
            }
        }
    }
}
