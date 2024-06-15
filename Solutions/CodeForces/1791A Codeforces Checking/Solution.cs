// Codeforces Checking

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.CodeforcesChecking
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            
            List<string> results = new List<string>();
            
            string codeforces = "codeforces";
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                char c = ReadChar();
                if (codeforces.Contains(c))
                {
                    results.Add("YES");
                }
                else
                {
                    results.Add("NO");
                }
            }
            
            PrintResults(results);
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static char ReadChar() => char.Parse(ReadLn());
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Codeforces Checking");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}