// Counting Bits

/*
Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.

 

Example 1:

Input: n = 2
Output: [0,1,1]
Explanation:
0 --> 0
1 --> 1
2 --> 10

Example 2:

Input: n = 5
Output: [0,1,1,2,1,2]
Explanation:
0 --> 0
1 --> 1
2 --> 10
3 --> 11
4 --> 100
5 --> 101
*/


using System;
namespace CompetitiveProgramming.LeetCode.CountingBits
{
    public class Solution
    {
        public static int[] CountBits(int n)
        {
            var result = new int[n + 1];
            var kvp = new Dictionary<int, int>();
            
            for (int i = 0; i <= n; i++)
            {
                var numberOfOnes = 0;
                var temp = i;
                while (temp != 0)
                {
                    var rem = temp % 2;
                    temp /= 2;
                    if (rem == 1)
                    {
                        numberOfOnes++;
                    }
                    if (kvp.ContainsKey(temp))
                    {
                        var value = kvp[temp];
                        numberOfOnes += value;
                        break;
                    }
                }
                kvp.Add(i, numberOfOnes);
                result[i] = numberOfOnes;
            }
            return result;
        }
    }
}