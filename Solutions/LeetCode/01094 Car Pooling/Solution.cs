// Car Pooling

/*
There is a car with capacity empty seats. The vehicle only drives east (i.e., it cannot turn around and drive west).

You are given the integer capacity and an array trips where trips[i] = [numPassengersi, fromi, toi] indicates that the ith trip has numPassengersi passengers and the locations to pick them up and drop them off are fromi and toi respectively. The locations are given as the number of kilometers due east from the car's initial location.

Return true if it is possible to pick up and drop off all passengers for all the given trips, or false otherwise.


Example 1:

Input: trips = [[2,1,5],[3,3,7]], capacity = 4
Output: false

Example 2:

Input: trips = [[2,1,5],[3,3,7]], capacity = 5
Output: true
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CarPooling
{
    public class Solution
    {
        public static bool CarPooling(int[][] trips, int capacity)
        {
            return trips
                .Select(x => new []
                {
                    (x[1], x[0]),
                    (x[2], -x[0])
                })
                .SelectMany(x => x)
                .OrderBy(x => x.Item1)
                .ThenBy(x => x.Item2)
                .TakeWhile(x => (capacity -= x.Item2) >= 0)
                .Count() == trips.Length * 2;
        }
    }

    public class Test
    {
        public static bool[] TestCarPooling()
        {
            bool expected1 = false;

            bool expected2 = true;

            int[][] trips1 = new int[][]
            {
                new int[] {2, 1, 5},
                new int[] {3, 3, 7}
            };

            int capacity1 = 4;

            int[][] trips2 = new int[][]
            {
                new int[] {2, 1, 5},
                new int[] {3, 3, 7}
            };

            int capacity2 = 5;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CarPooling(trips1, capacity1), expected1),
                ResultTester.CheckResult<bool>(Solution.CarPooling(trips2, capacity2), expected2)
            };
            
            return results;
        }
    }
}