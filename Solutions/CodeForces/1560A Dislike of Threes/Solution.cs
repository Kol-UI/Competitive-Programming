// Dislike of Threes

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.DislikeofThrees
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            
            List<int> results = new List<int>();

            List<int> testCases = new List<int>();
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int k = ReadInt();
                testCases.Add(k);
            }

            int maxK = testCases.Max();

            List<int> sequence = GenerateSequence(maxK);

            foreach (int k in testCases)
            {
                results.Add(sequence[k - 1]);
            }
            
            PrintResults(results);
        }

        private static List<int> GenerateSequence(int maxK)
        {
            List<int> sequence = new List<int>();
            int number = 1;
            while (sequence.Count < maxK)
            {
                if (number % 3 != 0 && number % 10 != 3)
                {
                    sequence.Add(number);
                }
                number++;
            }
            return sequence;
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
            StyleHelper.Title("Dislike of Threes");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}