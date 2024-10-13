// Night at the Museum

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.NightattheMuseum
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            string s = ReadLn();
            char prev = 'a';
            int r = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char curr = s[i];
                int right = Math.Abs(curr - prev);
                int left = Math.Abs(Math.Abs(curr - prev) - 26);
                r += Math.Min(right, left);
                prev = curr;
            }

            Console.WriteLine(r);
        }

        private static string ReadLn() => Console.ReadLine()!;
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Night at the Museum");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}