// Again Twenty Five

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.AgainTwentyFive
{
    class Program
    {
        //static void Main()
        public static void Problem()
        {
            int n = int.Parse(Console.ReadLine()!);
            string result = Solution(n);

            Console.WriteLine(result);
        }

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
            int n = int.Parse(Console.ReadLine());
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