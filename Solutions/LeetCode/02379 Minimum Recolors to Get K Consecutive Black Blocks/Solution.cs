// Minimum Recolors to Get K Consecutive Black Blocks



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumRecolorstoGetKConsecutiveBlackBlocks
{
    public class Solution
    {
        public static int MinimumRecolors(string blocks, int k)
        {
            int minValue = int.MaxValue;
            int counter = 0;

            for(int i = 0; i < blocks.Length; i++)
            {
                if(blocks[i] == 'W') counter++;
                if(i >= k - 1)
                {
                    minValue = Math.Min(minValue, counter);
                    if(blocks[i - k + 1] == 'W')
                    {
                        counter--;
                    }
                } 
            }

            return minValue;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumRecolors("WBBWWBBWBW", 7), 3),
                ResultTester.CheckResult<int>(Solution.MinimumRecolors("WBWBBBW", 2), 0),
            };
            return results;
        }
    }
}