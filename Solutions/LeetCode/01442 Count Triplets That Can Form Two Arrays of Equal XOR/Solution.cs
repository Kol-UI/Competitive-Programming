// Count Triplets That Can Form Two Arrays of Equal XOR

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CountTripletsThatCanFormTwoArraysofEqualXOR
{
    public class Solution
    {
        public static int CountTriplets(int[] arr)
        {
            if (arr.Length < 2 || arr == null) return 0;

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int length = 1;
                int XOR = arr[i];
                for (int k = i + 1; k < arr.Length; k++)
                {
                    length++;
                    XOR ^= arr[k];
                    if (XOR == 0) count += length - 1;
                }
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountTriplets(new int[]{2,3,1,6,7}), 4),
                ResultTester.CheckResult<int>(Solution.CountTriplets(new int[]{1,1,1,1,1}), 10),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Count Triplets That Can Form Two Arrays of Equel XOR");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}