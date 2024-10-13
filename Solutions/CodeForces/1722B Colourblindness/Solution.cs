// Colourblindness

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Colourblindness
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();

            List<string> results = new List<string>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                long n = ReadLong();
                string color1 = ReadLn();
                string color2 = ReadLn();

                long ans = 0;
                for (int j = 0; j < color1.Length; j++)
                {
                    if (color1[j] == color2[j] || 
                        (color1[j] == 'B' && color2[j] == 'G') || 
                        (color1[j] == 'G' && color2[j] == 'B'))
                    {
                        ans++;
                    }
                }

                if (ans == color1.Length)
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
        private static long ReadLong() => long.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Colourblindness");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }

}