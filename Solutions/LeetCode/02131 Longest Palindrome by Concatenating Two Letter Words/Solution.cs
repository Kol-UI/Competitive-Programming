// Longest Palindrome by Concatenating Two Letter Words

/*
You are given an array of strings words. Each element of words consists of two lowercase English letters.

Create the longest possible palindrome by selecting some elements from words and concatenating them in any order. Each element can be selected at most once.

Return the length of the longest palindrome that you can create. If it is impossible to create any palindrome, return 0.

A palindrome is a string that reads the same forward and backward.

 

Example 1:

Input: words = ["lc","cl","gg"]
Output: 6
Explanation: One longest palindrome is "lc" + "gg" + "cl" = "lcggcl", of length 6.
Note that "clgglc" is another longest palindrome that can be created.


Example 2:

Input: words = ["ab","ty","yt","lc","cl","ab"]
Output: 8
Explanation: One longest palindrome is "ty" + "lc" + "cl" + "yt" = "tylcclyt", of length 8.
Note that "lcyttycl" is another longest palindrome that can be created.


Example 3:

Input: words = ["cc","ll","xx"]
Output: 2
Explanation: One longest palindrome is "cc", of length 2.
Note that "ll" is another longest palindrome that can be created, and so is "xx".
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LongestPalindromebyConcatenatingTwoLetterWords
{
    public class Solution
    {
        public static int LongestPalindrome(string[] words)
        {
            var longest_palindrome = 0;
            var isValidPalindrome = false;
            var map = new Dictionary<string, int>();

            foreach(var word in words)
                map[word] = map.GetValueOrDefault(word, 0) + 1;

            foreach(var word in words)
            {
                if(map[word] > 0)
                {
                    map[word]--;
                    var str = word[1] + "" + word[0];
                    if(map.ContainsKey(str) && map[str] > 0)
                    {
                        longest_palindrome += 4;
                        map[str]--;
                    }
                    else if(word == str)
                        isValidPalindrome = true;
                }
            }

            return isValidPalindrome ? longest_palindrome + 2 : longest_palindrome;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] words1 = {"lc","cl","gg"};
            string[] words2 = {"ab","ty","yt","lc","cl","ab"};
            string[] words3 = {"cc","ll","xx"};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LongestPalindrome(words1), 6),
                ResultTester.CheckResult<int>(Solution.LongestPalindrome(words2), 8),
                ResultTester.CheckResult<int>(Solution.LongestPalindrome(words3), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Longest Palindrome by Concatenating Two Letter Words");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}