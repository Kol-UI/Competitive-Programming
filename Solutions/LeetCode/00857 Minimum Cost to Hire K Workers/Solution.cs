// Minimum Cost to Hire K Workers

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumCosttoHireKWorkers
{
    public class Solution
    {
        public static double MincostToHireWorkers(int[] quality, int[] wage, int k)
        {
            var workers = new double[quality.Length][];

            for (var i = 0; i < quality.Length; ++i)
            {
                //workers[i] = [(double)wage[i] / quality[i], quality[i]];
                workers[i] = new double[2];
                workers[i][0] = (double)wage[i] / quality[i];
                workers[i][1] = quality[i];
            }

            Array.Sort(workers, (a, b) => a[0].CompareTo(b[0]));

            var result = double.MaxValue;
            double sum = 0;
            var pq = new PriorityQueue<double, double>();
            
            foreach (var worker in workers)
            {
                sum += worker[1];

                pq.Enqueue(-worker[1], -worker[1]);

                if (pq.Count > k)
                {
                    sum += pq.Dequeue();
                }

                if (pq.Count == k)
                {
                    result = Math.Min(result, sum * worker[0]);
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(Solution.MincostToHireWorkers(new int[]{10,20,5}, new int[]{70,50,30}, 2), 105.00000),
                ResultTester.CheckResult<double>(Solution.MincostToHireWorkers(new int[]{3,1,10,10,1}, new int[]{4,8,2,2,7}, 3), 30.666666666666664),
            };
            return results;
        }
    }
}