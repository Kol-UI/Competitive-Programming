// Birthday Cake Candles



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.BirthdayCakeCandles
{
    class Result
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int count = candles.Count(x => x == max);
            return count;
        }
    }
}