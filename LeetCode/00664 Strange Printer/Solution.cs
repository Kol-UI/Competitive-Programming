// Strange Printer

/*
There is a strange printer with the following two special properties:

The printer can only print a sequence of the same character each time.
At each turn, the printer can print new characters starting from and ending at any place and will cover the original existing characters.
Given a string s, return the minimum number of turns the printer needed to print it.

 

Example 1:

Input: s = "aaabbb"
Output: 2
Explanation: Print "aaa" first and then print "bbb".


Example 2:

Input: s = "aba"
Output: 2
Explanation: Print "aaa" first and then print "b" from the second place of the string, which will cover the existing character 'a'.
*/

using System;
using System.Text;

namespace CompetitiveProgramming.LeetCode.StrangePrinter
{
    public class Solution 
    {
        public static Dictionary<char, List<int>> data = new Dictionary<char, List<int>>();
        public static Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>(); 
        public static string? target;
        public static int StrangePrinter(string s) 
        {
            var sb = new StringBuilder();
            foreach(var ch in s)
            {
                if(sb.Length == 0 || sb[sb.Length - 1] != ch)
                {
                    sb.Append(ch);
                }
            }

            target = sb.ToString();
            var n = target.Length;

            return Solve(0, n - 1);     
        }

        public static int Solve(int start, int end)
        {
            if(start == end)
            {
                return 1;
            }

            if(start > end)
            {
                return 0;
            }

            if(!cache.ContainsKey((start, end)))
            {
                var result = target![start] == target[end] ? Solve(start, end - 1) : end - start + 1;

                for(int i = start; i < end; ++i)
                {
                    result = Math.Min(result, Solve(start, i) + Solve(i + 1, end));
                }

                cache.Add((start, end), result);
            }

            return cache[(start, end)];
        }
    }
}