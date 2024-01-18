// Determine the Winner of a Bowling Game



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DeterminetheWinnerofaBowlingGame
{
    public class Solution
    {
        public static int IsWinner(int[] player1, int[] player2)
        {
            var score1 = CalculateScore(player1);
            var score2 = CalculateScore(player2);

            if (score1 == score2)
            {
                return 0;
            }
            
            return score1 > score2 ? 1 : 2;
        }

        private static int CalculateScore(int[] pins)
        {
            var result = 0;

            for (var i = 0; i < pins.Length; i++)
            {
                var multiplier = GetMultiplier(pins, i);
                result += multiplier * pins[i];
            }

            return result;
        }

        private static int GetMultiplier(int[] pins, int index)
        {
            return index switch
            {
                0 => 1,
                1 => pins[index - 1] == 10 ? 2 : 1,
                _ => pins[index - 1] == 10 || pins[index - 2] == 10 ? 2 : 1
            };
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.IsWinner(new int[]{4,10,7,9}, new int[]{6,5,2,3}), 1),
                ResultTester.CheckResult<int>(Solution.IsWinner(new int[]{3,5,7,6}, new int[]{8,10,10,2}), 2),
                ResultTester.CheckResult<int>(Solution.IsWinner(new int[]{2,3}, new int[]{4,1}), 0),
            };
            return results;
        }
    }
}