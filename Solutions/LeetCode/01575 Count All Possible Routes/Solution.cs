// Count All Possible Routes

/*
You are given an array of distinct positive integers locations where locations[i] represents the position of city i. You are also given integers start, finish and fuel representing the starting city, ending city, and the initial amount of fuel you have, respectively.

At each step, if you are at city i, you can pick any city j such that j != i and 0 <= j < locations.length and move to city j. Moving from city i to city j reduces the amount of fuel you have by |locations[i] - locations[j]|. Please notice that |x| denotes the absolute value of x.

Notice that fuel cannot become negative at any point in time, and that you are allowed to visit any city more than once (including start and finish).

Return the count of all possible routes from start to finish. Since the answer may be too large, return it modulo 109 + 7.

 

Example 1:

Input: locations = [2,3,6,8,4], start = 1, finish = 3, fuel = 5
Output: 4
Explanation: The following are all possible routes, each uses 5 units of fuel:
1 -> 3
1 -> 2 -> 3
1 -> 4 -> 3
1 -> 4 -> 2 -> 3

Example 2:

Input: locations = [4,3,1], start = 1, finish = 0, fuel = 6
Output: 5
Explanation: The following are all possible routes:
1 -> 0, used fuel = 1
1 -> 2 -> 0, used fuel = 5
1 -> 2 -> 1 -> 0, used fuel = 5
1 -> 0 -> 1 -> 0, used fuel = 3
1 -> 0 -> 1 -> 0 -> 1 -> 0, used fuel = 5

Example 3:

Input: locations = [5,2,1], start = 0, finish = 2, fuel = 3
Output: 0
Explanation: It is impossible to get from 0 to 2 using only 3 units of fuel since the shortest route needs 4 units of fuel.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountAllPossibleRoutes
{
    public class Solution
    {
        private const int Modulo = 1_000_000_007;
        private static int[,]? _dp;
        private static int[]? _locations;

        public static int CountRoutes(int[] locations, int start, int finish, int fuel)
        {
            _locations = locations;
            _dp = new int[locations.Length, fuel + 1];

            for (var i = 0; i < locations.Length; i++)
            {
                for (var j = 0; j < fuel + 1; j++)
                {
                    _dp[i, j] = -1;
                }
            }

            return dfs(start, finish, fuel);
        }

        private static int dfs(int i, int finish, int fuel)
        {
            var n = _locations!.Length;
            if (fuel < 0)
            {
                return 0;
            }

            if (_dp![i, fuel] != -1)
            {
                return _dp[i, fuel];
            }

            var ans = 0;

            if (i == finish)
            {
                ans++;
            }

            for (var j = 0; j < n; j++)
            {
                if (j == i)
                {
                    continue;
                }

                ans = (ans + dfs(j, finish, fuel - Math.Abs(_locations[i] - _locations[j]))) % Modulo;
            }

            return _dp[i, fuel] = ans;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] locations1 = {2,3,6,8,4}; int start1 = 1; int finish1 = 3; int fuel1 = 5;
            int[] locations2 = {4,3,1}; int start2 = 1; int finish2 = 0; int fuel2 = 6;
            int[] locations3 = {5,2,1}; int start3 = 0; int finish3 = 2; int fuel3 = 3;
            int result1 = Solution.CountRoutes(locations1, start1, finish1, fuel1);
            int result2 = Solution.CountRoutes(locations2, start2, finish2, fuel2);
            int result3 = Solution.CountRoutes(locations3, start3, finish3, fuel3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 5),
                ResultTester.CheckResult<int>(result3, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count All Possible Routes");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}