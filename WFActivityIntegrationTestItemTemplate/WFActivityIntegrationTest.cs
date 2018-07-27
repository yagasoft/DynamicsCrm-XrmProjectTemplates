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
    public class $safeitemrootname$ : WFActivityIntegrationTest
	{
        #region Instance Variables

        //TODO: Declare your variables for setup and verification

        #endregion

        #region Setup


        protected override Guid SetupPrimaryEntity()
        {
            //TODO: return Guid of the associated trigger entity
            throw new NotImplementedException();
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

        protected override void VerifyStatus()
        {
            Assert.AreEqual(Status, AsyncStatus.Pass);

            //TODO: Add Additional Verification
        }

        #endregion
	}
}
