// Find First Palindromic String in the Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindFirstPalindromicStringintheArray
{
    public class Solution 
    {
        public static string FirstPalindrome(string[] words) 
        {
            foreach(var i in words) 
                if(i == string.Concat(i.Reverse())) return i; 
            return "";
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.FirstPalindrome(new string[] {"abc","car","ada","racecar","cool"}), "ada"),
                ResultTester.CheckResult<string>(Solution.FirstPalindrome(new string[] {"notapalindrome","racecar"}), "racecar"),
                ResultTester.CheckResult<string>(Solution.FirstPalindrome(new string[] {"def","ghi"}), ""),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2108");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}