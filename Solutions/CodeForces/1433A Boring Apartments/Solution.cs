// Boring Apartments

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BoringApartments
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();

            List<int> results = new List<int>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int apartment = ReadInt();
                results.Add(CalculateKeyPresses(apartment));
            }

            PrintResults(results);
        }

        private static int CalculateKeyPresses(int apartment)
        {
            int digit = apartment % 10;
            int length = apartment.ToString().Length;

            int totalKeyPresses = 0;

            for (int i = 1; i < digit; i++)
            {
                totalKeyPresses += (1 + 2 + 3 + 4);
            }

            for (int i = 1; i <= length; i++)
            {
                totalKeyPresses += i;
            }

            return totalKeyPresses;
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
            StyleHelper.Title("Boring Apartments");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}