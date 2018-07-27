using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Moq;
using Microsoft.Xrm.Sdk.Workflow;
using Xrm.Framework.Test.Unit;
using Xrm.Framework.Test.Unit.Moq;

namespace Xrm.Framework.Test.Unit.Moq
{
    /// <summary>
    /// Base Class for all Dynamics CRM 2011 Custom Workflow Activities using Moq
    /// </summary>
    public abstract class WFActivityUnitTest : Xrm.Framework.Test.Unit.WFActivityUnitTest
    {
        #region Properties

        protected Mock<IWorkflowContext> WorkflowContextMock
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

        protected Mock<IOrganizationServiceFactory> OrganizationServiceFactoryMock
        {
            get;
            set;
        }

        protected Mock<ITracingService> TracingServiceMock
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        public WFActivityUnitTest()
            :base()
        {          
            Init();
        }

        #endregion

        #region Setup Stubs

        protected void Init()
        {
            InitWorkflowContextMock(WorkflowContextMock);

            OrganizationServiceFactoryMock.Setup(factory => factory.CreateOrganizationService(It.IsAny<Guid?>())).Returns(OrganizationService);
        }

        private void InitOrganizationServiceMock(Mock<IOrganizationService> mock)
        {
            mock.Setup(service => service.Associate(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<Relationship>(), It.IsAny<EntityReferenceCollection>()));
            mock.Setup(service => service.Disassociate(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<Relationship>(), It.IsAny<EntityReferenceCollection>()));
            mock.Setup(service => service.Create(It.IsAny<Entity>())).Returns(() => Guid.NewGuid());
            mock.Setup(service => service.Update(It.IsAny<Entity>()));
            mock.Setup(service => service.Delete(It.IsAny<string>(), It.IsAny<Guid>()));
        }

        private void InitWorkflowContextMock(Mock<IWorkflowContext> mock)
        {
            mock.Setup(context => context.BusinessUnitId).Returns(Guid.NewGuid());
            mock.Setup(context => context.CorrelationId).Returns(Guid.NewGuid());
            mock.Setup(context => context.Depth).Returns(0);
            mock.Setup(context => context.InitiatingUserId).Returns(Guid.NewGuid());
            mock.Setup(context => context.InputParameters).Returns(new ParameterCollection());
            mock.Setup(context => context.IsExecutingOffline).Returns(false);
            mock.Setup(context => context.IsInTransaction).Returns(false);
            mock.Setup(context => context.IsOfflinePlayback).Returns(false);
            mock.Setup(context => context.MessageName).Returns(string.Empty);
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
            mock.Setup(context => context.StageName).Returns(string.Empty);
            mock.Setup(context => context.WorkflowCategory).Returns((int)WorkflowCategory.Workflow);
        }

        protected override IWorkflowContext CreateWorkflowContext()
        {
            if (this.WorkflowContextMock == null)
                this.WorkflowContextMock = new Mock<IWorkflowContext>();
            return this.WorkflowContextMock.Object;
        }

        protected override ITracingService CreateTracingService()
        {
            if (this.TracingServiceMock == null)
                this.TracingServiceMock = new Mock<ITracingService>();
            return this.TracingServiceMock.Object;
        }

        protected override IOrganizationServiceFactory CreateOrganizationServiceFactory()
        {
            if (this.OrganizationServiceFactoryMock == null)
                this.OrganizationServiceFactoryMock = new Mock<IOrganizationServiceFactory>();
            return this.OrganizationServiceFactoryMock.Object;
        }

        #endregion

    }
}
