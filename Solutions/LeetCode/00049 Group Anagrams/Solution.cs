// Group Anagrams

/*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Example 2:

Input: strs = [""]
Output: [[""]]

Example 3:

Input: strs = ["a"]
Output: [["a"]]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var set = new Dictionary<string, IList<string>>();
            foreach(string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string value = new string(chars);
                if(set.ContainsKey(value))
                {
                    set[value].Add(str);
                }
                else
                {
                    set.Add(value, new List<string>(){ str });
                }
            }
            return set.Values.ToList();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] case1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
            string[] case2 = { "" };
            string[] case3 = { "a" };

            IList<IList<string>> expected1 = new List<IList<string>>
            {
                new List<string> { "eat", "tea", "ate" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            };

            IList<IList<string>> expected2 = new List<IList<string>>
            {
                new List<string> { "" }
            };

            IList<IList<string>> expected3 = new List<IList<string>>
            {
                new List<string> { "a" }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<string>>>(Solution.GroupAnagrams(case1), expected1),
                ResultTester.CheckResult<IList<IList<string>>>(Solution.GroupAnagrams(case2), expected2),
                ResultTester.CheckResult<IList<IList<string>>>(Solution.GroupAnagrams(case3), expected3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Group Anagrams");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}