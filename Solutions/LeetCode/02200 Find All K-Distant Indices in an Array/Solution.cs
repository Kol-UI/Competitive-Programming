// Find All K-Distant Indices in an Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindAllKDistantIndicesinanArray
{
    public class Solution
    {
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            Queue<int> indices = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key)
                    indices.Enqueue(i);
            }
            indices.Enqueue(int.MaxValue);
            
            List<int> result = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int next = indices.Peek();
                if (next < i - k)
                {
                    indices.Dequeue();
                    next = indices.Peek();
                }
                if (i + k >= next)
                    result.Add(i);
            }

            return result;
        }
    }
}