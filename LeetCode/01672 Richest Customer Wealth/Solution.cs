using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RichestCustomerWealth
{
	public class Solution
	{
        //You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.Return the wealth that the richest customer has.

        //A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.


        //Example 1:

        //Input: accounts = [[1, 2, 3], [3,2,1]]
        //Output: 6
        //Explanation:
        //1st customer has wealth = 1 + 2 + 3 = 6
        //2nd customer has wealth = 3 + 2 + 1 = 6
        //Both customers are considered the richest with a wealth of 6 each, so return 6.
        //Example 2:

        //Input: accounts = [[1,5],[7,3],[3,5]]
        //Output: 10
        //Explanation: 
        //1st customer has wealth = 6
        //2nd customer has wealth = 10 
        //3rd customer has wealth = 8
        //The 2nd customer is the richest with a wealth of 10.
        //Example 3:

        //Input: accounts = [[2,8,7],[7,1,3],[1,9,5]]
        //Output: 17

        public static int MaximumWealth(int[][] accounts) => accounts.Max(c => c.Sum());

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] accounts1 = new int[][]
            {
                new int[]{1, 2, 3},
                new int[]{3,2,1}
            };
            int[][] accounts2 = new int[][]
            {
                new int[]{1,5},
                new int[]{7,3},
                new int[]{3,5}
            };
            int[][] accounts3 = new int[][]
            {
                new int[]{2,8,7},
                new int[]{7,1,3},
                new int[]{1,9,5}
            };
            int result1 = Solution.MaximumWealth(accounts1);
            int result2 = Solution.MaximumWealth(accounts2);
            int result3 = Solution.MaximumWealth(accounts3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 6),
                ResultTester.CheckResult<int>(result2, 10),
                ResultTester.CheckResult<int>(result3, 17)
            };
            return results;
        }
    }
}

