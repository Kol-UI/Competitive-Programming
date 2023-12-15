// Pascal's Triangle II

/*
Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:



Example 1:

Input: rowIndex = 3
Output: [1,3,3,1]

Example 2:

Input: rowIndex = 0
Output: [1]

Example 3:

Input: rowIndex = 1
Output: [1,1]
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PascalsTriangleII
{
    public class Solution
    {
        public static IList<int> GetRow(int rowIndex)
        {
            var FirstRow = new List<int>() { 1, 1 };
            var SecondRow = new List<int>() { 1, 1 };

            if (rowIndex == 0) return new int[] { 1 };
            if (rowIndex == 1) return new int[] { 1, 1 };

            rowIndex = rowIndex - 2;
            while (true)
            {
                if (rowIndex % 2 == 0)
                {
                    SecondRow.Add(1);

                    for (var i = 1; i < SecondRow.Count - 1; i++)                   
                        SecondRow[i] = FirstRow[i - 1] + FirstRow[i];
                    
                    if (rowIndex == 0) return SecondRow;
                    
                    FirstRow.Add(1);
                }
                else
                {
                    FirstRow.Add(1);
                    
                    for (int i = 1; i < FirstRow.Count - 1; i++)
                        FirstRow[i] = SecondRow[i - 1] + SecondRow[i];
                    
                    if (rowIndex == 0) return FirstRow;
                    
                    SecondRow.Add(1);
                }
                rowIndex--;
            }   
        }
    }

    public class Test
    {
        public static bool[] TestPascalsTriangleII()
        {
            List<int> listExpected1 = new List<int> { 1, 3, 3, 1 };
            IList<int> expected1 = listExpected1;

            List<int> listExpected2 = new List<int> { 1 };
            IList<int> expected2 = listExpected2;

            List<int> listExpected3 = new List<int> { 1, 1 };
            IList<int> expected3 = listExpected3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.GetRow(3), expected1),
                ResultTester.CheckResult<IList<int>>(Solution.GetRow(0), Solution.GetRow(0)),
                ResultTester.CheckResult<IList<int>>(Solution.GetRow(1), Solution.GetRow(1))
            };
            return results;
        }
    }
}
