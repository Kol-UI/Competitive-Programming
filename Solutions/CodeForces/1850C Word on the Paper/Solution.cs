// Word on the Paper
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.WordonthePaper
{
    public class WordOnThePaper
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int testCases = int.Parse(Console.ReadLine()!);

            while (testCases-- > 0)
            {
                string result = "";
                for (int i = 0; i < 8; i++)
                {
                    string s = Console.ReadLine()!;
                    for (int j = 0; j < 8; j++)
                    {
                        if (char.IsLetter(s[j]))
                        {
                            result += s[j];
                        }
                    }
                }
                Console.WriteLine(result);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word on the Paper");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}