// Maximum Profit in Job Scheduling



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumProfitinJobScheduling
{
    public class Solution
    {
        public static int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            int n = startTime.Length;
            List<Job> jobs = new List<Job>();
            
            for (int i = 0; i < n; i++)
            {
                jobs.Add(new Job(startTime[i], endTime[i], profit[i]));
            }
            
            jobs.Sort((x, y) => x.EndTime.CompareTo(y.EndTime));
            
            int[] dp = new int[n + 1];
            
            for (int i = 1; i <= n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], jobs[i - 1].Profit);
                for (int j = i - 1; j > 0; j--)
                {
                    if (jobs[i - 1].StartTime >= jobs[j - 1].EndTime)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + jobs[i - 1].Profit);
                        break;
                    }
                }
            }
            
            return dp[n];
        }
    }

    public class Job
    {
        public int StartTime;
        public int EndTime;
        public int Profit;
        
        public Job(int start, int end, int prof)
        {
            StartTime = start;
            EndTime = end;
            Profit = prof;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.JobScheduling(new int[] {1,2,3,3}, new int[] {3,4,5,6}, new int[] {50,10,40,70}), 120),
                ResultTester.CheckResult<int>(Solution.JobScheduling(new int[] {1,2,3,4,6}, new int[] {3,5,10,6,9}, new int[] {20,20,100,70,60}), 150),
                ResultTester.CheckResult<int>(Solution.JobScheduling(new int[] {1,1,1}, new int[] {2,3,4}, new int[] {5,6,4}), 6),
            };
            return results;
        }
    }
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("1235");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}