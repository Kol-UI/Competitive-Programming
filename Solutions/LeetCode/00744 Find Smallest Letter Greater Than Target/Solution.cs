// Find Smallest Letter Greater Than Target

/*
You are given an array of characters letters that is sorted in non-decreasing order, and a character target. There are at least two different characters in letters.

Return the smallest character in letters that is lexicographically greater than target. If such a character does not exist, return the first character in letters.

 

Example 1:

Input: letters = ["c","f","j"], target = "a"
Output: "c"
Explanation: The smallest character that is lexicographically greater than 'a' in letters is 'c'.

Example 2:

Input: letters = ["c","f","j"], target = "c"
Output: "f"
Explanation: The smallest character that is lexicographically greater than 'c' in letters is 'f'.

Example 3:

Input: letters = ["x","x","y","y"], target = "z"
Output: "x"
Explanation: There are no characters in letters that is lexicographically greater than 'z' so we return letters[0].
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindSmallestLetterGreaterThanTarget
{
    public class Solution
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            var res = letters.Where(c=>c > target).ToList();
            if(res == null || res.Count == 0)
            {
                return letters[0];
            }
            return res.Min();
        }
    }

    public class Test
    {
        public static bool[] TestFindSmallestLetterGreaterThanTarget()
        {
            // Case 1
            char[] letters = {'c','f','j'};
            char target = 'a';
            char result1 = Solution.NextGreatestLetter(letters, target);

            // Case 2
            target = 'c';
            char result2 = Solution.NextGreatestLetter(letters, target);

            // Case 3
            char[] letters3 = {'x','x','y','y'};
            target = 'a';
            char result3 = Solution.NextGreatestLetter(letters3, target);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<char>(result1, 'c'),
                ResultTester.CheckResult<char>(result2, 'f'),
                ResultTester.CheckResult<char>(result3, 'x')
            };

            return results;
        }
    }
}