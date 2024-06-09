// Leggja saman



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.Kattis.Leggjasaman
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            int arnarCars = Convert.ToInt32(Console.ReadLine());
            int hannesCars = Convert.ToInt32(Console.ReadLine());

            int totalCars = arnarCars + hannesCars;

            Console.WriteLine(totalCars);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Leggja saman");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
        }
    }
}