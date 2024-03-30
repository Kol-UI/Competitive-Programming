// Minimum Number of Moves to Seat Everyone


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofMovestoSeatEveryone
{
    public class Test
    {
        public class Solution
        {
            public static int MinMovesToSeat(int[] seats, int[] students) 
            {
                Array.Sort(seats);
                Array.Sort(students);
                int result = 0;
                
                for (int i = 0; i < seats.Length; i++)
                {
                    result += (int)(Math.Abs(seats[i] - students[i]));
                }

                return result;
            }
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinMovesToSeat(new int[]{3,1,5}, new int[]{2,7,4}), 4),
                ResultTester.CheckResult<int>(Solution.MinMovesToSeat(new int[]{4,1,5,9}, new int[]{1,3,2,6}), 7),
                ResultTester.CheckResult<int>(Solution.MinMovesToSeat(new int[]{2,2,6,6}, new int[]{1,3,2,6}), 4),
            };
            return results;
        }
    }
}