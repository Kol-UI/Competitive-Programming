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
}
