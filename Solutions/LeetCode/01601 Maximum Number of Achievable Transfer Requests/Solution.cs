// Maximum Number of Achievable Transfer Requests

/*
We have n buildings numbered from 0 to n - 1. Each building has a number of employees. It's transfer season, and some employees want to change the building they reside in.

You are given an array requests where requests[i] = [fromi, toi] represents an employee's request to transfer from building fromi to building toi.

All buildings are full, so a list of requests is achievable only if for each building, the net change in employee transfers is zero. This means the number of employees leaving is equal to the number of employees moving in. For example if n = 3 and two employees are leaving building 0, one is leaving building 1, and one is leaving building 2, there should be two employees moving to building 0, one employee moving to building 1, and one employee moving to building 2.

Return the maximum number of achievable requests.

 

Example 1:


Input: n = 5, requests = [[0,1],[1,0],[0,1],[1,2],[2,0],[3,4]]
Output: 5
Explantion: Let's see the requests:
From building 0 we have employees x and y and both want to move to building 1.
From building 1 we have employees a and b and they want to move to buildings 2 and 0 respectively.
From building 2 we have employee z and they want to move to building 0.
From building 3 we have employee c and they want to move to building 4.
From building 4 we don't have any requests.
We can achieve the requests of users x and b by swapping their places.
We can achieve the requests of users y, a and z by swapping the places in the 3 buildings.


Example 2:


Input: n = 3, requests = [[0,0],[1,2],[2,1]]
Output: 3
Explantion: Let's see the requests:
From building 0 we have employee x and they want to stay in the same building 0.
From building 1 we have employee y and they want to move to building 2.
From building 2 we have employee z and they want to move to building 1.
We can achieve all the requests. 


Example 3:

Input: n = 4, requests = [[0,3],[3,1],[1,2],[2,0]]
Output: 4
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofAchievableTransferRequests
{
    public class Solution
    {
        public static int MaximumRequests(int n, int[][] requests)
        {
            int m = requests.Length; 
            int maxAchievable = 0; 

            for (int mask = 0; mask < (1 << m); mask++)
            {
                int[] buildings = new int[n];

                for (int i = 0; i < m; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        int from = requests[i][0];
                        int to = requests[i][1];
                        buildings[from]--;
                        buildings[to]++;
                    }
                }

                bool isValid = true;
                for (int j = 0; j < n; j++)
                {
                    if (buildings[j] != 0)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    int count = CountSetBits(mask);
                    maxAchievable = Math.Max(maxAchievable, count);
                }
            }

            return maxAchievable;
        }
        
        private static int CountSetBits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count += num & 1;
                num >>= 1;
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestMaximumNumberofAchievableTransferRequests()
        {
            int n1 = 5;
            int[][] requests1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 0 },
                new int[] { 3, 4 }
            };

            int n2 = 3;
            int[][] requests2 = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 1, 2 },
                new int[] { 2, 1 }
            };

            int n3 = 4;
            int[][] requests3 = new int[][]
            {
                new int[] { 0, 3 },
                new int[] { 3, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 0 }
            };
            int result1 = Solution.MaximumRequests(n1, requests1);
            int result2 = Solution.MaximumRequests(n2, requests2);
            int result3 = Solution.MaximumRequests(n3, requests3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 5),
                ResultTester.CheckResult<int>(result2, 3),
                ResultTester.CheckResult<int>(result3, 4)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Achievable Transfer Requests");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestMaximumNumberofAchievableTransferRequests());
        }
    }
}