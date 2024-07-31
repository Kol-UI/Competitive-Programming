
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.CatchtheCoin
{
    public class Program
    {
        //public static void Main()
        public static void MainSolution()
        {
            int testCases = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < testCases; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                long x = long.Parse(input[0]);
                long y = long.Parse(input[1]);

                Console.WriteLine(y >= -1 ? "YES" : "NO");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Catch the Coin");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}