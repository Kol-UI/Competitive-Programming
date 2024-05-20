// Motivation



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.Motivation
{
    public class Test
    {
        //public static void Main()
        public static void Solution()
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int N = int.Parse(input[0]);
                int X = int.Parse(input[1]);

                int best = 0;

                for (int j = 0; j < N; j++)
                {
                    string[] movies = Console.ReadLine()!.Split();
                    int value = int.Parse(movies[0]);
                    int rating = int.Parse(movies[1]);

                    if (value <= X)
                    {
                        best = Math.Max(best, rating);
                    }
                }

                Console.WriteLine(best);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Motivation");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.BeginnerCC);
        }
    }
}