// Divide Array Into Arrays With Max Difference


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DivideArrayIntoArraysWithMaxDifference
{
    public class Solution
    {
        public static int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);
            
            List<List<int>> result = new List<List<int>>();
            List<int> currentArray = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                currentArray.Add(nums[i]);

                if (currentArray.Count == 3 || i == nums.Length - 1)
                {
                    if (IsValidArray(currentArray, k))
                    {
                        result.Add(new List<int>(currentArray));
                        currentArray.Clear();
                    }
                    else
                    {
                        result.Clear();
                        currentArray.Clear();
                        break;
                    }
                }
            }

            if (result.Count == nums.Length / 3)
            {
                return result.Select(arr => arr.ToArray()).ToArray();
            }
            else
            {
                return new int[][]{};
            }
        }
        private static bool IsValidArray(List<int> array, int k)
        {
            return array.Count == 3 && array[2] - array[0] <= k;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 1,1,3 },
                new int[] { 3,4,5 },
                new int[] { 7,8,9 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Solution.DivideArray(new int[]{1,3,4,8,7,9,3,5,1}, 2), matrix1),
                ResultTester.CheckResult<int[][]>(Solution.DivideArray(new int[]{1,3,3,2,7,3}, 3), matrix2),
            };

            return results;
        }
    }
}