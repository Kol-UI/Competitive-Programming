using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.WordPattern
{
	public class Solution
	{
        //Given a pattern and a string s, find if s follows the same pattern.

        //Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.


        //Example 1:
        //Input: pattern = "abba", s = "dog cat cat dog"
        //Output: true

        //Example 2:
        //Input: pattern = "abba", s = "dog cat cat fish"
        //Output: false

        //Example 3:
        //Input: pattern = "aaaa", s = "dog cat cat dog"
        //Output: false


        public static bool WordPattern(string pattern, string s)
        {
            bool b = true;
            string[] SArray = s.Split(' ');
            if (pattern.Length != SArray.Length)
                return false;
            Dictionary<string, string> d = new Dictionary<string, string>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!d.ContainsKey(pattern[i].ToString()))
                {
                    if (!d.ContainsValue(SArray[i]))
                        d.Add(pattern[i].ToString(), SArray[i]);
                    else
                        return false;
                }
                else
                {
                    if (d[pattern[i].ToString()] != SArray[i])
                        return false;
                    else
                        b = true;
                }
            }
            return b;
        }
    }

    public class Test
    {
        public static bool[] TestWordPattern()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.WordPattern("abba", "dog cat cat dog"), true),
                ResultTester.CheckResult<bool>(Solution.WordPattern("abba", "dog cat cat fish"), false),
                ResultTester.CheckResult<bool>(Solution.WordPattern("aaaa", "dog cat cat dog"), false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Pattern");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestWordPattern());
        }
    }
}