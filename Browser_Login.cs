﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace CS_View_1_3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Browser_Login recording.
    /// </summary>
    [TestModule("a76da69b-9743-467f-8967-c9431465a6ed", ModuleType.Recording, 1)]
    public partial class Browser_Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CS_View_1_3Repository repository.
        /// </summary>
        public static CS_View_1_3Repository repo = CS_View_1_3Repository.Instance;

        static Browser_Login instance = new Browser_Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Browser_Login()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Browser_Login Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VIEWForClusterStor.LoginShow.Text' at 5;29.", repo.VIEWForClusterStor.LoginShow.TextInfo, new RecordItemIndex(0));
            repo.VIEWForClusterStor.LoginShow.Text.Click("5;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'automation' with focus on 'VIEWForClusterStor.LoginShow.Text'.", repo.VIEWForClusterStor.LoginShow.TextInfo, new RecordItemIndex(1));
            repo.VIEWForClusterStor.LoginShow.Text.PressKeys("automation");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VIEWForClusterStor.LoginShow.Password' at 13;29.", repo.VIEWForClusterStor.LoginShow.PasswordInfo, new RecordItemIndex(2));
            repo.VIEWForClusterStor.LoginShow.Password.Click("13;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'automation' with focus on 'VIEWForClusterStor.LoginShow.Password'.", repo.VIEWForClusterStor.LoginShow.PasswordInfo, new RecordItemIndex(3));
            repo.VIEWForClusterStor.LoginShow.Password.PressKeys("automation");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VIEWForClusterStor.LoginShow.Login' at 48;12.", repo.VIEWForClusterStor.LoginShow.LoginInfo, new RecordItemIndex(4));
            repo.VIEWForClusterStor.LoginShow.Login.Click("48;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'VIEWForClusterStor1.Logo'.", repo.VIEWForClusterStor1.LogoInfo, new RecordItemIndex(5));
            Validate.Exists(repo.VIEWForClusterStor1.LogoInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}