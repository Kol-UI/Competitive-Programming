// Excel Sheet Column Title

/*
Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 

Example 1:

Input: columnNumber = 1
Output: "A"

Example 2:

Input: columnNumber = 28
Output: "AB"

Example 3:

Input: columnNumber = 701
Output: "ZY"
*/

using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ExcelSheetColumnTitle
{
    public class Solution
    {
        public static string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new();
            while (columnNumber > 0)
            {
                var index = (columnNumber - 1) % 26;
                sb.Insert(0, (char)('A' + index));
                columnNumber = (columnNumber - 1) / 26;
            }

            return sb.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.ConvertToTitle(1), "A"),
                ResultTester.CheckResult<string>(Solution.ConvertToTitle(28), "AB"),
                ResultTester.CheckResult<string>(Solution.ConvertToTitle(701), "ZY"),
            };

            return results;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Excel Sheet Column Title");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}