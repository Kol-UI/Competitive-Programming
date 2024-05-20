// String Datatype


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.StringDatatype
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            string a = "Code";
            string b = "Chef";
            Console.Write(a);
            Console.Write(b);
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Datatype");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}