// Two Dishes

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.TwoDishes
{
    public class Test
    {
        //public static void Main()
        public static void Solution()
        {
            long t = long.Parse(Console.ReadLine()!);

            while (t-- > 0)
            {
                string[] inputs = Console.ReadLine()!.Split();
                long n = long.Parse(inputs[0]);
                long a = long.Parse(inputs[1]);
                long b = long.Parse(inputs[2]);
                long c = long.Parse(inputs[3]);

                string result = (b >= n && (a + c) >= n) ? "YES" : "NO";
                Console.WriteLine(result);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Dishes");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.BeginnerCC);
        }
    }
}