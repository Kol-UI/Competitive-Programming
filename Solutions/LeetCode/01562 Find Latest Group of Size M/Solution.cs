// Find Latest Group of Size M

/*
Given an array arr that represents a permutation of numbers from 1 to n.

You have a binary string of size n that initially has all its bits set to zero. At each step i (assuming both the binary string and arr are 1-indexed) from 1 to n, the bit at position arr[i] is set to 1.

You are also given an integer m. Find the latest step at which there exists a group of ones of length m. A group of ones is a contiguous substring of 1's such that it cannot be extended in either direction.

Return the latest step at which there exists a group of ones of length exactly m. If no such group exists, return -1.

 

Example 1:

Input: arr = [3,5,1,2,4], m = 1
Output: 4
Explanation: 
Step 1: "00100", groups: ["1"]
Step 2: "00101", groups: ["1", "1"]
Step 3: "10101", groups: ["1", "1", "1"]
Step 4: "11101", groups: ["111", "1"]
Step 5: "11111", groups: ["11111"]
The latest step at which there exists a group of size 1 is step 4.


Example 2:

Input: arr = [3,1,5,4,2], m = 2
Output: -1
Explanation: 
Step 1: "00100", groups: ["1"]
Step 2: "10100", groups: ["1", "1"]
Step 3: "10101", groups: ["1", "1", "1"]
Step 4: "10111", groups: ["1", "111"]
Step 5: "11111", groups: ["11111"]
No group of size 2 exists during any step.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindLatestGroupofSizeM
{
    public class Solution
    {
        static int[]? parent;
        static int[]? sz;
        static int groupCount = 0;

        public static int FindLatestStep(int[] arr, int m)
        {
            var n = arr.Length;
            parent = new int[n + 1];
            sz = new int[n + 1];
            var res = -1;

            for (var i = 0; i < n; i++)
            {
                var ind = arr[i];
                parent[ind] = ind;
                sz[ind] = 1;

                if (m == 1) groupCount++;

                if (ind > 1 && parent[ind - 1] != 0)
                {
                    Union(ind, ind - 1, m);
                }

                if (ind < n && parent[ind + 1] != 0)
                {
                    Union(ind, ind + 1, m);
                }

                if (groupCount > 0) res = i + 1;
            }

            return res;
        }

        private static int Find(int a)
        {
            if (parent is not null)
            {
                while (parent[a] != a)
                {
                    a = parent[a];
                    parent[a] = parent[parent[a]];
                }
            }
            return a;
        }

        private static void Union(int a, int b, int m)
        {
            var root_a = Find(a);
            var root_b = Find(b);
            
            if (root_a == root_b) return;

            if (sz![root_a] == m) groupCount--;
            if (sz[root_b] == m) groupCount--;

            if (sz[root_a] < sz[root_b])
            {
                parent![root_a] = root_b;
                sz[root_b] += sz[root_a];
                if (sz[root_b] == m) groupCount++;
            }
            else
            {
                parent![root_b] = root_a;
                sz[root_a] += sz[root_b];
                if (sz[root_a] == m) groupCount++;
            }
        }

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] arr1 = {3,5,1,2,4};
            int m1 = 1;
            int[] arr2 = {3,1,5,4,2};
            int m2 = 2;

            int result1 = Solution.FindLatestStep(arr1, m1);
            int result2 = Solution.FindLatestStep(arr2, m2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, -1)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find Latest Group of Size");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}