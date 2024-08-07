using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumTimetoCompleteTrips
{
    // You are given an array time where time[i] denotes the time taken by the ith bus to complete one trip.

    // Each bus can make multiple trips successively; that is, the next trip can start immediately after completing the current trip. Also, each bus operates independently; that is, the trips of one bus do not influence the trips of any other bus.

    // You are also given an integer totalTrips, which denotes the number of trips all buses should make in total. Return the minimum time required for all buses to complete at least totalTrips trips.

    

    // Example 1:

    // Input: time = [1,2,3], totalTrips = 5
    // Output: 3
    // Explanation:
    // - At time t = 1, the number of trips completed by each bus are [1,0,0]. 
    // The total number of trips completed is 1 + 0 + 0 = 1.
    // - At time t = 2, the number of trips completed by each bus are [2,1,0]. 
    // The total number of trips completed is 2 + 1 + 0 = 3.
    // - At time t = 3, the number of trips completed by each bus are [3,1,1]. 
    // The total number of trips completed is 3 + 1 + 1 = 5.
    // So the minimum time needed for all buses to complete at least 5 trips is 3.
    // Example 2:

    // Input: time = [2], totalTrips = 1
    // Output: 2
    // Explanation:
    // There is only one bus, and it will complete its first trip at t = 2.
    // So the minimum time needed to complete 1 trip is 2.
    public class Solution
    {
        public static long MinimumTime(int[] time, int totalTrips)
        {
            var left = 1L;
            var right = long.MaxValue;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                var trips = 0L;
                
                foreach (var t in time)
                {
                    trips += mid / t;
                    if (trips >= totalTrips)
                    {
                        break;
                    }
                }

                if (trips >= totalTrips)
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
            // Case 1
            int[] time1_1287 = {1, 2, 3};
            int totalTrips1_1287 = 5;
            long result1_1287 = Solution.MinimumTime(time1_1287, totalTrips1_1287);

            // Case 2
            int[] time2_1287 = { 2 };
            int totalTrips2_1287 = 1;
            long result2_1287 = Solution.MinimumTime(time2_1287, totalTrips2_1287);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(result1_1287, 3),
                ResultTester.CheckResult<long>(result2_1287, 2)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Time to Complete Trips");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}