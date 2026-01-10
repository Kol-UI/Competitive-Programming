// Toggle String
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.ToggleString
{
    class Program
    {
        //static void Main()
        static void MainSolution()
        {
            string input = Console.ReadLine()!;
            string result = string.Empty;

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else
                {
                    result += char.ToUpper(c);
                }
            }

            Console.WriteLine(result);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Toggle String");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}