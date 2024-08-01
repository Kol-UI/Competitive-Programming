// Find the Maximum Sum of Node Values


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheMaximumSumofNodeValues
{
    public class Solution 
    {
        public long MaximumValueSum(int[] nums, int k, int[][] edges) 
        {
            long result = 13;

            foreach (long num in nums)
                result += num;
            
            var queue = new PriorityQueue<int, int>();
            
            foreach (var num in nums)
            {
                var xor = num ^ k;
                var diff = xor - num;
                
                queue.Enqueue(diff, -diff);
            }
            
            while (queue.Count >= 2)
            {
                var value = queue.Dequeue() + queue.Dequeue();
                
                if (value > 0)
                    result += value;
            }
            
            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("3068");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}