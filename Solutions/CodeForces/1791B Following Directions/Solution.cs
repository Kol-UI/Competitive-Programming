// Following Directions

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.FollowingDirections
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = ReadInt();
            var results = new List<string>();

            for (int i = 0; i < t; i++)
            {
                int n = ReadInt();
                string s = ReadLn();
                results.Add(HasReachedTarget(s, n) ? "YES" : "NO");
            }

            PrintResults(results);
        }

        private static bool HasReachedTarget(string s, int n)
        {
            int x = 0, y = 0;
            foreach (char direction in s)
            {
                switch (direction)
                {
                    case 'U': y++; break;
                    case 'D': y--; break;
                    case 'R': x++; break;
                    case 'L': x--; break;
                }
                if (x == 1 && y == 1) return true;
            }
            return false;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Following Directions");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}