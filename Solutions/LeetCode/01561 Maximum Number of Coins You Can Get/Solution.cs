// Maximum Number of Coins You Can Get

/*
There are 3n piles of coins of varying size, you and your friends will take piles of coins as follows:

In each step, you will choose any 3 piles of coins (not necessarily consecutive).
Of your choice, Alice will pick the pile with the maximum number of coins.
You will pick the next pile with the maximum number of coins.
Your friend Bob will pick the last pile.
Repeat until there are no more piles of coins.
Given an array of integers piles where piles[i] is the number of coins in the ith pile.

Return the maximum number of coins that you can have.

 

Example 1:

Input: piles = [2,4,1,2,7,8]
Output: 9
Explanation: Choose the triplet (2, 7, 8), Alice Pick the pile with 8 coins, you the pile with 7 coins and Bob the last one.
Choose the triplet (1, 2, 4), Alice Pick the pile with 4 coins, you the pile with 2 coins and Bob the last one.
The maximum number of coins which you can have are: 7 + 2 = 9.
On the other hand if we choose this arrangement (1, 2, 8), (2, 4, 7) you only get 2 + 4 = 6 coins which is not optimal.

Example 2:

Input: piles = [2,4,5]
Output: 4

Example 3:

Input: piles = [9,8,7,6,5,1,2,3,4]
Output: 18

*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofCoinsYouCanGet
{
    public class Solution
    {
        public static int MaxCoins(int[] piles)
        {
            int bob = 0;
            int number = piles.Length - 2;
            int result = 0;

            Array.Sort(piles);

            while (bob < number)
            {
                result += piles[number];
                number -= 2;
                bob++;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] piles1 = {2,4,1,2,7,8};
            int[] piles2 = {2,4,5};
            int[] piles3 = {9,8,7,6,5,1,2,3,4};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxCoins(piles1), 9),
                ResultTester.CheckResult<int>(Solution.MaxCoins(piles2), 4),
                ResultTester.CheckResult<int>(Solution.MaxCoins(piles3), 18),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Maximum Number of Coins You Can Get");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}