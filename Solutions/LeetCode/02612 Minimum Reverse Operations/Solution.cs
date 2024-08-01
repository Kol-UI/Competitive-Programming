// Minimum Reverse Operations

/*
You are given an integer n and an integer p in the range [0, n - 1]. Representing a 0-indexed array arr of length n where all positions are set to 0's, except position p which is set to 1.

You are also given an integer array banned containing some positions from the array. For the ith position in banned, arr[banned[i]] = 0, and banned[i] != p.

You can perform multiple operations on arr. In an operation, you can choose a subarray with size k and reverse the subarray. However, the 1 in arr should never go to any of the positions in banned. In other words, after each operation arr[banned[i]] remains 0.

Return an array ans where for each i from [0, n - 1], ans[i] is the minimum number of reverse operations needed to bring the 1 to position i in arr, or -1 if it is impossible.

A subarray is a contiguous non-empty sequence of elements within an array.
The values of ans[i] are independent for all i's.
The reverse of an array is an array containing the values in reverse order.
 

Example 1:
Input: n = 4, p = 0, banned = [1,2], k = 4
Output: [0,-1,-1,1]
Explanation: In this case k = 4 so there is only one possible reverse operation we can perform, which is reversing the whole array. Initially, 1 is placed at position 0 so the amount of operations we need for position 0 is 0. We can never place a 1 on the banned positions, so the answer for positions 1 and 2 is -1. Finally, with one reverse operation we can bring the 1 to index 3, so the answer for position 3 is 1. 

Example 2:
Input: n = 5, p = 0, banned = [2,4], k = 3
Output: [0,-1,-1,-1,-1]
Explanation: In this case the 1 is initially at position 0, so the answer for that position is 0. We can perform reverse operations of size 3. The 1 is currently located at position 0, so we need to reverse the subarray [0, 2] for it to leave that position, but reversing that subarray makes position 2 have a 1, which shouldn't happen. So, we can't move the 1 from position 0, making the result for all the other positions -1. 

Example 3:
Input: n = 4, p = 2, banned = [0,1,3], k = 1
Output: [-1,-1,0,-1]
Explanation: In this case we can only perform reverse operations of size 1. So the 1 never changes its position.
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumReverseOperations
{
    public class Solution
    {
        public static int[] MinReverseOperations(int n, int p, int[] banned, int k)
        {
            var bs = new HashSet<int>(banned) { p };
            SortedSet<int>[] choice =
            {
                new(Enumerable.Range(0, n).Where(i => i % 2 == 0).Except(bs)),
                new(Enumerable.Range(0, n).Where(i => i % 2 == 1).Except(bs))
            };

            IEnumerable<int> Rotate(int pos)
            {
                var l = Math.Max(pos - k + 1, 0) * 2 + k - 1 - pos;
                var r = Math.Min(pos + 1, n - k + 1) * 2 + k - 1 - pos;
                var currChoice = choice[l % 2];
                var result = currChoice.GetViewBetween(l, r - 1).ToList();
                foreach (var i in result)
                {
                    currChoice.Remove(i);
                }
                return result;
            }

            var bfs = new List<int> { p };
            var visited = new Dictionary<int, int> { { p, 0 } };

            for (var i = 0; i < bfs.Count; i++)
            {
                var vi = visited[bfs[i]] + 1;

                foreach (var j in Rotate(bfs[i]).Where(j => !visited.ContainsKey(j)))
                {
                    visited[j] = vi;
                    bfs.Add(j);
                }
            }

            var result = Enumerable.Repeat(-1, n).ToArray();
            
            foreach (var pair in visited)
            {
                result[pair.Key] = pair.Value;
            }
            return result;
        }
    }


    public class Test
    {
        public static bool[] TestCase()
        {
            // Case 1
            int n_2612_1 = 4;
            int p_2612_1 = 0;
            int[] banned_2612_1 = {1,2};
            int k_2612_1 = 4;
            int[] result2612_1 = Solution.MinReverseOperations(n_2612_1, p_2612_1, banned_2612_1, k_2612_1);

            // Case 2
            int n_2612_2 = 5;
            int p_2612_2 = 0;
            int[] banned_2612_2 = {2,4};
            int k_2612_2 = 3;
            int[] result2612_2 = Solution.MinReverseOperations(n_2612_2, p_2612_2, banned_2612_2, k_2612_2);

            // Case 3
            int n_2612_3 = 4;
            int p_2612_3 = 2;
            int[] banned_2612_3 = {0,1,3};
            int k_2612_3 = 1;
            int[] result2612_3 = Solution.MinReverseOperations(n_2612_3, p_2612_3, banned_2612_3, k_2612_3);

            int[] output1_2612 = {0,-1,-1,1};
            int[] output2_2612 = {0,-1,-1,-1,-1};
            int[] output3_2612 = {-1,-1,0,-1};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result2612_1, output1_2612),
                ResultTester.CheckResult<int[]>(result2612_2, output2_2612),
                ResultTester.CheckResult<int[]>(result2612_3, output3_2612)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Reverse Operations");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCase());
        }
    }
}