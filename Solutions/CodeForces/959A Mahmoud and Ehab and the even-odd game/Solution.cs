// Mahmoud and Ehab and the even-odd game

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MahmoudandEhabandtheevenoddgame
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int n = int.Parse(Console.ReadLine()!);

            if (n % 2 == 0)
                Console.WriteLine("Mahmoud");
            else
                Console.WriteLine("Ehab");
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Mahmoud and Ehab and the even-odd game");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}