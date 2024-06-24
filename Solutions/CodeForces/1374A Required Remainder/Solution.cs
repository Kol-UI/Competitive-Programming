// Required Remainder

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.RequiredRemainder
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            List<long> results = new List<long>();

            for (int i = 0; i < t; i++)
            {
                string[] inputs = Console.ReadLine()!.Split();
                long x = long.Parse(inputs[0]);
                long y = long.Parse(inputs[1]);
                long n = long.Parse(inputs[2]);

                long result = FindMaxK(x, y, n);
                results.Add(result);
            }

            foreach (long result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static long FindMaxK(long x, long y, long n)
        {
            long k = n - n % x + y;
            if (k <= n)
            {
                return k;
            }
            else
            {
                return n - n % x - (x - y);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Required Remainder");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}