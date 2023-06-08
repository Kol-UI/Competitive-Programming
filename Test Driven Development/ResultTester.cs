using System;
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
            if (result!.Equals(expected))
            {
                lock (_lock)
                {
                    ValidateTest();
                    TestDone();
                    return true;
                }
            }
            else
            {
                lock (_lock)
                {
                    InvalidateTest();
                    TestDone();
                    return false;
                }
            }
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

        public static void TestSolution()
        {
            lock (_lock)
            {
                _counterTotalSolutions++;
            }
        }

        public static void ValidateSolution()
        {
            lock (_lock)
            {
                _counterValidatedSolutions++;
            }
        }

        public static void InvalidateSolution()
        {
            lock (_lock)
            {
                _counterNotValidatedSolutions++;
            }
        }

        public static void TestDone()
        {
            lock (_lock)
            {
                _counterTotalTestCaseDone++;
            }
        }

        public static void ValidateTest()
        {
            lock (_lock)
            {
                _counterTestCaseValidated++;
            }
        }

        public static void InvalidateTest()
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
                double percentageTest = (_counterTestCaseValidated / _counterTotalTestCaseDone) * 100;
                string numbers = " (Tests Validated : [" + _counterTestCaseValidated.ToString() + "]" + " | Tests Invalidated : [" + _counterTestCaseNotValidated.ToString() + "])";
                string result = "Percentage of Tests Done : [" + percentageTest.ToString() + "%]"+ numbers;
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
                double percentageSolution = (_counterValidatedSolutions / _counterTotalSolutions) * 100;
                string numbers = " (Solutions Validated : [" + _counterValidatedSolutions.ToString() + "]" + " | Solutions Invalidated : [" + _counterNotValidatedSolutions.ToString() + "])";
                string result = "Percentage of Solutions Done : [" + percentageSolution.ToString() + "%]" + numbers;
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