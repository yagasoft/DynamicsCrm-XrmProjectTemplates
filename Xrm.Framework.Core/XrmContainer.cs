using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Xrm.Framework.Core
{
    public class XrmContainer : IXrmContainer
    {
        #region Instance Variables

        private delegate object Create();
        private Dictionary<Type, Create> mappings = new Dictionary<Type, Create>();
        private static IXrmContainer _container;

        #endregion

        #region Properties

        public static IXrmContainer Instance
        {
            get
            {
                if (_container == null)
                {
                    _container = new XrmContainer();
                }
                return _container;
            }
        }

        #endregion

        #region Constructors

        private XrmContainer()
        {
        }

        #endregion

        #region IXrmContainer

        public void Register<INTERFACE, IMPLEMENTATION>() where IMPLEMENTATION : INTERFACE, new()
        {
            if (mappings.ContainsKey(typeof(INTERFACE)))
            {
                mappings.Remove(typeof(INTERFACE));
            }
            mappings.Add(typeof(INTERFACE), () => new IMPLEMENTATION());

        }

        public void Register<INTERFACE>(INTERFACE implementation)
        {
            if (mappings.ContainsKey(typeof(INTERFACE)))
            {
                mappings.Remove(typeof(INTERFACE));
            }
            mappings.Add(typeof(INTERFACE), () => implementation);
        }

        public INTERFACE Resolve<INTERFACE>()
        {
            return (INTERFACE)this.Resolve(typeof(INTERFACE));
        }

        private object Resolve(Type type)
        {
            if (!mappings.ContainsKey(type))
            {
                string implementationTypeName = type.Namespace + "." + type.Name.Substring(1);
                Type implementationType = type.Assembly.GetType(implementationTypeName);
                ConstructorInfo[] constructors = implementationType.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
                if (constructors.Length > 1)
                {
                    throw new Exception("More than one public constructor found");
                }
                else if (constructors.Length == 0)
                {
                    throw new Exception("No public constructors found");
                }

                ConstructorInfo constructor = constructors[0];
                ParameterInfo[] parameters = constructor.GetParameters();

                object[] parameterValues = new object[parameters.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    ParameterInfo parameter = parameters[i];

                    object parameterValue = this.Resolve(parameter.ParameterType);
                    parameterValues[i] = parameterValue;
                }

                return constructor.Invoke(parameterValues);
            }
            else
            {
                return mappings[type].Invoke();
            }
        }

        public IXrmContainer CreateChild()
        {
            XrmContainer child = new XrmContainer();
            foreach (Type t in this.mappings.Keys)
            {
                child.mappings.Add(t, this.mappings[t]);
            }
            return child;
        }

        #endregion
    }
}
