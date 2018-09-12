using System;
using System.Text.RegularExpressions;
using System.IO;

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
        public static void RunEx(string ResultRoutineInParam, int iHardcodedInParam)
        {
            string[] readActualLines = File.ReadAllLines(ResultRoutineInParam);            
            int iNumActualRows = readActualLines.Length;
            
            int HardcodedTime = iHardcodedInParam; // 25; // this is the expected time. With this time we compare the actual time

            for (int i = iNumActualRows - 1; i >= 0; i--) //this for method will work in revers order 

            {
                bool bExpectedTextRow = readActualLines[i].Contains("END OF INSPECTION");
                if (bExpectedTextRow)
                {
                    string sFinalInspection = readActualLines[i];

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
