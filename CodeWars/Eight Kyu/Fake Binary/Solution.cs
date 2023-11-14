// Fake Binary


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.FakeBinary
{
    public class Kata
    {
        public static string FakeBin(string x)
        {
            char[] result = new char[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                int digit = int.Parse(x[i].ToString());

                result[i] = (digit < 5) ? '0' : '1';
            }

            return new string(result);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Kata.FakeBin("45385593107843568"), "01011110001100111"),
                ResultTester.CheckResult<string>(Kata.FakeBin("509321967506747"), "101000111101101"),
                ResultTester.CheckResult<string>(Kata.FakeBin("366058562030849490134388085"), "011011110000101010000011011"),
            };
            return results;
        }
    }
}