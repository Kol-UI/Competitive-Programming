// Find the Student that Will Replace the Chalk

/*
There are n students in a class numbered from 0 to n - 1. The teacher will give each student a problem starting with the student number 0, then the student number 1, and so on until the teacher reaches the student number n - 1. After that, the teacher will restart the process, starting with the student number 0 again.

You are given a 0-indexed integer array chalk and an integer k. There are initially k pieces of chalk. When the student number i is given a problem to solve, they will use chalk[i] pieces of chalk to solve that problem. However, if the current number of chalk pieces is strictly less than chalk[i], then the student number i will be asked to replace the chalk.

Return the index of the student that will replace the chalk pieces.

 

Example 1:

Input: chalk = [5,1,5], k = 22
Output: 0
Explanation: The students go in turns as follows:
- Student number 0 uses 5 chalk, so k = 17.
- Student number 1 uses 1 chalk, so k = 16.
- Student number 2 uses 5 chalk, so k = 11.
- Student number 0 uses 5 chalk, so k = 6.
- Student number 1 uses 1 chalk, so k = 5.
- Student number 2 uses 5 chalk, so k = 0.
Student number 0 does not have enough chalk, so they will have to replace it.

Example 2:

Input: chalk = [3,4,1,2], k = 25
Output: 1
Explanation: The students go in turns as follows:
- Student number 0 uses 3 chalk so k = 22.
- Student number 1 uses 4 chalk so k = 18.
- Student number 2 uses 1 chalk so k = 17.
- Student number 3 uses 2 chalk so k = 15.
- Student number 0 uses 3 chalk so k = 12.
- Student number 1 uses 4 chalk so k = 8.
- Student number 2 uses 1 chalk so k = 7.
- Student number 3 uses 2 chalk so k = 5.
- Student number 0 uses 3 chalk so k = 2.
Student number 1 does not have enough chalk, so they will have to replace it.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheStudentthatWillReplacetheChalk
{
    public class Solution
    {
        public static int ChalkReplacer(int[] chalk, int k)
        {
            var n = chalk.Length;
            if (n == 1) return 0;

            var sum = chalk[0];
            var i = 1;

            for (i = 1; i < n; i++)
            {
                sum += chalk[i];
                chalk[i] = sum;

                if (sum >= k)
                {
                    break;
                }
            }

            if (k == sum) return 0;
            var num = (k > sum) ? k % sum : k;

            var left = 0;
            var mid = 0;

            var right = i;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (chalk[mid] == num)
                {
                    break;
                }
                else if (num > chalk[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return chalk[mid] > num ? mid : mid + 1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] chalk1 = {5,1,5};
            int k1 = 22;
            int[] chalk2 = {3,4,1,2};
            int k2 = 25;
            int result1 = Solution.ChalkReplacer(chalk1, k1);
            int result2 = Solution.ChalkReplacer(chalk2, k2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 0),
                ResultTester.CheckResult<int>(result2, 1)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1894");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}