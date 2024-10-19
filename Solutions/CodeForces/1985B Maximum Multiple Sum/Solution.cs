// Maximum Multiple Sum

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MaximumMultipleSum
{
    class Program
    {
        static void ProblemSolution()
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int testCase = 0; testCase < t; testCase++)
            {
                int n = int.Parse(Console.ReadLine()!);
                int optimal = 2;
                int optimalSum = 0;

                for (int x = 2; x <= n; x++)
                {
                    int sumMultiples = SumMultiplesOf(x, n);
                    if (sumMultiples > optimalSum)
                    {
                        optimal = x;
                        optimalSum = sumMultiples;
                    }
                }

                Console.WriteLine(optimal);
            }
        }

        static int SumMultiplesOf(int x, int n)
        {
            int sumMultiples = 0;
            int i = 1;
            while (x * i <= n)
            {
                sumMultiples += x * i;
                i++;
            }
            return sumMultiples;
        }

        /*
        static void Main(string[] args)
        {
            ProblemSolution();
        }
        */
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Multiple Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }

}