// Inserting text Between Outputs




using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.InsertingtextBetweenOutputs
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            Console.Write((3 + 4) + " and " + (2 + 1));
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Inserting text between outputs");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}