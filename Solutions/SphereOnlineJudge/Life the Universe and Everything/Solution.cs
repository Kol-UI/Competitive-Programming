// Life the Universe and Everything


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.SphereOnlineJudge.LifetheUniverseandEverything
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int number = int.Parse(Console.ReadLine()!);
            
            while (number != 42)
            {
                Console.WriteLine(number);

                number = int.Parse(Console.ReadLine()!);
            }
        }
    }
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Life the Universe and Everything");
            ResultTester.SpecialTestCase(ProblemOrigin.SphereOnlineJudge, ProblemCategory.OtherSOJ);
        }
    }
}