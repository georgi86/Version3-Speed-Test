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
    ///The ActionOne recording.
    /// </summary>
    [TestModule("9eb9cf0b-ff1c-44d0-ab16-95567d57f95d", ModuleType.Recording, 1)]
    public partial class ActionOne : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SpeedTestsRepository repository.
        /// </summary>
        public static SpeedTestsRepository repo = SpeedTestsRepository.Instance;

        static ActionOne instance = new ActionOne();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActionOne()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActionOne Instance
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

            File.Delete("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeOne.PRT");
            File.Delete("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeTwo.PRT");
            File.Delete("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeThree.PRT");
            File.Delete("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeFour.PRT");
            File.Delete("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeFive.PRT");

            string strBigModeText = "Measure";

            bool bBigMode = true;

            try
            {
                Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TextMeasure' at Center.", repo.SnapXUntitled.TextMeasureInfo, new RecordItemIndex(0));
                repo.SnapXUntitled.TextMeasure.MoveTo();
                Delay.Milliseconds(200);

                bBigMode = repo.SnapXUntitled.TextMeasure.TextValue.CompareTo(strBigModeText) == 0 && repo.SnapXUntitled.TextMeasure.Visible;

            }
            catch (Exception ex)
            {
                
            }

            if (!bBigMode)

                repo.SnapXUntitled.SwitchToSensor.Click();
                Delay.Milliseconds(200);
            

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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Routines\\SpeedOne.mxy'.", new RecordItemIndex(6));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Routines\\SpeedOne.mxy");
            Thread.Sleep(200);

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
            Thread.Sleep(100);


            //USE THIS CODE IN CASE IN WHICH THE ENTER BUTTON DON'T EXECUTE THE MEASUREMENT//
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonOK' at Center.", repo.SnapXUntitled.ButtonOKInfo, new RecordItemIndex(12));
            //repo.SnapXUntitled.ButtonOK.Click();
            //Thread.Sleep(200);            

            do
            {
                Thread.Sleep(100);
            }

            while
            (!repo.SnapXUntitled.ReMeasure.Enabled);


                        
            string ActualResultRoutineOne = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeOne.PRT";
            int HardcodedResultRoutineOne = 16;
            UtilityRun.RunEx(ActualResultRoutineOne, HardcodedResultRoutineOne);
            Delay.Milliseconds(200);



            Thread.Sleep(3000);

            {
                Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ReMeasure' at Center.", repo.SnapXUntitled.ReMeasureInfo, new RecordItemIndex(19));
                repo.SnapXUntitled.ReMeasure.Click();
                Thread.Sleep(200);
            }

            do
            {
                Thread.Sleep(100);
            }
            while (!repo.SnapXUntitled.Finish.Enabled);

                                    
            ActualResultRoutineOne = "C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\AutomationSpeedTest\\Reports\\ElapsedTimeOne.PRT";
            HardcodedResultRoutineOne = 16;
            UtilityRun.RunEx(ActualResultRoutineOne, HardcodedResultRoutineOne);
            Thread.Sleep(100);

           
            Thread.Sleep(3000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(26));
            repo.SnapXUntitled.Finish.Click();

            Thread.Sleep(7000);

        }

        #region Image Feature Data
        #endregion
    }
#pragma warning restore 0436
}
