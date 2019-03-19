// Project / File: Tests.Plugins.UnitTests / Defaults.cs
//         Author: Ahmed Elsawalhy (Yagasoft.com)
//        Created: 2015 / 04 / 05 (3:47 PM)
//       Modified: 2015 / 04 / 06 (1:08 PM)


using System.Configuration;


namespace Xrm.Framework.Test
{
	/// <summary>
	/// Default values used throughout this test project.<br />
	/// Version: 1.1.1
	/// </summary>
	public class Defaults
	{
		public static readonly string CONNECTION_STRING = ConfigurationManager.AppSettings["ConnectionString"];

		public static readonly bool DISABLE_STEPS = bool.Parse(ConfigurationManager.AppSettings["DisableSteps"]);

		public static readonly bool UNDO_TEST_ACTIONS = bool.Parse(ConfigurationManager.AppSettings["UndoTestActions"]);
	}
}
