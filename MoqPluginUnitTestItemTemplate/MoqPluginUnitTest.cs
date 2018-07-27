using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Moq;
using Xrm.Framework.Test.Unit.Moq;


namespace $rootnamespace$
{
	[TestClass]
    public class $safeitemrootname$ : PluginUnitTest
	{
        #region Instance Variables

        //TODO: Declare your variables for setup and verification

        #endregion

        #region Setup

        protected override IPlugin SetupPlugin()
        {
            //TODO: Setup your trigger
            base.SetPluginEvent("", "Create",
               Xrm.Framework.Test.Unit.SdkMessageProcessingStepImage.PreOperation);

            //TODO: Setup your Stubs & Shim

            //TODO: Create your Plugin
            IPlugin plugin = null;

            return plugin;
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
