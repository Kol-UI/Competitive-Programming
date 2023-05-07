// Find the Difference

/*
You are given two strings s and t.

String t is generated by random shuffling string s and then add one more letter at a random position.

Return the letter that was added to t.

 

Example 1:

Input: s = "abcd", t = "abcde"
Output: "e"
Explanation: 'e' is the letter that was added.

Example 2:

Input: s = "", t = "y"
Output: "y"
 

Constraints:

0 <= s.length <= 1000
t.length == s.length + 1
s and t consist of lowercase English letters.
*/

using System;
namespace CompetitiveProgramming.LeetCode.FindtheDifference
{
    public class Solution
    {
        public static char FindTheDifference(string s, string t)
        {
            // Concatenate both strings
            string str = string.Concat(s, t);

            // Group the characters in the concatenated string by their value
            // and select those that have an odd count (those that appear only once)
            var a = str.GroupBy(x => x).Where(x => x.Count() % 2 == 1).Select(x => x.First());
            
            // Initialize a variable to store the result
            char result = 'a';

            // Iterate over the characters that appear only once and store the last one in the result
            foreach(var b in a)
            {
                result = b;
            }
            return result;
        }
    }
}