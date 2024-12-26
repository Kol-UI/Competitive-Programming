// Find first set bit



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.Findfirstsetbit
{
    public class Solution
    {
        public static uint getFirstSetBit(int n)
        {
            uint position = 1;
    
            while (n > 0)
            {
                if ((n & 1) == 1)
                    return position;
    
                n >>= 1;
    
                position++;
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
                ResultTester.CheckResult<uint>(Solution.getFirstSetBit(18), 2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find first set bit");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG, Test.TestCases());
        }
    }
}