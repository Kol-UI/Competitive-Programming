using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SortanArray
{
    public class Solution
	{
        // Given an array of integers nums, sort the array in ascending order and return it.
        // You must solve the problem without using any built-in functions in O(nlog(n)) time complexity and with the smallest space complexity possible.

        // Example 1:
        // Input: nums = [5,2,3,1]
        // Output: [1,2,3,5]
        // Explanation: After sorting the array, the positions of some numbers are not changed (for example, 2 and 3), while the positions of other numbers are changed (for example, 1 and 5).
        
        // Example 2:
        // Input: nums = [5,1,1,2,0,0]
        // Output: [0,0,1,1,2,5]
        // Explanation: Note that the values of nums are not necessairly unique.
        
        public static int[] SortArray(int[] nums)
        {
            PriorityQueue<int,int> _sort = new PriorityQueue<int,int>();
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                _sort.Enqueue(nums[i], nums[i]);
            }
            for (int j = 0; j <nums.Length; j++)
            {
                result[j]= _sort.Dequeue();
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestSortanArray()
        {
            System.Random random = new System.Random();

            int[] expected1 = {1,2,3,5};
            int[] expected2 = {0,0,1,1,2,5};

            // Case 1
            int[] case1_912 = { 5, 2, 3, 1 };
            int[] result1_912 = Solution.SortArray(case1_912);

            // Case 2
            int[] case2_912 = { 1, 2, 3, 5 };
            int[] result2_912 = Solution.SortArray(case2_912);

            // Case 3
            int[] case3_912 = { 5, 1, 1, 2, 0, 0 };
            int[] result3_912 = Solution.SortArray(case3_912);

            // Case 4
            int[] case4_912 = { 0, 0, 1, 1, 2, 5 };
            int[] result4_912 = Solution.SortArray(case4_912);

            // Case 5
            int[] case5_912 = { 7, 1, 2, 3 };
            int[] result5_912 = Solution.SortArray(case5_912);

            // Case 6
            int[] case6_912 = { 9, 7, 6, 2, 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            int[] result6_912 = Solution.SortArray(case6_912);

            // Case 7
            int[] case7_912 = { 82, 4, 3, 1, 3, 3, 7, 7, 10, 11, 11 };
            int[] result7_912 = Solution.SortArray(case7_912);

            // Case 8
            int[] case8_912 = { 7, -1, 1, 2, 3 };
            int[] result8_912 = Solution.SortArray(case8_912);

            // Case 9
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
            int d = random.Next(1, 10);
            int e = random.Next(1, 10);
            int[] case9_912 = { a, b, c, d, e };
            int[] result9_912 = Solution.SortArray(case9_912);

            // Case 10
            int[] case10_912 = { 3, 2, 8, 2, 6 };
            int[] result10_912 = Solution.SortArray(case10_912);

            // Case 11
            int[] case11_912 = { a+b, b+c, c+d, d+e, e+a };
            int[] result11_912 = Solution.SortArray(case11_912);

            // Case 12
            int[] case12_912 = { 14, 10, 3, 2, 7 };
            int[] result12_912 = Solution.SortArray(case12_912);

            // Case 13
            int[] case13_912 = { 6, 8, 2, 1, 1 };
            int[] result13_912 = Solution.SortArray(case13_912);

            // Case 14
            int[] case14_912 = { a+b+c, b+c+d, c+d+e, d+e+a, e+a+b };
            int[] result14_912 = Solution.SortArray(case14_912);

            // Case 15
            int[] case15_912 = { 24, 24, 22, 21, 23 };
            int[] result15_912 = Solution.SortArray(case15_912);

            // Case 16
            int[] case16_912 = { a+b+c+d, b+c+d+e, c+d+e+a, d+e+a+b, e+a+b+c };
            int[] result16_912 = Solution.SortArray(case16_912);

            // Case 17
            int f = random.Next(-10, 0);
            int g = random.Next(-10, 0);
            int h = random.Next(-10, 0);
            int i = random.Next(-10, 0);
            int j = random.Next(-10, 0);
            int[] case17_912 = { f, g, h, i, j };
            int[] result17_912 = Solution.SortArray(case17_912);

            // Case 18
            int[] case18_912 = { -9, -6, -6, -6, -1 };
            int[] result18_912 = Solution.SortArray(case18_912);

            // Case 19
            int[] case19_912 = { a+f, b+g, c+h, d+i, e+j };
            int[] result19_912 = Solution.SortArray(case19_912);

            // Case 20
            int[] case20_912 = case1_912.Concat(case2_912).Concat(case3_912).Concat(case4_912)
                                        .Concat(case5_912).Concat(case6_912).Concat(case7_912)
                                        .Concat(case8_912).Concat(case9_912).Concat(case10_912)
                                        .Concat(case11_912).Concat(case12_912).Concat(case13_912)
                                        .Concat(case14_912).Concat(case15_912).Concat(case16_912)
                                        .Concat(case17_912).Concat(case18_912).Concat(case19_912).ToArray();
            int[] result20_912 = Solution.SortArray(case20_912);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1_912, expected1),
                ResultTester.CheckResult<int[]>(result2_912, result2_912),
                ResultTester.CheckResult<int[]>(result3_912, expected2),
                ResultTester.CheckResult<int[]>(result4_912, result4_912),
                ResultTester.CheckResult<int[]>(result5_912, result5_912),
                ResultTester.CheckResult<int[]>(result6_912, result6_912),
                ResultTester.CheckResult<int[]>(result7_912, result7_912),
                ResultTester.CheckResult<int[]>(result8_912, result8_912),
                ResultTester.CheckResult<int[]>(result9_912, result9_912),
                ResultTester.CheckResult<int[]>(result10_912, result10_912),
                ResultTester.CheckResult<int[]>(result11_912, result11_912),
                ResultTester.CheckResult<int[]>(result12_912, result12_912),
                ResultTester.CheckResult<int[]>(result13_912, result13_912),
                ResultTester.CheckResult<int[]>(result14_912, result14_912),
                ResultTester.CheckResult<int[]>(result15_912, result15_912),
                ResultTester.CheckResult<int[]>(result16_912, result16_912),
                ResultTester.CheckResult<int[]>(result17_912, result17_912),
                ResultTester.CheckResult<int[]>(result18_912, result18_912),
                ResultTester.CheckResult<int[]>(result19_912, result19_912),
                ResultTester.CheckResult<int[]>(result20_912, result20_912),
            };

            return results;
        }
    }
}

