using System;
using System.Collections;
using System.Linq;
using System.Text;

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
        private static int _counterCodeChefProblem = 0;
        private static int _counterCoderByteProblem = 0;
        private static int _counterCodeWarsProblem = 0;
        private static int _counterGeeksForGeeksProblem = 0;
        private static int _counterHackerRankProblem = 0;
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
                        string resultString = Program.JaggedArrayToString(result as Array);
                        string expectedString = Program.JaggedArrayToString(expected as Array);
                        Program.PrintTestResult(resultString, expectedString);
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
                        string resultString = Program.ArrayToString(result as Array);
                        string expectedString = Program.ArrayToString(expected as Array);
                        Program.PrintTestResult(resultString, expectedString);

                        // Compare the Single-Dimensional Arrays of the same type => .SequenceEqual();
                        if (result is Array resultArray && expected is Array expectedArray)
                        {
                            // If int[]
                            if (resultArray is int[] && expectedArray is int[])
                            {
                                if (resultArray.Cast<object>().SequenceEqual(expectedArray.Cast<object>()))
                                {
                                    CheckResultRight();
                                    return true;
                                }
                            }

                            // If bool[]
                            else if (resultArray is bool[] && expectedArray is bool[])
                            {
                                if (resultArray.Cast<object>().SequenceEqual(expectedArray.Cast<object>()))
                                {
                                    CheckResultRight();
                                    return true;
                                }
                            }

                            // If char[]
                            else if (resultArray is char[] && expectedArray is char[])
                            {
                                if (resultArray.Cast<object>().SequenceEqual(expectedArray.Cast<object>()))
                                {
                                    CheckResultRight();
                                    return true;
                                }
                            }

                            // If double[]
                            else if (resultArray is double[] && expectedArray is double[])
                            {
                                if (resultArray.Cast<object>().SequenceEqual(expectedArray.Cast<object>()))
                                {
                                    CheckResultRight();
                                    return true;
                                }
                            }

                            // If long[]
                            else if (resultArray is long[] && expectedArray is long[])
                            {
                                if (resultArray.Cast<object>().SequenceEqual(expectedArray.Cast<object>()))
                                {
                                    CheckResultRight();
                                    return true;
                                }
                            }

                            // Handle other array types here...

                            // If no matching array type found
                            CheckResultWrong();
                            return false;
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
                    Program.PrintTestResult(resultString, expectedString);

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
                    Program.PrintTestResult(resultString, expectedString);

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
                    Program.PrintTestResult(resultString, expectedString);
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
                    Program.PrintTestResult(resultString, expectedString);

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

        private static string ConvertResultToString(object toConvert)
        {
            if (toConvert is IList<IList<int>> nestedList)
            {
                //List<string> stringList = nestedList.Select(innerList => string.Join(", ", innerList)).ToList();
                var stringList = nestedList.Select(innerList => string.Join(", ", innerList)).ToList();
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
                case "CB":
                    _counterCoderByteProblem++;
                    break;
                case "HR":
                    _counterHackerRankProblem++;
                    break;
                case "GFG":
                    _counterGeeksForGeeksProblem++;
                    break;
                case "CW":
                    _counterCodeWarsProblem++;
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
            StringBuilder counters = new StringBuilder();
            counters.Append("CodeChef Problems : [" + _counterCodeChefProblem.ToString() + "]" + separator);
            counters.Append("CodeForces Problems : [" + _counterCodeForcesProblem.ToString() + "]" + separator);
            counters.Append("CoderByte Problems : [" + _counterCoderByteProblem.ToString() + "]" + separator);
            counters.Append("CodeWars Problems : [" + _counterCodeWarsProblem.ToString() + "]" + "\n");

            counters.Append("GeeksForGeeks Problems : [" + _counterGeeksForGeeksProblem.ToString() + "]" + separator);
            counters.Append("HackerRank Problems : [" + _counterHackerRankProblem.ToString() + "]" + separator);
            counters.Append("LeetCode Problems : [" + _counterLeetCodeProblem.ToString() + "]");
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
            Program.Space();
            Program.Title("Stats");

            Program.HightLight(GetProblemsSourcesCounters(), ConsoleColor.Cyan);

            Program.HightLight(GetTestPercentage(), ConsoleColor.Yellow);

            Program.HightLight(GetCounterTotalTestCaseDone(), ConsoleColor.Yellow);
            
            Program.HightLight(GetSolutionPercentage(), ConsoleColor.Green);

            Program.HightLight(GetCounterTotalSolutions(), ConsoleColor.Green);
        }
    }
}