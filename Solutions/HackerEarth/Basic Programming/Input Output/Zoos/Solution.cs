// Zoos

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.HackerEarth.Zoos;

class Zoos
{
    //static void Main()
    static void MainSolution()
    {
        string input = Console.ReadLine() ?? string.Empty;
        int countZ = 0, countO = 0;

        foreach (char c in input)
        {
            if (c == 'z') countZ++;
            else if (c == 'o') countO++;
        }

        if (countO == 2 * countZ)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Zoos");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}