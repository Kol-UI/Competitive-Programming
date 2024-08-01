using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

        public static string Convert(string s, int numRows)
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

    public class Test
    {
        public static bool[] TestZigzagConversion()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.Convert("PAYPALISHIRING", 3), "PAHNAPLSIIGYIR"),
                ResultTester.CheckResult<string>(Solution.Convert("PAYPALISHIRING", 4), "PINALSIGYAHRPI"),
                ResultTester.CheckResult<string>(Solution.Convert("A", 1), "A"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Zigzag Conversion");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestZigzagConversion());
        }
    }
}