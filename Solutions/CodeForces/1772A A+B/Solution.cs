// A+B?

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.APlusB
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = ReadInt();
            List<int> results = new List<int>();

            for (int i = 0; i < t; i++)
            {
                string expression = ReadLn();
                int result = EvaluateExpression(expression);
                results.Add(result);
            }

            PrintResults(results);
        }

        private static int EvaluateExpression(string expression)
        {
            string[] parts = expression.Split('+');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            return a + b;
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
            StyleHelper.Title("A+B?");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}