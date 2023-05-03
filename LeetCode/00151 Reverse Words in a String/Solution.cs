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
}