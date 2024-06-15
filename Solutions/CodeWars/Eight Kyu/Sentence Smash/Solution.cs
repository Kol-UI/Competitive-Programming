//Sentence Smash

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.SentenceSmash
{
    public class Kata
    {
        public static string Smash(string[] words)
        {
            return words.Length >= 1 ? string.Join(" ", words) : "";
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sentence Smash");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars, ProblemCategory.EightKyu);
        }
    }
}