using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.StringCompression
{
    public class Solution
    {
        // Given an array of characters chars, compress it using the following algorithm:
        // Begin with an empty string s. For each group of consecutive repeating characters in chars:
        // If the group's length is 1, append the character to s.
        // Otherwise, append the character followed by the group's length.
        // The compressed string s should not be returned separately, but instead, be stored in the input character array chars.
        // Note that group lengths that are 10 or longer will be split into multiple characters in chars.
        // After you are done modifying the input array, return the new length of the array.
        // You must write an algorithm that uses only constant extra space.

        // Example 1:
        // Input: chars = ["a","a","b","b","c","c","c"]
        // Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
        // Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
        
        // Example 2:
        // Input: chars = ["a"]
        // Output: Return 1, and the first character of the input array should be: ["a"]
        // Explanation: The only group is "a", which remains uncompressed since it's a single character.
        
        // Example 3:
        // Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
        // Output: Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
        // Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".

        public static int Compress(char[] chars)
        {
            int count = 0;
            int i = 0;
            int j = 0;

            while(i < chars.Length)
            {
                var currentChar = chars[i];
                count = 0;

                while (i < chars.Length && chars[i] == currentChar)
                {
                    i++;
                    count++;
                }

                chars[j++] = currentChar;


                if (count > 1)
                {
                    foreach (var countChar in count.ToString())
                    {
                        chars[j++] = countChar;
                    }
                }
            }
            return j;
        }
    }

    public class Test
    {
        public static bool[] TestStringCompression()
        {
            // Case 1
            char[] case1_443 = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int result1_443 = LeetCode.StringCompression.Solution.Compress(case1_443);

            // Case 2
            char[] case2_443 = { 'a' };
            int result2_443 = LeetCode.StringCompression.Solution.Compress(case2_443);

            // Case 3
            char[] case3_443 = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            int result3_443 = LeetCode.StringCompression.Solution.Compress(case3_443);

            // Case 4
            char[] case4_443 = { '1', '1', '2' };
            int result4_443 = LeetCode.StringCompression.Solution.Compress(case4_443);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_443, 6),
                ResultTester.CheckResult<int>(result2_443, 1),
                ResultTester.CheckResult<int>(result3_443, 4),
                ResultTester.CheckResult<int>(result4_443, result4_443)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("String Compression");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestStringCompression());
        }
    }
}