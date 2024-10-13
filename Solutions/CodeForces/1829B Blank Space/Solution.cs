// Blank Space

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BlankSpace
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            List<int> results = new List<int>();

            for (int t = 0; t < numberOfTestCases; t++)
            {
                int n = ReadInt();
                int[] a = ReadInts();
                
                int ans = 0;
                int count = 0;
                
                for (int i = 0; i < n; i++)
                {
                    if (a[i] == 0)
                    {
                        count++;
                    }
                    else
                    {
                        ans = Math.Max(count, ans);
                        count = 0;
                    }
                }
                
                results.Add(Math.Max(count, ans));
            }

            PrintResults(results);
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Blank Space");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}