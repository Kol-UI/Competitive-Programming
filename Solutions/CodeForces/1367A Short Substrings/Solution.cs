// Short Substrings

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.ShortSubstrings
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int numberOfTestCases = int.Parse(Console.ReadLine()!);
            
            List<string> results = new List<string>();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                string b = Console.ReadLine()!;
                string a = ReconstructA(b);
                results.Add(a);
            }
            
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static string ReconstructA(string b)
        {
            if (b.Length == 2)
            {
                return b;
            }

            List<char> a = new List<char>();
            a.Add(b[0]);

            for (int i = 1; i < b.Length - 1; i += 2)
            {
                a.Add(b[i]);
            }

            a.Add(b[b.Length - 1]);

            return new string(a.ToArray());
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Short Substrings");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}