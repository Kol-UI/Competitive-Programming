using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CapacityToShipPackagesWithinDDays
{
    // A conveyor belt has packages that must be shipped from one port to another within days days.
    // The ith package on the conveyor belt has a weight of weights[i]. Each day, we load the ship with packages on the conveyor belt (in the order given by weights).
    // We may not load more weight than the maximum weight capacity of the ship.
    // Return the least weight capacity of the ship that will result in all the packages on the conveyor belt being shipped within days days.

    // Example 1:

    // Input: weights = [1,2,3,4,5,6,7,8,9,10], days = 5
    // Output: 15
    // Explanation: A ship capacity of 15 is the minimum to ship all the packages in 5 days like this:
    // 1st day: 1, 2, 3, 4, 5
    // 2nd day: 6, 7
    // 3rd day: 8
    // 4th day: 9
    // 5th day: 10
    // Note that the cargo must be shipped in the order given, so using a ship of capacity 14 and splitting the packages into parts like (2, 3, 4, 5), (1, 6, 7), (8), (9), (10) is not allowed.
    
    // Example 2:

    // Input: weights = [3,2,2,4,1,4], days = 3
    // Output: 6
    // Explanation: A ship capacity of 6 is the minimum to ship all the packages in 3 days like this:
    // 1st day: 3, 2
    // 2nd day: 2, 4
    // 3rd day: 1, 4
    
    // Example 3:

    // Input: weights = [1,2,3,1,1], days = 4
    // Output: 3
    // Explanation:
    // 1st day: 1
    // 2nd day: 2
    // 3rd day: 3
    // 4th day: 1, 1

    public class Solution
    {
        public static int ShipWithinDays(int[] weights, int days)
        {
            var maxLoad = 0;
            var totalLoad = 0;

            for (var i = 0; i < weights.Length; i++)
            {
                maxLoad = Math.Max(maxLoad, weights[i]);
                totalLoad += weights[i];
            }

            var left = maxLoad;
            var right = totalLoad;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (CanBeShipped(weights, days, mid))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private static bool CanBeShipped(int[] weights, int days, int capacity)
        {
            var sum = 0;
            var count = 1;

            for (var i = 0; i < weights.Length; i++)
            {
                if (sum + weights[i] > capacity)
                {
                    sum = 0;
                    count++;
                }

                sum += weights[i];
            }

            return count <= days;
        }
    }

    public class Test
    {
        public static bool[] TestCapacityToShipPackagesWithinDDays()
        {
            System.Random random = new System.Random();

            // Case 1
            int[] weightsCase1_1011 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int daysCase1_1011 = 5;
            int resultCase1_1011 = Solution.ShipWithinDays(weightsCase1_1011, daysCase1_1011);

            // Case 2
            int[] weightsCase2_1011 = { 3, 2, 2, 4, 1, 4 };
            int daysCase2_1011 = 3;
            int resultCase2_1011 = Solution.ShipWithinDays(weightsCase2_1011, daysCase2_1011);

            // Case 3
            int[] weightsCase3_1011 = { 1, 2, 3, 1, 1 };
            int daysCase3_1011 = 4;
            int resultCase3_1011 = Solution.ShipWithinDays(weightsCase3_1011, daysCase3_1011);

            // Case 4
            int value1_1011 = random.Next(1, 10);
            int value2_1011 = random.Next(1, 10);
            int value3_1011 = random.Next(1, 10);
            int value4_1011 = random.Next(1, 10);
            int value5_1011 = random.Next(1, 10);
            int[] weightsCase4_1011 = { value1_1011, value2_1011, value3_1011, value4_1011, value5_1011 };
            int daysCase4_1011 = random.Next(1, 10);
            int resultCase4_1011 = Solution.ShipWithinDays(weightsCase4_1011, daysCase4_1011);

            // Case 5
            int value6_1011 = random.Next(1, 10);
            int value7_1011 = random.Next(1, 10);
            int value8_1011 = random.Next(1, 10);
            int value9_1011 = random.Next(1, 10);
            int value10_1011 = random.Next(1, 10);
            int[] weightsCase5_1011 = { value6_1011, value7_1011, value8_1011, value9_1011, value10_1011 };
            int daysCase5_1011 = random.Next(1, 10);
            int resultCase5_1011 = Solution.ShipWithinDays(weightsCase5_1011, daysCase5_1011);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1_1011, 15),
                ResultTester.CheckResult<int>(resultCase2_1011, 6),
                ResultTester.CheckResult<int>(resultCase3_1011, 3),
                ResultTester.CheckResult<int>(resultCase4_1011, resultCase4_1011),
                ResultTester.CheckResult<int>(resultCase5_1011, resultCase5_1011),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Capacity To Ship Packages Within D Days");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCapacityToShipPackagesWithinDDays());
        }
    }
}