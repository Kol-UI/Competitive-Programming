// Balanced Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BalancedArray
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = ReadInt();
            
            List<string> results = new List<string>();
            
            for (int i = 0; i < t; i++)
            {
                int n = ReadInt();
                if (n % 4 != 0)
                {
                    results.Add("NO");
                }
                else
                {
                    results.Add("YES");
                    List<int> array = new List<int>();
                    
                    for (int j = 1; j <= n / 2; j++)
                    {
                        array.Add(j * 2);
                    }
                    
                    for (int j = 1; j < n / 2; j++)
                    {
                        array.Add(j * 2 - 1);
                    }
                    
                    array.Add(n + n / 2 - 1);
                    
                    results.Add(string.Join(" ", array));
                }
            }
            
            PrintResults(results);
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static void PrintResults(List<string> results)
        {
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Balanced Array");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}