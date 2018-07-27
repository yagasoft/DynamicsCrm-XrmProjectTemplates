using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Messages;
using Xrm.Framework.Test.Integration;


namespace $rootnamespace$
{
	[TestClass]
    public class $safeitemrootname$ : PluginIntegrationTest
	{
        #region Instance Variables

        //TODO: Declare your variables for setup and verification

        #endregion

        #region Setup

        protected override OrganizationRequest SetupTriggerRequest()
        {
            //TODO: Create your Request
            OrganizationRequest request = null;
            return request;
        }

        #endregion

        #region Test

        [TestMethod]
        public void Run$safeitemrootname$()
        {
            base.Test();
        }

        #endregion

        #region Verify

        protected override void Verify()
        {
            //Assert.IsNull(Error);

            //TODO: Add Additional Verification
        }

        #endregion
	}
}
