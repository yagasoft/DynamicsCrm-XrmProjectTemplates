using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xrm.Sdk;

namespace Xrm.Framework.Test.Unit
{
    /// <summary>
    /// Base Class for all Dynamics CRM Unit Tests
    /// </summary>
    public abstract class XrmUnitTest : XrmTest
    {
        #region Constructors

        protected XrmUnitTest()
            :base()
        {
        }

        #endregion
    }
}
