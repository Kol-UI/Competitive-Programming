// Is he gonna survive?


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.Ishegonnasurvive
{
    class Kata
    {   
        public static bool Hero(int bullets, int dragons)
        {
            return bullets >= dragons * 2;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Kata.Hero(10, 5), true),
                ResultTester.CheckResult<bool>(Kata.Hero(1500, 751), false),
                ResultTester.CheckResult<bool>(Kata.Hero(0, 1), false),
                ResultTester.CheckResult<bool>(Kata.Hero(7, 4), false),
            };
            return results;
        }
    }
}