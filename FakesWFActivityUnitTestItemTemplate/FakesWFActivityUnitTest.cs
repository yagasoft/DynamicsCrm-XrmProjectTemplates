using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using System.Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Workflow;
using Xrm.Framework.Test.Unit.Fakes;


namespace $rootnamespace$
{
	[TestClass]
    public class $safeitemrootname$ : WFActivityUnitTest
	{
        #region Instance Variables

        //TODO: Declare your variables for setup and verification

        #endregion

        #region Setup

        protected override Activity SetupActivity()
        {

            //TODO: Setup your Stubs & Shim

            //TODO: Create your Activity
            Activity activity = null;

            return activity;
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
