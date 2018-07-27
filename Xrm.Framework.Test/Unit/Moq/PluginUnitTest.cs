using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;
using Moq;
using Xrm.Framework.Test.Unit;

namespace Xrm.Framework.Test.Unit.Moq
{
    /// <summary>
    /// Base Class for all Dynamics CRM Plugin Unit Tests using Moq
    /// </summary>
    public abstract class PluginUnitTest : Xrm.Framework.Test.Unit.PluginUnitTest
    {
        #region Properties

        protected Mock<ITracingService> TracingServiceMock
        {
            get;
            set;
        }

        protected Mock<IOrganizationServiceFactory> OrganizationServiceFactoryMock
        {
            get;
            set;
        }

        protected IOrganizationService SystemOrganizationService
        {
            get;
            set;
        }

        protected IOrganizationService OrganizationService
        {
            get;
            set;
        }

        protected Mock<IServiceProvider> ServiceProviderMock
        {
            get;
            set;
        }

        protected Mock<IPluginExecutionContext> PluginExecutionContextMock
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        public PluginUnitTest()
        {
            Init();
        }

        #endregion

        #region Setup Stubs

        protected void Init()
        {
            this.PluginExecutionContextMock = new Mock<IPluginExecutionContext>();
            this.TracingServiceMock = new Mock<ITracingService>();
            this.OrganizationServiceFactoryMock = new Mock<IOrganizationServiceFactory>();

            InitPluginExecutionContextMock(PluginExecutionContextMock);

            ServiceProviderMock.Setup(provider => provider.GetService(typeof(ITracingService))).Returns(TracingServiceMock.Object);
            ServiceProviderMock.Setup(provider => provider.GetService(typeof(IOrganizationServiceFactory))).Returns(OrganizationServiceFactoryMock.Object);
            ServiceProviderMock.Setup(provider => provider.GetService(typeof(IPluginExecutionContext))).Returns(PluginExecutionContextMock.Object);

            OrganizationServiceFactoryMock.Setup(factory => factory.CreateOrganizationService(It.IsAny<Guid?>())).Returns(OrganizationService);
        }

        protected void InitPluginExecutionContextMock(Mock<IPluginExecutionContext> mock)
        {
            mock.Setup(context => context.BusinessUnitId).Returns(Guid.NewGuid());
            mock.Setup(context => context.CorrelationId).Returns(Guid.NewGuid());
            mock.Setup(context => context.Depth).Returns(0);
            mock.Setup(context => context.InitiatingUserId).Returns(Guid.NewGuid());
            mock.Setup(context => context.InputParameters).Returns(new ParameterCollection());
            mock.Setup(context => context.IsExecutingOffline).Returns(false);
            mock.Setup(context => context.IsInTransaction).Returns(false);
            mock.Setup(context => context.IsOfflinePlayback).Returns(false);
            mock.Setup(context => context.IsolationMode).Returns((int)PluginAssembyIsolationMode.Sandbox);
            mock.Setup(context => context.MessageName).Returns(string.Empty);
            mock.Setup(context => context.Mode).Returns((int)PluginMode.Synchronous);
            mock.Setup(context => context.OperationCreatedOn).Returns(DateTime.Now);
            mock.Setup(context => context.OperationId).Returns(Guid.NewGuid());
            mock.Setup(context => context.OrganizationId).Returns(Guid.NewGuid());
            mock.Setup(context => context.OrganizationName).Returns(string.Empty);
            mock.Setup(context => context.OutputParameters).Returns(new ParameterCollection());
            mock.Setup(context => context.OwningExtension).Returns(new EntityReference());
            mock.Setup(context => context.PostEntityImages).Returns(new EntityImageCollection());
            mock.Setup(context => context.PreEntityImages).Returns(new EntityImageCollection());
            mock.Setup(context => context.PrimaryEntityId).Returns(Guid.NewGuid());
            mock.Setup(context => context.PrimaryEntityName).Returns(string.Empty);
            mock.Setup(context => context.RequestId).Returns(Guid.NewGuid());
            mock.Setup(context => context.SecondaryEntityName).Returns(string.Empty);
            mock.Setup(context => context.SharedVariables).Returns(new ParameterCollection());
            mock.Setup(context => context.UserId).Returns(Guid.NewGuid());
            mock.Setup(context => context.Stage).Returns((int)SdkMessageProcessingStepImageStage.PreValidation);
        }

        protected override IServiceProvider CreateServiceProvider()
        {
            if (this.ServiceProviderMock == null)
                this.ServiceProviderMock = new Mock<IServiceProvider>();
            return this.ServiceProviderMock.Object;
        }

        #endregion

        #region Helper Methods

        protected override void SetPluginEvent(string primaryEntityName, string messageName, SdkMessageProcessingStepImageStage stage)
        {
            PluginExecutionContextMock.Setup(context => context.PrimaryEntityName).Returns(primaryEntityName);
            PluginExecutionContextMock.Setup(context => context.MessageName).Returns(messageName);
            PluginExecutionContextMock.Setup(context => context.Stage).Returns((int)stage);
        }

        #endregion
    }
}
