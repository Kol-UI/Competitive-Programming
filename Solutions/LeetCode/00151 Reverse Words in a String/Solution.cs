// Reverse Words in a String

/*
Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.

 

Example 1:

Input: s = "the sky is blue"
Output: "blue is sky the"

Example 2:

Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.

Example 3:

Input: s = "a good   example"
Output: "example good a"
Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ReverseWordsinaString
{
    public class Solution
    {
        public static string ReverseWords(string s)
        { 
            var sb = new List<string>();
            foreach(var item in s.Split(" ", options: StringSplitOptions.RemoveEmptyEntries).Reverse())        
                sb.Add(item);        
            return string.Join(" ", sb);
        }
        // Split the string into an array of words
        // Exclude any empty entries
        // Reverse the resulting array order
        // Each word is added
        // Concatenate the words in sb with a space separator
        // And return the resulting string

        public static string ReverseWordsSecond(string s)
        {
            return string.Join(' ', s.Trim().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Reverse());
        }
        // Trims the input string to remove any leading or trailing white spaces
        // Splits the trimmed string by space using 'Split'
        // Creates an array of substrings 
        // 'Where' filters out any substrings that are null, empty, or only contain white space
        // Reverses the order of the filtered substrings
        // Joins the reversed substrings using space character as separator using 'Join'
    }

    public class Test
    {
        public static bool[] TestReverseWordsinaString()
        {
            string s1 = "the sky is blue";
            string s2 = "  hello world  ";
            string s3 = "a good   example";
            string expected1 = "blue is sky the";
            string expected2 = "world hello";
            string expected3 = "example good a";

            string solution1Case1 = Solution.ReverseWords(s1);
            string solution2Case1 = Solution.ReverseWordsSecond(s1);

            string solution1Case2 = Solution.ReverseWords(s2);
            string solution2Case2 = Solution.ReverseWordsSecond(s2);

            string solution1Case3 = Solution.ReverseWords(s3);
            string solution2Case3 = Solution.ReverseWordsSecond(s3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution1Case1, expected1),
                ResultTester.CheckResult<string>(solution2Case1, expected1),
                ResultTester.CheckResult<string>(solution1Case2, expected2),
                ResultTester.CheckResult<string>(solution2Case2, expected2),
                ResultTester.CheckResult<string>(solution1Case3, expected3),
                ResultTester.CheckResult<string>(solution2Case3, expected3)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Words in a String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestReverseWordsinaString());
        }
    }
}