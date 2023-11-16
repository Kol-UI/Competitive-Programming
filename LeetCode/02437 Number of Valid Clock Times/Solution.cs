// Number of Valid Clock Times

/*
You are given a string of length 5 called time, representing the current time on a digital clock in the format "hh:mm". The earliest possible time is "00:00" and the latest possible time is "23:59".

In the string time, the digits represented by the ? symbol are unknown, and must be replaced with a digit from 0 to 9.

Return an integer answer, the number of valid clock times that can be created by replacing every ? with a digit from 0 to 9.

 

Example 1:

Input: time = "?5:00"
Output: 2
Explanation: We can replace the ? with either a 0 or 1, producing "05:00" or "15:00". Note that we cannot replace it with a 2, since the time "25:00" is invalid. In total, we have two choices.

Example 2:

Input: time = "0?:0?"
Output: 100
Explanation: Each ? can be replaced by any digit from 0 to 9, so we have 100 total choices.

Example 3:

Input: time = "??:??"
Output: 1440
Explanation: There are 24 possible choices for the hours, and 60 possible choices for the minutes. In total, we have 24 * 60 = 1440 choices.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofValidClockTimes
{
    public class Solution
    {
        public static int CountTime(string time) 
        {
            var ret = 0;

            for(int i = 0; i < 5; i++)
            {
                if (time[i] == '?')
                {
                    var x = 1;
                    switch(i)
                    {
                        case 0: 
                            if (time[1] == '?')
                            {
                                x = 3;
                            }
                            else
                            {
                                x = int.Parse(time[1].ToString()) > 3 ? 2 : 3;
                            }
                            break;
                            
                        case 1:
                            if (time[0] == '?')
                            {
                                x = 8;
                            }
                            else
                            {
                                x = int.Parse(time[0].ToString()) < 2 ? 10 : 4;
                            }
                            break;
                        
                        case 3: x = 6; break;
                        case 4: x = 10; break;
                    }

                    if (ret == 0)
                    {
                        ret = x;
                    } 
                    else
                    {
                        ret *= x;
                    }
                        
                }
            }
                

            return ret == 0 ? 1 : ret;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountTime("?5:00"), 2),
                ResultTester.CheckResult<int>(Solution.CountTime("0?:0?"), 100),
                ResultTester.CheckResult<int>(Solution.CountTime("??:??"), 1440),
            };
            return results;
        }
    }
}