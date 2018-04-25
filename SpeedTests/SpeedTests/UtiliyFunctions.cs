using System;
using System.Text.RegularExpressions;

namespace UtilityFunctions
{
    public class Mathematics
    {
        public static bool IsZero(double dExpression, double EPSILONE)
        {
            return System.Math.Abs(dExpression) < EPSILONE;
        }

        public static bool IsEQ(double first, double second, double EPSILONE)
        {
            return IsZero(first - second, EPSILONE);
        }
    }

    public class ReportAction
    {

        public static void RunIncreasedResult(int ActualTime)
        {
            string ActualValue = "Actual value is: " + ActualTime;
            Ranorex.Report.Success("THE SPEED HAS INCREASED");
        }

        public static void RunPositiveResult(int ActualTime)
        {
            string ActualValue = "Actual Value is: " + ActualTime;
            Ranorex.Report.Success("Sucessfully Performed: ", ActualValue);
        }

        public static void RunNegativeResult(int nActualTime, int nHardcodedTime, int nErrorLine)
        {

            string errLine = "Error on line: " + (nErrorLine + 1);
            Ranorex.Report.Error("SLOW DOWN: ", errLine);

            string ActualValue = "Actual Value is: " + nActualTime;
            Ranorex.Report.Error("SLOW DOWN: ", ActualValue);

            string HardcodedValue = "Hardcoded value is: " + nHardcodedTime;
            Ranorex.Report.Error("SLOW DOWN: ", HardcodedValue);
        }
    }

    public class UtilityRun
    {
        public static void RunEx(int iHardcodedInParam, string ResultRoutineInParam)
        {
            string ResultRoutineOne = ResultRoutineInParam; // ((SpeedTests.SpeedTestsRepositoryFolders.ElapsedTimeOnePRTNotepadAppFolder)repo.ElapsedTimeOnePRTNotepad.Text15Info.ParentFolder).Text15.TextValue;

            string[] ReadResultRoutineOne = Regex.Split(ResultRoutineOne, "[\r\n]+");

            int iNumResultRows = ReadResultRoutineOne.Length;

            string HardcodedResultOne = "Machine Serial Number:  SFD2001052                                                       Page:    1\r\n====================================================================================================\r\nRoutine Name                                                    Run #            Date & Time        \r\n====================================================================================================\r\nSpeedOne.mxy                                             1     Wednesday, November 08, 2017 17:01:10\r\n====================================================================================================\r\n\r\n====================================================================================================\r\nFeature           Unit    Nominal       Actual          Tolerances           Deviation     Exceeded \r\n====================================================================================================\r\nStep 3   \r\nDiameter          mm    +6.3129       +6.3116       +0.0000     +0.0000    -0.0013                  \r\n   \r\n====================================================================================================\r\n\r\n============================ END OF INSPECTION - Elapsed Time  00:00:23 ============================\r\n";

            string[] HardcodedReadResultOne = Regex.Split(HardcodedResultOne, "[\r\n]+");

            int iNumhardcodedResultRow = HardcodedReadResultOne.Length;

            int HardcodedTime = iHardcodedInParam; // 25; // this is the expected time. With this time we compare the actual time


            for (int i = iNumResultRows - 1; i >= 0; i--) //this for method will work in revers order 

            {
                bool bExpectedTextRow = ReadResultRoutineOne[i].Contains("END OF INSPECTION");
                if (bExpectedTextRow)
                {
                    string sFinalInspection = ReadResultRoutineOne[i];

                    string toSearch = ":";  //This will give the first postion of the : symbol. We assume, that there will be two such symbols in the whole string //- one between the hour and the minutes, and one between the minutes and the seconds

                    int idxHourMinute = sFinalInspection.IndexOf(toSearch);

                    string hours = new string(sFinalInspection.ToCharArray(idxHourMinute - 2, 2));    //Offset backwards with two sympols, because we found the position of : character. The second digit (2) means how many digits to take

                    string minutes = new string(sFinalInspection.ToCharArray(idxHourMinute + 1, 2));

                    string seconds = new string(sFinalInspection.ToCharArray(idxHourMinute + 4, 2));        //We offset with 4, because of the second : character

                    int hh = 0;
                    int mm = 0;
                    int ss = 0;
                    int.TryParse(hours, out hh);
                    int.TryParse(minutes, out mm);
                    int.TryParse(seconds, out ss);
                    int ActualTime = (3600 * hh) + (60 * mm) + ss;

                    if (Mathematics.IsEQ(ActualTime, HardcodedTime, 4))
                    {
                        ReportAction.RunPositiveResult(ActualTime);
                    }

                    else
                    {
                        if (ActualTime < HardcodedTime)
                        {
                            ReportAction.RunIncreasedResult(ActualTime); 
                        }

                        else

                            ReportAction.RunNegativeResult(ActualTime, HardcodedTime, i);
                    }

                    break;
                }
            } // for (int i = 0; i < iNumResultRows; i++)
        } // public static void RunEx(int iHardcodedInParam, string ResultRoutineOneInParam)
    } // public class UtilityRun

} // namespace UtilityFunctions
