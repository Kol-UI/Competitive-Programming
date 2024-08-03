// Number of Steps to Reduce a Number in Binary Representation to One

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofStepstoReduceaNumberinBinaryRepresentationtoOne
{
    public class Solution
    {
        public static int NumSteps(string s)
        {
            int num = 0;
            int index = s.Length - 1;

            while (s[index] == '0')
            {
                num++;
                index--;
            }
            
            int ones = 0;
            while (index >= 0)
            {
                if (s[index] == '0')
                {
                    num += ones + 1;
                    ones = 1;
                }
                else
                {
                    ones++;
                }
                index--;
            }
            
            return num + ((ones > 1) ? ones + 1 : 0);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumSteps("1101"), 6),
                ResultTester.CheckResult<int>(Solution.NumSteps("10"), 1),
                ResultTester.CheckResult<int>(Solution.NumSteps("1"), 0),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Number of Steps to Reduce a Number in Binary Representation to One");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}