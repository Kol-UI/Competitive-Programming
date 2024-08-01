using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PalindromePartitioning
{
	public class Solution
	{
        //Given a string s, partition s such that every substring of the partition is a palindrome.
        //Return all possible palindrome partitioning of s.

        //Example 1:

        //Input: s = "aab"
        //Output: [["a","a","b"], ["aa","b"]]

        //Example 2:

        //Input: s = "a"
        //Output: [["a"]]

        List<IList<string>> ans = new();
        public IList<IList<string>> Partition(string s)
        {
            List<string> list = new();
            Solve(s, list);
            return ans;
        }
        void Solve(string s, List<string> list)
        {
            if (s.Length == 0)
            {
                ans.Add(list.ToList());
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                string current = s.Substring(0, i + 1);
                string rest = s.Substring(i + 1);
                if (IsPalindrome(current))
                {
                    list.Add(current);
                    Solve(rest, list);
                    list.RemoveAt(list.Count - 1);
                }
            }

        }
        bool IsPalindrome(string s)
        {
            int start = 0, end = s.Length - 1;
            while (start <= end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Palindrome Partitioning");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}