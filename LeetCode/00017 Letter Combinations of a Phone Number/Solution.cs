// Letter Combinations of a Phone Number

/*
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.



Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

Example 2:

Input: digits = ""
Output: []
Example 3:

Input: digits = "2"
Output: ["a","b","c"]
*/

using System;
namespace CompetitiveProgramming.LeetCode.LetterCombinationsofaPhoneNumber
{
    public class Solution
    {
        // Backtracking
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();

            if(string.IsNullOrEmpty(digits)) return result;

            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "2", "abc" },
                { "3", "def" },
                { "4", "ghi" },
                { "5", "jkl" },
                { "6", "mno" },
                { "7", "qprs" },
                { "8", "tuv" },
                { "9", "wxyz" }
            };

            void Backtracking(int index, string curr)
            {
                if(curr.Length == digits.Length)
                {
                    result.Add(curr);
                    return;
                }

                string chars = dict[digits[index].ToString()];
                for(int i = 0; i < chars.Length; i++)
                {
                    Backtracking(index + 1, curr + chars[i]);
                }
            }

            Backtracking(0, string.Empty);

            return result;
        }
    }
}