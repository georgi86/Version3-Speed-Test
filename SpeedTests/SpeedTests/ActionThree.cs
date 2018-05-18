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
using UtilityFunctions;

namespace SpeedTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ActionThree recording.
    /// </summary>
    [TestModule("62cb300e-01af-40a5-8688-a9275b16cd9d", ModuleType.Recording, 1)]
    public partial class ActionThree : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SpeedTestsRepository repository.
        /// </summary>
        public static SpeedTestsRepository repo = SpeedTestsRepository.Instance;

        static ActionThree instance = new ActionThree();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActionThree()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActionThree Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Routines\\SpeedThree.mxy'.", new RecordItemIndex(6));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Routines\\SpeedThree.mxy");
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
            Thread.Sleep(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonOK' at Center.", repo.SnapXUntitled.ButtonOKInfo, new RecordItemIndex(12));
            repo.SnapXUntitled.ButtonOK.Click();
            Thread.Sleep(200);

            repo.SnapXUntitled.ReMeasure.Focus();   // this code is added to get all ReMeasure options to become active (find Re-Measure text , the button should be Enabled ) befor opening the ElapsedTimeOne.PRT file
            Thread.Sleep(1000);

            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeThree.PRT' with arguments '' in normal mode.", new RecordItemIndex(14));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeThree.PRT", "", "D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports", false);
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'ElapsedTimeThreePRTNotepad'.", repo.ElapsedTimeThreePRTNotepad.SelfInfo, new RecordItemIndex(15));
            repo.ElapsedTimeThreePRTNotepad.Self.Maximize();
            Thread.Sleep(100);

            int iHardcodedThree = 75;
            string ResultRoutineThree = ((SpeedTests.SpeedTestsRepositoryFolders.ElapsedTimeThreePRTNotepadAppFolder)repo.ElapsedTimeThreePRTNotepad.Text15Info.ParentFolder).Text15.TextValue;
            UtilityRun.RunEx(iHardcodedThree, ResultRoutineThree);
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ElapsedTimeThreePRTNotepad.Text15'.", repo.ElapsedTimeThreePRTNotepad.Text15Info, new RecordItemIndex(17));
            Host.Current.CloseApplication(repo.ElapsedTimeThreePRTNotepad.Text15, new Duration(0));
            Thread.Sleep(100);

            Thread.Sleep(5000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ReMeasure' at Center.", repo.SnapXUntitled.ReMeasureInfo, new RecordItemIndex(19));
            repo.SnapXUntitled.ReMeasure.Click();
            Thread.Sleep(200);

            repo.SnapXUntitled.Finish.Focus();
            Thread.Sleep(1000);


            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeThree.PRT' with arguments '' in normal mode.", new RecordItemIndex(21));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeThree.PRT", "", "D:\\Joro\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports", false);
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'ElapsedTimeThreePRTNotepad'.", repo.ElapsedTimeThreePRTNotepad.SelfInfo, new RecordItemIndex(22));
            repo.ElapsedTimeThreePRTNotepad.Self.Maximize();
            Thread.Sleep(100);

            iHardcodedThree = 75;
            string ResultRemeasureThree = ((SpeedTests.SpeedTestsRepositoryFolders.ElapsedTimeThreePRTNotepadAppFolder)repo.ElapsedTimeThreePRTNotepad.Text15Info.ParentFolder).Text15.TextValue;
            UtilityRun.RunEx(iHardcodedThree, ResultRemeasureThree);
            Thread.Sleep(100);

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ElapsedTimeThreePRTNotepad.Text15'.", repo.ElapsedTimeThreePRTNotepad.Text15Info, new RecordItemIndex(24));
            Host.Current.CloseApplication(repo.ElapsedTimeThreePRTNotepad.Text15, new Duration(0));
            Thread.Sleep(100);

            Thread.Sleep(5000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(26));
            repo.SnapXUntitled.Finish.Click();
            Thread.Sleep(200);

            Thread.Sleep(7000);

        }

        #region Image Feature Data
        #endregion
    }
#pragma warning restore 0436
}
