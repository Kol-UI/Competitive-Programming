// Strange Splitting

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.StrangeSplitting
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
                int n = ReadInt();
                int[] a = ReadInts();
                
                if (a[0] == a[n - 1])
                {
                    results.Add("NO");
                }
                else
                {
                    results.Add("YES");
                    char[] color = new char[n];
                    color[0] = 'R';
                    color[1] = 'B';
                    
                    for (int j = 2; j < n; j++)
                    {
                        color[j] = 'R';
                    }
                    
                    results.Add(new string(color));
                }
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
            StyleHelper.Title("Strange Splitting");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}