// Diagonal Traverse II

/*
Given a 2D integer array nums, return all elements of nums in diagonal order as shown in the below images.

 

Example 1:


Input: nums = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,4,2,7,5,3,8,6,9]


Example 2:


Input: nums = [[1,2,3,4,5],[6,7],[8],[9,10,11],[12,13,14,15,16]]
Output: [1,6,2,8,7,3,9,4,12,10,5,13,11,14,15,16]
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DiagonalTraverseII
{
    public class Solution
    {
        public static int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            var diagonals = new Dictionary<int, Queue<int>>();
            var length = 0;
            
            for (int row = nums.Count - 1; row >= 0; row--)
            {
                for (int column = 0; column < nums[row].Count; column++)
                {
                    var diagonal = row + column;
                    if (!diagonals.ContainsKey(diagonal))
                    {
                        diagonals[diagonal] = new Queue<int>();
                    }
                    
                    diagonals[diagonal].Enqueue(nums[row][column]);
                    length++;
                }
            }

            var currentDiagonal = 0;
            var iteration = 0;
            var result = new int[length];
            
            while (diagonals.ContainsKey(currentDiagonal))
            {
                foreach (var value in diagonals[currentDiagonal])
                {
                    result[iteration] = value;
                    iteration++;
                }

                currentDiagonal++;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IList<IList<int>> nums1 = new List<IList<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 },
                new List<int> { 7, 8, 9 }
            };

            int[] expectedOutput1 = new int[] { 1, 4, 2, 7, 5, 3, 8, 6, 9 };

            IList<IList<int>> nums2 = new List<IList<int>>
            {
                new List<int> { 1, 2, 3, 4, 5 },
                new List<int> { 6, 7 },
                new List<int> { 8 },
                new List<int> { 9, 10, 11 },
                new List<int> { 12, 13, 14, 15, 16 }
            };

            int[] expectedOutput2 = new int[] { 1, 6, 2, 8, 7, 3, 9, 4, 12, 10, 5, 13, 11, 14, 15, 16 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FindDiagonalOrder(nums1), expectedOutput1),
                ResultTester.CheckResult<int[]>(Solution.FindDiagonalOrder(nums2), expectedOutput2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Diagonal Traverse II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}