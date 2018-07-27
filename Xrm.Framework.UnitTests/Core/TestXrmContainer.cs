using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xrm.Framework.Core;

namespace Xrm.Framework.UnitTests.Test
{
    [TestClass]
    public class TestXrmContainer
    {
        [TestMethod]
        public void TestChildDependencies()
        {
            IDependencyA dependency = new DependencyA();
            IXrmContainer child = XrmContainer.Instance.CreateChild();
            child.Register<IDependencyA>(dependency);
            IModuleA module = child.Resolve<IModuleA>();

            Assert.AreSame(dependency, module.Dependency);

            IModuleA moduleParent = XrmContainer.Instance.Resolve<IModuleA>();

            Assert.AreNotSame(dependency, moduleParent.Dependency);
        }
    }

    public interface IModuleA
    {
        IDependencyA Dependency { get; set; }
    }

    public interface IDependencyA
    {
    }

    public class DependencyA : IDependencyA
    {
    }

    public class ModuleA : IModuleA
    {
        public IDependencyA Dependency { get; set; }

        public ModuleA(IDependencyA dependency)
        {
            Dependency = dependency;
        }
    }
}
