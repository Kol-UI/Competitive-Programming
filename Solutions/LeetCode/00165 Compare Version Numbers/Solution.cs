// Compare Version Numbers

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CompareVersionNumbers
{
    public class Solution
    {
        public static int CompareVersion(string version1, string version2)
        {
            var version1Value = version1.Split('.');
            var version2Value = version2.Split('.');
            int i = 0;

            while(i < version1Value.Length && i < version2Value.Length)
            {
                int num1 = Convert.ToInt32(version1Value[i]);
                int num2 = Convert.ToInt32(version2Value[i]);

                if(num1 < num2) return -1;

                if(num1 > num2) return 1;

                i++;
            }

            while(i < version1Value.Length)
            {
                int num1 = Convert.ToInt32(version1Value[i]);
                
                if(num1 > 0) return 1;
                
                i++;
            }

            while(i < version2Value.Length)
            {
                int num2 = Convert.ToInt32(version2Value[i]);
                
                if(num2 > 0) return -1;
                
                i++;
            }

            return 0;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CompareVersion("1.01", "1.001"), 0),
                ResultTester.CheckResult<int>(Solution.CompareVersion("1.0", "1.0.0"), 0),                
                ResultTester.CheckResult<int>(Solution.CompareVersion("0.1", "1.1"), -1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Compare Version Numbers");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}