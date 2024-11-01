// My First Sorting Problem
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MyFirstSortingProblem
{
    public class MyFirstSortingProblem
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            long testCases = long.Parse(Console.ReadLine()!);

            while (testCases-- > 0)
            {
                string[] inputs = Console.ReadLine()!.Split();
                long a = long.Parse(inputs[0]);
                long b = long.Parse(inputs[1]);
                
                Console.WriteLine($"{Math.Min(a, b)} {Math.Max(a, b)}");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("My First Sorting Problem");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}