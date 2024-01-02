using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.JumpGameIV
{
    // Given an array of integers arr, you are initially positioned at the first index of the array.
    // In one step you can jump from index i to index:
    // i + 1 where: i + 1 < arr.length.
    // i - 1 where: i - 1 >= 0.
    // j where: arr[i] == arr[j] and i != j.
    // Return the minimum number of steps to reach the last index of the array.
    // Notice that you can not jump outside of the array at any time.

    // Example 1:
    // Input: arr = [100,-23,-23,404,100,23,23,23,3,404]
    // Output: 3
    // Explanation: You need three jumps from index 0 --> 4 --> 3 --> 9. Note that index 9 is the last index of the array.
    
    // Example 2:
    // Input: arr = [7]
    // Output: 0
    // Explanation: Start index is the last index. You do not need to jump.
    
    // Example 3:
    // Input: arr = [7,6,9,6,9,6,9,7]
    // Output: 1
    // Explanation: You can jump directly from index 0 to index 7 which is last index of the array.

    public class Solution
    {
        public static int MinJumps(int[] arr) 
        {
            var dic = new Dictionary<int, List<int>>();
            var visited = new bool[arr.Length];
            var queue = new Queue<int>();
            queue.Enqueue(0);
            visited[0] = true;
            var steps = 0;

            for (var i = 0; i < arr.Length; i++) 
            {
                if (!dic.ContainsKey(arr[i]))
                    dic.Add(arr[i], new List<int>());
                dic[arr[i]].Add(i);
            }

            while (queue.Count > 0) 
            {
                var count = queue.Count;
                for (var j = 0; j < count; j++) 
                {
                    var cur = queue.Dequeue();
                    if (cur == arr.Length - 1)
                        return steps;

                    if (cur - 1 >= 0 && !visited[cur - 1])
                    {
                        queue.Enqueue(cur - 1);
                        visited[cur - 1] = true;
                    }

                    if (cur + 1 < arr.Length && !visited[cur + 1])
                    {
                        queue.Enqueue(cur + 1);
                        visited[cur + 1] = true;
                    }

                    if (dic.ContainsKey(arr[cur]))
                    {
                        foreach (var index in dic[arr[cur]])
                        {
                            if (visited[index]) continue;
                            queue.Enqueue(index);
                            visited[index] = true;
                        }
                        dic.Remove(arr[cur]);
                    }
                }
                steps++;  
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestJumpGameIV()
        {
            // Case 1
            int[] arrCase1_1345 = { 100, -23, -23, 404, 100, 23, 23, 23, 3, 404 };
            int resultCase1_1345 = Solution.MinJumps(arrCase1_1345);

            // Case 2
            int[] arrCase2_1345 = { 7 };
            int resultCase2_1345 = Solution.MinJumps(arrCase2_1345);

            // Case 3
            int[] arrCase3_1345 = { 7, 6, 9, 6, 9, 6, 9, 7 };
            int resultCase3_1345 = Solution.MinJumps(arrCase3_1345);

            // Case 4
            int[] arrCase4_1345 = { -1, 100, 100, 100, 100, 100, 100, -1, };
            int resultCase4_1345 = Solution.MinJumps(arrCase4_1345);

            // Case 5
            int[] arrCase5_1345 = RandomGeneraters.GenerateRandomNumber(100, 5);
            int resultCase5_1345 = Solution.MinJumps(arrCase5_1345);

            // Case 6
            int[] arrCase6_1345 = RandomGeneraters.GenerateRandomNumber(1000, 5);
            int resultCase6_1345 = Solution.MinJumps(arrCase6_1345);

            // Case 7
            int[] arrCase7_1345 = RandomGeneraters.GenerateRandomNumber(100, 10);
            int resultCase7_1345 = Solution.MinJumps(arrCase7_1345);

            // Case 8
            int[] arrCase8_1345 = RandomGeneraters.GenerateRandomNumber(1000, 10);
            int resultCase8_1345 = Solution.MinJumps(arrCase8_1345);

            // Case 9
            int[] arrCase9_1345 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int resultCase9_1345 = Solution.MinJumps(arrCase9_1345);

            // Case 10
            int[] arrCase10_1345 = RandomGeneraters.GenerateRandomNegativeNumber(5);
            int resultCase10_1345 = Solution.MinJumps(arrCase10_1345);

            // Case 11
            int[] arrCase11_1345 = RandomGeneraters.GenerateRandomNegativeNumber(10);
            int resultCase11_1345 = Solution.MinJumps(arrCase11_1345);

            // Case 12
            int[] arrCase12_1345 = RandomGeneraters.GenerateRandomNegativePositiveNumber(5);
            int resultCase12_1345 = Solution.MinJumps(arrCase12_1345);

            // Case 13
            int[] arrCase13_1345 = RandomGeneraters.GenerateRandomNegativePositiveNumber(10);
            int resultCase13_1345 = Solution.MinJumps(arrCase13_1345);

            // Case 14
            int[] arrCase14_1345 = arrCase1_1345.Concat(arrCase2_1345).Concat(arrCase3_1345).Concat(arrCase4_1345)
                                                .Concat(arrCase5_1345).Concat(arrCase6_1345).Concat(arrCase7_1345)
                                                .Concat(arrCase8_1345).Concat(arrCase9_1345).Concat(arrCase10_1345)
                                                .Concat(arrCase11_1345).Concat(arrCase12_1345)
                                                .Concat(arrCase13_1345).ToArray();

            int resultCase14_1345 = Solution.MinJumps(arrCase14_1345);

            // Case 15
            int[] arrCase15_1345 = arrCase14_1345;
            int resultCase15_1345 = Solution.MinJumps(arrCase15_1345);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1_1345, 3),
                ResultTester.CheckResult<int>(resultCase2_1345, 0),
                ResultTester.CheckResult<int>(resultCase3_1345, 1),
                ResultTester.CheckResult<int>(resultCase4_1345, resultCase4_1345),
                ResultTester.CheckResult<int>(resultCase5_1345, resultCase5_1345),
                ResultTester.CheckResult<int>(resultCase6_1345, resultCase6_1345),
                ResultTester.CheckResult<int>(resultCase7_1345, resultCase7_1345),
                ResultTester.CheckResult<int>(resultCase8_1345, resultCase8_1345),
                ResultTester.CheckResult<int>(resultCase9_1345, resultCase9_1345),
                ResultTester.CheckResult<int>(resultCase10_1345, resultCase10_1345),
                ResultTester.CheckResult<int>(resultCase11_1345, resultCase11_1345),
                ResultTester.CheckResult<int>(resultCase12_1345, resultCase12_1345),
                ResultTester.CheckResult<int>(resultCase13_1345, resultCase13_1345),
                ResultTester.CheckResult<int>(resultCase14_1345, resultCase14_1345),
                ResultTester.CheckResult<int>(resultCase15_1345, resultCase15_1345),
            };
            return results;
        }
    }
}