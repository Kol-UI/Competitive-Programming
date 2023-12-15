// Number of Flowers in Full Bloom

/*

You are given a 0-indexed 2D integer array flowers, where flowers[i] = [starti, endi] means the ith flower will be in full bloom from starti to endi (inclusive). You are also given a 0-indexed integer array people of size n, where people[i] is the time that the ith person will arrive to see the flowers.

Return an integer array answer of size n, where answer[i] is the number of flowers that are in full bloom when the ith person arrives.

 

Example 1:


Input: flowers = [[1,6],[3,7],[9,12],[4,13]], people = [2,3,7,11]
Output: [1,2,2,2]
Explanation: The figure above shows the times when the flowers are in full bloom and when the people arrive.
For each person, we return the number of flowers in full bloom during their arrival.


Example 2:


Input: flowers = [[1,10],[3,3]], people = [3,3,2]
Output: [2,2,1]
Explanation: The figure above shows the times when the flowers are in full bloom and when the people arrive.
For each person, we return the number of flowers in full bloom during their arrival.

*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofFlowersinFullBloom
{
    public class Solution
    {
        public static int[] FullBloomFlowers(int[][] flowers, int[] people)
        {
            List<int> starts = new List<int>();
            List<int> ends = new List<int>();
            
            foreach (int[] flower in flowers)
            {
                starts.Add(flower[0]);
                ends.Add(flower[1] + 1);
            }
            
            starts.Sort();
            ends.Sort();
            int[] answer = new int[people.Length];
            
            for (int index = 0; index < people.Length; ++index)
            {
                int person = people[index];
                int i = BinarySearch(starts, person);
                int j = BinarySearch(ends, person);
                answer[index] = i - j;
            }
            
            return answer;
        }
        
        public static int BinarySearch(List<int> arr, int target)
        {
            int left = 0;
            int right = arr.Count;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (target < arr[mid])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            
            return left;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] flowers1 = new int[][]
            {
                new int[] { 1, 6 },
                new int[] { 3, 7 },
                new int[] { 9, 12 },
                new int[] { 4, 13 },
            };

            int[] people1 = {2,3,7,11};

            int[] result1 = {1,2,2,2};

            int[][] flowers2 = new int[][]
            {
                new int[] { 1, 10 },
                new int[] { 3, 3 },
            };

            int[] people2 = {3,3,2};

            int[] result2 = {2, 2, 1};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FullBloomFlowers(flowers1, people1), result1),
                ResultTester.CheckResult<int[]>(Solution.FullBloomFlowers(flowers2, people2), result2),
            };
            return results;
        }
    }
}