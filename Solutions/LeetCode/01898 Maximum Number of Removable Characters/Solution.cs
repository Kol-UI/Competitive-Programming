// Maximum Number of Removable Characters

/*
You are given two strings s and p where p is a subsequence of s. You are also given a distinct 0-indexed integer array removable containing a subset of indices of s (s is also 0-indexed).

You want to choose an integer k (0 <= k <= removable.length) such that, after removing k characters from s using the first k indices in removable, p is still a subsequence of s. More formally, you will mark the character at s[removable[i]] for each 0 <= i < k, then remove all marked characters and check if p is still a subsequence.

Return the maximum k you can choose such that p is still a subsequence of s after the removals.

A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

 

Example 1:

Input: s = "abcacb", p = "ab", removable = [3,1,0]
Output: 2
Explanation: After removing the characters at indices 3 and 1, "abcacb" becomes "accb".
"ab" is a subsequence of "accb".
If we remove the characters at indices 3, 1, and 0, "abcacb" becomes "ccb", and "ab" is no longer a subsequence.
Hence, the maximum k is 2.

Example 2:

Input: s = "abcbddddd", p = "abcd", removable = [3,2,1,4,5,6]
Output: 1
Explanation: After removing the character at index 3, "abcbddddd" becomes "abcddddd".
"abcd" is a subsequence of "abcddddd".

Example 3:

Input: s = "abcab", p = "abc", removable = [0,1,2,3,4]
Output: 0
Explanation: If you remove the first index in the array removable, "abc" is no longer a subsequence.
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumNumberofRemovableCharacters
{
    public class Solution 
    {
        public static int MaximumRemovals(string s, string p, int[] removable) 
        {
            int left = 0;
            int right = removable.Length - 1;
            int result = -1;

            while (left <= right)
            { 
                int mid = (left + right) / 2;

                HashSet<int> set = new HashSet<int>();
                for (int i = 0; i <= mid; i++)
                {
                    set.Add(removable[i]);
                }

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < s.Length; i++)
                {
                    if (set.Contains(i))
                    {
                        continue;
                    }

                    stringBuilder.Append(s[i]);
                }
                

                if (isSubstring(stringBuilder.ToString(), p))
                {
                    result = Math.Max(result, mid);
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result + 1;

            static bool isSubstring(string s, string p)
            {
                Stack<char> stack = new Stack<char>();

                foreach (char c in p.ToCharArray())
                {
                    stack.Push(c);
                }

                for (int i = s.Length - 1; i > -1; i--)
                {
                    if (stack.Count > 0 && stack.Peek() == s[i])
                    {
                        stack.Pop();
                    }
                }

                return (stack.Count == 0);
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string s1 = "abcacb"; string p1 = "ab"; int[] removable1 = {3,1,0};
            string s2 = "abcbddddd"; string p2 = "abcd"; int[] removable2 = {3,2,1,4,5,6};
            string s3 = "abcab"; string p3 = "abc"; int[] removable3 = {0,1,2,3,4};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaximumRemovals(s1, p1, removable1), 2),
                ResultTester.CheckResult<int>(Solution.MaximumRemovals(s2, p2, removable2), 1),
                ResultTester.CheckResult<int>(Solution.MaximumRemovals(s3, p3, removable3), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Maximum number of Removable Characters");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}