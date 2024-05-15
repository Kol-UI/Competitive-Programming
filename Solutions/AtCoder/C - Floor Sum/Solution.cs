using System;
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.AtCoder.CFloorSum
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number of test cases
            int T = int.Parse(Console.ReadLine());

            for (int t = 0; t < T; t++)
            {
                // Read N, M, A, B for each test case
                string[] input = Console.ReadLine().Split();
                long N = long.Parse(input[0]);
                long M = long.Parse(input[1]);
                long A = long.Parse(input[2]);
                long B = long.Parse(input[3]);

                long sum = 0;

                // Calculate the sum for the current test case
                sum = (N * (N - 1) / 2) * (A / M) + (N * B / M);

                // Print the result for the current test case
                Console.WriteLine(sum);
            }
        }
    }
    */

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Floor Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder, ProblemCategory.BeginnerAC);
        }
    }
}