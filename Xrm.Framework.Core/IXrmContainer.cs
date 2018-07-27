using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xrm.Framework.Core
{
    public interface IXrmContainer
    {
        void Register<INTERFACE, IMPLEMENTATION>()
            where IMPLEMENTATION : INTERFACE, new();

        void Register<INTERFACE>(INTERFACE implementation);

        INTERFACE Resolve<INTERFACE>();

        IXrmContainer CreateChild();
    }
}
