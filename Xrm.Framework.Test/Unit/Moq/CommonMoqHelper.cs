using Microsoft.Xrm.Sdk;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.Framework.Test.Unit.Moq
{
    internal class CommonMoqHelper
    {
        internal static void InitOrganizationServiceMock(Mock<IOrganizationService> mock)
        {
            mock.Setup(service => service.Associate(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<Relationship>(), It.IsAny<EntityReferenceCollection>()));
            mock.Setup(service => service.Disassociate(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<Relationship>(), It.IsAny<EntityReferenceCollection>()));
            mock.Setup(service => service.Create(It.IsAny<Entity>())).Returns(() => Guid.NewGuid());
            mock.Setup(service => service.Update(It.IsAny<Entity>()));
            mock.Setup(service => service.Delete(It.IsAny<string>(), It.IsAny<Guid>()));
        }
    }
}
