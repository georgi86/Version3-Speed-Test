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
using System.IO;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;
using UtilityFunctions;

namespace SpeedTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ActionFive recording.
    /// </summary>
    [TestModule("4e570092-f82b-4882-88ca-ecfee775d22d", ModuleType.Recording, 1)]
    public partial class ActionFive : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SpeedTestsRepository repository.
        /// </summary>
        public static SpeedTestsRepository repo = SpeedTestsRepository.Instance;

        static ActionFive instance = new ActionFive();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActionFive()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActionFive Instance
        {
            get { return instance; }
        }

        #region Variables

        #endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();



            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at 663;11.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.TitleBar.Click("663;11");
            Thread.Sleep(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Thread.Sleep(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(2));
            Keyboard.Press("f");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(3));
            Keyboard.Press("o");
            Thread.Sleep(3000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Routines\\SpeedFive.mxy'.", new RecordItemIndex(6));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Routines\\SpeedFive.mxy");
            Thread.Sleep(100);

            Keyboard.Press("{Return}");
            Thread.Sleep(300);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at 668;9.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(8));
            repo.SnapXUntitled.TitleBar.Click("668;9");
            Thread.Sleep(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(9));
            Keyboard.Press("{LMenu}");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(10));
            Keyboard.Press("f");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(11));
            Keyboard.Press("r");
            Thread.Sleep(2000);

            Keyboard.Press("{Return}");
            Thread.Sleep(200);

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonOK' at Center.", repo.SnapXUntitled.ButtonOKInfo, new RecordItemIndex(12));
            //repo.SnapXUntitled.ButtonOK.Click();
            //Thread.Sleep(200);

            do
            {
                Thread.Sleep(100);
            }

            while
            (!repo.SnapXUntitled.ReMeasure.Enabled);

            string ActualResultRoutineFive = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeFive.PRT";
            int HardcodedResultRoutineFive = 82;
            UtilityRun.RunEx(ActualResultRoutineFive, HardcodedResultRoutineFive);
            Thread.Sleep(100);

            Thread.Sleep(3000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ReMeasure' at Center.", repo.SnapXUntitled.ReMeasureInfo, new RecordItemIndex(19));
            repo.SnapXUntitled.ReMeasure.Click();
            Thread.Sleep(100);

            do
            {
                Thread.Sleep(100);
            }

            while
            (!repo.SnapXUntitled.ReMeasure.Enabled);

            ActualResultRoutineFive = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeFive.PRT";
            HardcodedResultRoutineFive = 82;
            UtilityRun.RunEx(ActualResultRoutineFive, HardcodedResultRoutineFive);
            Thread.Sleep(100);

            Thread.Sleep(3000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(26));
            repo.SnapXUntitled.Finish.Click();
            Thread.Sleep(200);

            Thread.Sleep(5000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(9));
            Keyboard.Press("{LMenu}");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(10));
            Keyboard.Press("f");
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'n'.", new RecordItemIndex(11));
            Keyboard.Press("n");
            Thread.Sleep(100);

        }

        #region Image Feature Data
        #endregion
    }
#pragma warning restore 0436
}
