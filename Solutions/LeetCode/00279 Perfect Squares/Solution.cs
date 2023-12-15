// Perfect Squares

/*
Given an integer n, return the least number of perfect square numbers that sum to n.

A perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself. For example, 1, 4, 9, and 16 are perfect squares while 3 and 11 are not.

 

Example 1:

Input: n = 12
Output: 3
Explanation: 12 = 4 + 4 + 4.
Example 2:

Input: n = 13
Output: 2
Explanation: 13 = 4 + 9.
*/


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PerfectSquares;

public class Solution
{
    public static int NumSquares(int n)
    {
        var cache = new Dictionary<int, int>();
        
        for (var s = 1; s * s <= n; s++)
        {
            cache.Add(s * s, 1);
        }

        return DFS(n);

        int DFS(int num)
        {
            if (num == 0) return 0;

            if (cache.ContainsKey(num)) return cache[num];

            var min = int.MaxValue;

            for (var s = 1; s * s <= num; s++)
            {
                var square = s * s;
                var rem = num % square;
                var times = (num - rem) / square;

                min = Math.Min(min, times + DFS(rem));
            }

            cache[num] = min;
            return cache[num];
        }
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Solution.NumSquares(12), 3),
            ResultTester.CheckResult<int>(Solution.NumSquares(13), 2),
        };
        return results;
    }
}