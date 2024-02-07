// Take Gifts From the Richest Pile


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.TakeGiftsFromtheRichestPile
{
    public class Solution
    {
        public static long PickGifts(int[] gifts, int k)
        {
            var pq = new PriorityQueue<long, long>();
            foreach (var gift in gifts)
                pq.Enqueue(gift, -gift);
            
            long sum = 0;
            while (k != 0)
            {
                var root = (long)Math.Sqrt(pq.Dequeue());
                pq.Enqueue(root, -root);
                k--;
            }
            
            while (pq.Count != 0)
                sum += pq.Dequeue();
            
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.PickGifts(new int[]{25,64,9,4,100}, 4), 29),
                ResultTester.CheckResult<long>(Solution.PickGifts(new int[]{1,1,1,1}, 4), 4),
            };

            return results;
        }
    }
}