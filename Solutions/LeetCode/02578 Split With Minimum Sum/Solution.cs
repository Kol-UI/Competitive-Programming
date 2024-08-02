// Split With Minimum Sum


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SplitWithMinimumSum
{
    public class Solution
    {
        public static int SplitNum(int num)
        {
            var i = num.ToString();
            var m = i.ToCharArray();

            Array.Sort(m);

            var sum = "";           
            var sum2 = ""; 
                                
            for(int im = 0; im < m.Length; im++)
            {
                if (im % 2 == 0)
                {
                    sum += m[im];                   
                }
                else
                {
                    sum2 += m[im];
                }
            }

            return int.Parse(sum) + int.Parse(sum2);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SplitNum(4325), 59),
                ResultTester.CheckResult<int>(Solution.SplitNum(687), 75),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2578");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}