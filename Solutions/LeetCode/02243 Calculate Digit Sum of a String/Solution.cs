// Calculate Digit Sum of a String

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CalculateDigitSumofaString
{
    public class Solution
    {
        public string DigitSum(string s, int k)
        {
            while (s.Length > k)
            {
                List<string> groups = new List<string>();

                for (int i = 0; i < s.Length; i += k)
                {
                    string group = s.Substring(i, Math.Min(k, s.Length - i));
                    int sum = 0;
                    
                    foreach (char c in group)
                    {
                        sum += c - '0';
                    }
                    
                    groups.Add(sum.ToString());
                }

                s = string.Join("", groups);
            }

            return s;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution.DigitSum("11111222223", 3), "135"),
                ResultTester.CheckResult<string>(solution.DigitSum("00000000", 3), "000")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate Digit Sum of a String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}