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
    ///The Headless_Logout recording.
    /// </summary>
    [TestModule("fa19b143-843f-4854-9a4e-060fcaa61657", ModuleType.Recording, 1)]
    public partial class Headless_Logout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CS_View_1_3Repository repository.
        /// </summary>
        public static CS_View_1_3Repository repo = CS_View_1_3Repository.Instance;

        static Headless_Logout instance = new Headless_Logout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Headless_Logout()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Headless_Logout Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'VIEWForClusterStor1.Automation'.", repo.VIEWForClusterStor1.AutomationInfo, new RecordItemIndex(0));
            repo.VIEWForClusterStor1.Automation.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'VIEWForClusterStor1.Logout'.", repo.VIEWForClusterStor1.LogoutInfo, new RecordItemIndex(1));
            repo.VIEWForClusterStor1.Logout.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}