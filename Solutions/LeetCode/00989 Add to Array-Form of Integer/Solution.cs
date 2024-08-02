using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AddtoArrayFormofInteger
{
	public class Solution
    {
        // The array-form of an integer num is an array representing its digits in left to right order.
        // For example, for num = 1321, the array form is [1,3,2,1].
        // Given num, the array-form of an integer, and an integer k, return the array-form of the integer num + k.

        // Example 1:

        // Input: num = [1,2,0,0], k = 34
        // Output: [1,2,3,4]
        // Explanation: 1200 + 34 = 1234
        
        // Example 2:

        // Input: num = [2,7,4], k = 181
        // Output: [4,5,5]
        // Explanation: 274 + 181 = 455
        
        // Example 3:

        // Input: num = [2,1,5], k = 806
        // Output: [1,0,2,1]
        // Explanation: 215 + 806 = 1021

        public static IList<int> AddToArrayForm(int[] num, int k)
        {
            var list = new List<int>(num);
            int ext, i = list.Count - 1;
            while (k > 0)
            {
                if (i >= 0)
                {
                    ext = (list[i] + k % 10) / 10;
                    list[i] = (list[i] + k % 10) - ext * 10;
                }
                else
                {
                    ext = 0;
                    list.Insert(0, k % 10);
                }
                k = k / 10 + ext;
                i--;
            }
            return list;
        }

    }


    public class Test
    {
        public static bool[] TestAddtoArrayFormofInteger()
        {
            int[] num1 = new int[] {1, 2, 0, 0};
            int k1 = 34;

            int[] num2 = new int[] {2, 7, 4};
            int k2 = 181;

            int[] num3 = new int[] {2, 1, 5};
            int k3 = 806;

            IList<int> expected1 = new List<int> {1, 2, 3, 4};
            IList<int> expected2 = new List<int> {4, 5, 5};
            IList<int> expected3 = new List<int> {1, 0, 2, 1};


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.AddToArrayForm(num1, k1), expected1),
                ResultTester.CheckResult<IList<int>>(Solution.AddToArrayForm(num2, k2), expected2),
                ResultTester.CheckResult<IList<int>>(Solution.AddToArrayForm(num3, k3), expected3)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("989");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestAddtoArrayFormofInteger());
        }
    }
}