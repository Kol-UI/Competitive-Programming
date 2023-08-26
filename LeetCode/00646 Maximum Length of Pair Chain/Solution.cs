// Maximum Length of Pair Chain

/*
You are given an array of n pairs pairs where pairs[i] = [lefti, righti] and lefti < righti.

A pair p2 = [c, d] follows a pair p1 = [a, b] if b < c. A chain of pairs can be formed in this fashion.

Return the length longest chain which can be formed.

You do not need to use up all the given intervals. You can select pairs in any order.

 

Example 1:

Input: pairs = [[1,2],[2,3],[3,4]]
Output: 2
Explanation: The longest chain is [1,2] -> [3,4].

Example 2:

Input: pairs = [[1,2],[7,8],[4,5]]
Output: 3
Explanation: The longest chain is [1,2] -> [4,5] -> [7,8].
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumLengthofPairChain;

public class Solution
{
    public static int FindLongestChain(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));
        
        int cur = int.MinValue, ans = 0;
        
        foreach (var pair in pairs)
        {
            if (cur < pair[0])
            {
                cur = pair[1];
                ans++;
            }
        }
        
        return ans;
    }
}


public class Test
{
    public static bool[] TestCases()
    {
        int[][] array1 = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 2, 3 },
            new int[] { 3, 4 }
        };

        int[][] array2 = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 7, 8 },
            new int[] { 4, 5 }
        };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Solution.FindLongestChain(array1), 2),
            ResultTester.CheckResult<int>(Solution.FindLongestChain(array2), 3),
        };
        return results;
    }
}
