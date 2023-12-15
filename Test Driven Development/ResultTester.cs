using System;
using System.Collections;
using System.Linq;
using System.Text;
using CompetitiveProgramming.Helpers.Converters;
using CompetitiveProgramming.Helpers.Outputs;

namespace CompetitiveProgramming.TestDrivenDevelopment
{
    public class ResultTester
    {
        // Totals
        private static int _counterTotalSolutions = 0;
        private static int _counterTotalTestCaseDone = 0;

        // Solutions
        private static int _counterValidatedSolutions = 0;
        private static int _counterNotValidatedSolutions = 0;

        // Tests
        private static int _counterTestCaseValidated = 0;
        private static int _counterTestCaseNotValidated = 0;

        // Problems Source
        private static int _counterLeetCodeProblem = 0;
        private static int _counterCodeForcesProblem = 0;
        private static int _counterSphreOnlineJudgeProblem = 0;
        private static int _counterCodeChefProblem = 0;
        private static int _counterCoderByteProblem = 0;
        private static int _counterCodeWarsProblem = 0;
        private static int _counterGeeksForGeeksProblem = 0;
        private static int _counterHackerRankProblem = 0;
        private static int _counterKattisProblem = 0;
        private static int _counterAtCoderProblem = 0;
        private static int _counterCodinGameProblem = 0;
        private static int _counterCSAcademyProblem = 0;
        private static int _counterProjectEulerProblem = 0;
        private static int _counterOtherSourceProblem = 0;
        
        // Lock
        private static object _lock = new object();

        // Check each cases
        public static bool CheckResult<T>(T result, T expected)
        {
            if (result != null && expected != null)
            {
                // if Array / Jagged Array
                if (result.GetType().IsArray)
                {
                    // Get the element type of the array
                    Type arrayType = result.GetType().GetElementType()!;
                    
                    // Check if it's a jagged array
                    if (arrayType.IsArray) 
                    {
                        // Compare the Jagged Arrays of the same type
                        // Convert jagged arrays to strings and compare
                        string resultString = JaggedArrayToStringConverter.JaggedArrayToString(result as Array);
                        string expectedString = JaggedArrayToStringConverter.JaggedArrayToString(expected as Array);
                        PrintHelper.PrintTestResult(resultString, expectedString);
                        if (resultString.Equals(expectedString))
                        {
                            CheckResultRight();
                            return true;
                        }
                        else
                        {
                            CheckResultWrong();
                            return false;
                        }
                    }
                    else
                    {
                        string resultString = ArrayToStringConverter.ArrayToString(result as Array);
                        string expectedString = ArrayToStringConverter.ArrayToString(expected as Array);
                        PrintHelper.PrintTestResult(resultString, expectedString);

                        // Compare the Single-Dimensional Arrays of the same type => .SequenceEqual();
                        if (result is Array resultArray && expected is Array expectedArray)
                        {
                            return CheckArrayResult<Array>(resultArray, expectedArray);
                        }
                    }
                }

                // If Collection or IList<IList<...>> or IEnum
                else if (result is IEnumerable<object> resultCollection && expected is IEnumerable<object> expectedCollection)
                {
                    object objResult = (object)result;
                    object objExpected = (object)expected;
                    string resultString = ConvertResultToString(objResult);
                    string expectedString = ConvertResultToString(objExpected);
                    PrintHelper.PrintTestResult(resultString, expectedString);

                    if(string.Equals(resultString, expectedString))
                    {
                        CheckResultRight();
                        return true;
                    }
                }

                // If char int string long uint Enum => .Equals()
                else if (result is bool || result is char || result is int || result is string || result is long || result is uint || result is Enum)
                {
                    string resultString = result.ToString()!;
                    string expectedString = expected.ToString()!;
                    PrintHelper.PrintTestResult(resultString, expectedString);

                    if (result.Equals(expected))
                    {
                        CheckResultRight();
                        return true;
                    }
                }

                // If float double
                else if (result is float || result is double)
                {
                    string resultString = result.ToString()!;
                    string expectedString = expected.ToString()!;
                    PrintHelper.PrintTestResult(resultString, expectedString);
                    if (result.Equals(expected))
                    {
                        CheckResultRight();
                        return true;
                    }
                    /*
                    double tolerance = 0.0001;
                    double diff = Math.Abs(Convert.ToDouble(result) - Convert.ToDouble(expected));
                    if (diff > tolerance)
                    {
                        CheckResultRight();
                        return true;
                    }
                    */
                }

                // If IList
                else if (result is IList)
                {
                    string resultString = ConvertResultToString(result);
                    string expectedString = ConvertResultToString(expected);
                    PrintHelper.PrintTestResult(resultString, expectedString);

                    if (resultString.Equals(expectedString))
                    {
                        CheckResultRight();
                        return true;
                    }
                }
            }

            // If null or not equal
            lock (_lock)
            {
                CheckResultWrong();
                return false;
            }
        }

        public static bool CheckArrayResult<T>(T result, T expected)
        {
            if (result is Array resultArray && expected is Array expectedArray)
            {
                if (resultArray.Cast<object>().SequenceEqual(expectedArray.Cast<object>()))
                {
                    CheckResultRight();
                    return true;
                }
                else
                {
                    CheckResultWrong();
                    return false;
                }
            }

            CheckResultWrong();
            return false;
        }

        private static string ConvertResultToString(object toConvert)
        {
            if (toConvert is IList<IList<int>> nestedList)
            {
                //List<string> stringList = nestedList.Select(innerList => string.Join(", ", innerList)).ToList();
                var stringList = nestedList.Select(innerList => string.Join(", ", innerList)).ToList();
                return string.Join("; ", stringList);
            }

            if (toConvert is IList<IList<string>> nestedStringList)
            {
                //List<string> stringList = nestedList.Select(innerList => string.Join(", ", innerList)).ToList();
                var stringList = nestedStringList.Select(innerList => string.Join(", ", innerList)).ToList();
                return string.Join("; ", stringList);
            }
            // Needs to Handle other IList<IList<...>> types

            if (toConvert is IEnumerable<object> objectEnumerable)
            {
                List<string> stringList = objectEnumerable.Select(obj => obj.ToString()).ToList()!;
                return string.Join(", ", stringList);
            }

            if (toConvert is IList<int> list)
            {
                return string.Join(", ", list.Cast<object>().Select(item => item.ToString()));            
            }

            if (toConvert is List<int> genericList)
            {
                return string.Join(", ", genericList.Select(item => item.ToString()));
            }

            return string.Empty;
        }

        private static void CheckResultRight()
        {
            ValidateTest();
            TestDone();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Validated");
            Console.ResetColor();
        }

        private static void CheckResultWrong()
        {
            InvalidateTest();
            TestDone();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalidated");
            Console.ResetColor();
        }

        // To call in each Solution
        public static void CheckSolution(string source, params bool[] values)
        {
            TestSolution();
            // If at least one is false then Solution is Invalidate
            bool result = values.Any(b => !b);
            if(!result)
            {
                ValidateSolution();
            }
            else
            {
                InvalidateSolution();
            }
            SourceManager(source);
        }

        public static void SpecialTestCase(string source)
        {
            Console.WriteLine("See Solution Directly");
            TestDone();
            ValidateTest();
            ValidateSolution();
            TestSolution();
            SourceManager(source);
        }

        private static void SourceManager(string source)
        {
            switch(source)
            {
                case "LC":
                    _counterLeetCodeProblem++;
                    break;
                case "CC":
                    _counterCodeChefProblem++;
                    break;
                case "CF":
                    _counterCodeForcesProblem++;
                    break;
                case "SPOJ":
                    _counterSphreOnlineJudgeProblem++;
                    break;
                case "CB":
                    _counterCoderByteProblem++;
                    break;
                case "HR":
                    _counterHackerRankProblem++;
                    break;
                case "KAT":
                    _counterKattisProblem++;
                    break;
                case "GFG":
                    _counterGeeksForGeeksProblem++;
                    break;
                case "CW":
                    _counterCodeWarsProblem++;
                    break;
                case "AC":
                    _counterAtCoderProblem++;
                    break;
                case "CG":
                    _counterCodinGameProblem++;
                    break;
                case "CSA":
                    _counterCSAcademyProblem++;
                    break;
                case "PE":
                    _counterProjectEulerProblem++;
                    break;
                default:
                    _counterOtherSourceProblem++;
                    break;
            }
        }

        private static void TestSolution()
        {
            lock (_lock)
            {
                _counterTotalSolutions++;
            }
        }

        private static void ValidateSolution()
        {
            lock (_lock)
            {
                _counterValidatedSolutions++;
            }
        }

        private static void InvalidateSolution()
        {
            lock (_lock)
            {
                _counterNotValidatedSolutions++;
            }
        }

        private static void TestDone()
        {
            lock (_lock)
            {
                _counterTotalTestCaseDone++;
            }
        }

        private static void ValidateTest()
        {
            lock (_lock)
            {
                _counterTestCaseValidated++;
            }
        }

        private static void InvalidateTest()
        {
            lock (_lock)
            {
                _counterTestCaseNotValidated++;
            }
        }

        // Get Percentages
        public static string GetTestPercentage()
        {
            if(_counterTotalTestCaseDone != 0)
            {
                double percentageTest = ((double)_counterTestCaseValidated / _counterTotalTestCaseDone) * 100;
                double roundedPercentage = Math.Round(percentageTest, 2);
                string numbers = " (Tests Validated : [" + _counterTestCaseValidated.ToString() + "]" + " | Tests Invalidated : [" + _counterTestCaseNotValidated.ToString() + "])";
                string result = "Percentage of Tests Done : [" + roundedPercentage.ToString("0.##") + "%]"+ numbers;
                return result;
            }
            else
            {
                string result = "Nothing Done Yet, No Case's Stats to Show.";
                return result;
            }
        }

        public static string GetSolutionPercentage()
        {
            if(_counterTotalSolutions != 0)
            {
                double percentageSolution = ((double)_counterValidatedSolutions / _counterTotalSolutions) * 100;
                double roundedPercentage = Math.Round(percentageSolution, 2);
                string numbers = " (Solutions Validated : [" + _counterValidatedSolutions.ToString() + "]" + " | Solutions Invalidated : [" + _counterNotValidatedSolutions.ToString() + "])";
                string result = "Percentage of Solutions Done : [" + roundedPercentage.ToString("0.##") + "%]" + numbers;
                return result;
            }
            else
            {
                string result = "Nothing Done Yet, No Solution's Stats to Show.";
                return result;
            }
        }

        // Get Counters
        public static string GetProblemsSourcesCounters()
        {
            string separator = " | ";
            StringBuilder counters = new();
            counters.Append("AtCoder Problems : [" + _counterAtCoderProblem.ToString() + "]" + separator);
            counters.Append("CodeChef Problems : [" + _counterCodeChefProblem.ToString() + "]" + separator);
            counters.Append("CodeForces Problems : [" + _counterCodeForcesProblem.ToString() + "]" + separator);
            counters.Append("CoderByte Problems : [" + _counterCoderByteProblem.ToString() + "]" + separator);
            counters.Append("CodeWars Problems : [" + _counterCodeWarsProblem.ToString() + "]" + "\n");

            counters.Append("CodinGame Problems : [" + _counterCodinGameProblem.ToString() + "]" + separator);
            counters.Append("CSAcademy Problems : [" + _counterCSAcademyProblem.ToString() + "]" + separator);
            counters.Append("GeeksForGeeks Problems : [" + _counterGeeksForGeeksProblem.ToString() + "]" + separator);
            counters.Append("HackerRank Problems : [" + _counterHackerRankProblem.ToString() + "]" + separator);
            counters.Append("Kattis Problems : [" + _counterKattisProblem.ToString() + "]" + "\n");
            
            
            counters.Append("LeetCode Problems : [" + _counterLeetCodeProblem.ToString() + "]" + separator);
            counters.Append("ProjectEuler Problems : [" + _counterProjectEulerProblem.ToString() + "]" + separator);
            counters.Append("SPOJ Problems : [" + _counterSphreOnlineJudgeProblem.ToString() + "]" + separator);
            if (_counterOtherSourceProblem != 0)
            {
                counters.Append(separator + "Other Sources Problems : [" + _counterOtherSourceProblem.ToString() + "]");
            }
            return counters.ToString();
        }

        public static string GetCounterTotalSolutions()
        {
            string result = "Number of Solutions Done : [" + _counterTotalSolutions.ToString() + "]";
            return result;
        }

        public static string GetCounterTotalTestCaseDone()
        {
            string result = "Number of Case Done : [" + _counterTotalTestCaseDone.ToString() + "]";
            return result;
        }

        public static void GetAllStats()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stats");

            PrintHelper.HightLight(GetProblemsSourcesCounters(), ConsoleColor.Cyan);

            PrintHelper.HightLight(GetTestPercentage(), ConsoleColor.Yellow);

            PrintHelper.HightLight(GetCounterTotalTestCaseDone(), ConsoleColor.Yellow);
            
            PrintHelper.HightLight(GetSolutionPercentage(), ConsoleColor.Green);

            PrintHelper.HightLight(GetCounterTotalSolutions(), ConsoleColor.Green);
        }
    }
}