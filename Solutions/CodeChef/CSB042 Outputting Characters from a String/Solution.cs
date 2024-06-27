// CSB042 Outputting Characters from a String

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.OutputtingCharactersfromaString
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            string word = "Programming";
            Console.WriteLine(word[2]);
            Console.Write(word[4]);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Outputting Characters from a String");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}