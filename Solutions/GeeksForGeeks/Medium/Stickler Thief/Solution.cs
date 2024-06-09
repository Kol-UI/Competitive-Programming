// Stickler Thief

/*
Stickler the thief wants to loot money from a society having n houses in a single line. He is a weird person and follows a certain rule when looting the houses. According to the rule, he will never loot two consecutive houses. At the same time, he wants to maximize the amount he loots. The thief knows which house has what amount of money but is unable to come up with an optimal looting strategy. He asks for your help to find the maximum money he can get if he strictly follows the rule. ith house has a[i] amount of money present in it.

Example 1:

Input:
n = 5
a[] = {6,5,5,7,4}
Output: 
15
Explanation: 
Maximum amount he can get by looting 1st, 3rd and 5th house. Which is 6+5+4=15.

Example 2:

Input:
n = 3
a[] = {1,5,3}
Output: 
5
Explanation: 
Loot only 2nd house and get maximum amount of 5.
*/

using System;
using System.Collections;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.SticklerThief
{
    class Solution
    {
        public static int FindMaxSum(int[] arr, int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return arr[0];
            }
        
            int[] maxMoney = new int[n];
        
            maxMoney[0] = arr[0];
            maxMoney[1] = Math.Max(arr[0], arr[1]);
        
            for (int i = 2; i < n; i++)
            {
                maxMoney[i] = Math.Max(maxMoney[i - 1], maxMoney[i - 2] + arr[i]);
            }
        
            return maxMoney[n - 1];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 5;
            int[] a1 = {6,5,5,7,4};
            int n2 = 3;
            int[] a2 = {1,5,3};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.FindMaxSum(a1, n1), 15),
                ResultTester.CheckResult<long>(Solution.FindMaxSum(a2, n2), 5),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stickler Thief");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG, Test.TestCases());
        }
    }
}