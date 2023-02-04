using System;

namespace CompetitiveProgramming.LeetCode.ZigzagConversion
{
    public class Solution
    {
        // The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
        // P   A   H   N
        // A P L S I I G
        // Y   I   R
        // And then read line by line: "PAHNAPLSIIGYIR"
        // Write the code that will take a string and make this conversion given a number of rows:
        // string convert(string s, int numRows);

        // Example 1:

        // Input: s = "PAYPALISHIRING", numRows = 3
        // Output: "PAHNAPLSIIGYIR"

        // Example 2:

        // Input: s = "PAYPALISHIRING", numRows = 4
        // Output: "PINALSIGYAHRPI"
        // Explanation:
        // P     I    N
        // A   L S  I G
        // Y A   H R
        // P     I
        
        // Example 3:

        // Input: s = "A", numRows = 1
        // Output: "A"

        public string Convert(string s, int numRows)
        {
            var n = s.Length;
            if (n <= numRows)
            {
                return s;
            }
            
            var nums = new int[n];

            for (var i = 0; i < n; )
            {
                var num = 1;
                while (num <= numRows && i < n)
                {
                    nums[i++] = num++;
                }
                
                num = numRows - 1;
                while (num > 1 && i < n)
                {
                    nums[i++] = num--;
                }
            }

            var arr = new string[numRows];
            
            for (var i = 0; i < n; i++)
            {
                arr[nums[i] - 1] += s[i];
            }

            return string.Join("", arr);
        }
    }
}