using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.Framework.Test
{
    /// <summary>
    /// Base Class for Dynamics CRM Tests
    /// </summary>
    public abstract class XrmTest
    {
        #region Properties

        protected Exception Error
        {
            get;
            set;
        }

        protected virtual bool ThrowError
        {
            get
            {
                return false;
            }
        }

        #endregion

        #region Test

        protected virtual void Test()
        {
            Setup();

            try
            {
                Do();
            }
            catch (Exception ex)
            {
                Error = ex;

                if (ThrowError)
                    throw ex;
            }

            Verify();

            CleanUp();
        }

        #endregion

        #region Clean Up

        protected virtual void CleanUp()
        {
        }

        #endregion

        #region Abstract Methods

        protected abstract void Setup();
        protected abstract void Do();
        protected abstract void Verify();

        #endregion
    }
}
