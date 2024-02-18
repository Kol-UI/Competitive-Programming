// Again Twenty Five

using System;
using System.Numerics;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.AgainTwentyFive
{
    class Program
    {
        public static string Solution(int n)
        {
            double value = Math.Pow(5, n);
            double result = value % 100;
            return result.ToString();
        }
    }

    /*
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Solution(n));
        }

        public static string Solution(int n)
        {
            return "25";
        }
    }
    */

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Program.Solution(2), "25"),
                ResultTester.CheckResult<string>(Program.Solution(7), "25"),
            };
            return results;
        }
    }
}