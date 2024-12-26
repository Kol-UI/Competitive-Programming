// Shy Geek

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.ShyGeek
{
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shy Geek");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG);
        }
    }
}