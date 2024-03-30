// Binary Watch


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryWatch
{
    public class Solution 
    {
        public static IList<string> ReadBinaryWatch(int turnedOn) 
        {
            var res = new List<string>();

            for (var minute = 0; minute < 60; minute++)
                for (var hour = 0; hour < 12; hour++)
                    if (CountBits(minute) + CountBits(hour) == turnedOn)
                        res.Add($"{hour}:{minute:D2}");

            return res;

            static int CountBits(int num)
            {
                var count = 0;
                while (num != 0)
                {
                    num &= num - 1;
                    count++;
                }
                return count;
            }
        }
    }
}