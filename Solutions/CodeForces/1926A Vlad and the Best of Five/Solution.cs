// Vlad and the Best of Five

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.VladandtheBestofFive
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            List<char> results = new List<char>();

            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine()!;
                results.Add(FindMostFrequentCharacter(s));
            }

            foreach (char result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static char FindMostFrequentCharacter(string s)
        {
            int countA = 0;
            int countB = 0;

            foreach (char c in s)
            {
                if (c == 'A') countA++;
                else if (c == 'B') countB++;
            }

            return countA >= countB ? 'A' : 'B';
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Vlad and the Best of Five");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}