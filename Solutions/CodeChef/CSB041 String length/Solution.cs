// CSB041 String length

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.Stringlength
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            string txt = "NumeroTres";
            Console.Write("The length of the word is: " + txt.Length); 
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("String length");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}