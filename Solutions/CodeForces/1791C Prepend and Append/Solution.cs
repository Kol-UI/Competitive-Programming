// Prepend and Append

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.PrependandAppend
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = ReadInt();
            List<int> results = new List<int>();

            while (t-- > 0)
            {
                int n = ReadInt();
                string s = ReadLn();
                int c = 0;
                int j = n - 1;

                for (int i = 0; i < n / 2; i++)
                {
                    if (s[i] == s[j - i])
                        break;
                    if (s[i] != s[j - i])
                        c += 2;
                }

                results.Add(n - c);
            }

            PrintResults(results);
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
            StyleHelper.Title("Prepend and Append");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}