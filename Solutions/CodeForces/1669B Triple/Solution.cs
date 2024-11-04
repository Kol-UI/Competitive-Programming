// Triple

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Triple
{
    public class Solution
    {
        //public static void Main()
        public static void SolutionMain()
        {
            int t = ReadInt();
            List<int> results = new List<int>();

            for (int i = 0; i < t; i++)
            {
                int n = ReadInt();
                int[] array = ReadInts();
                results.Add(FindTriple(array));
            }

            PrintResults(results);
        }

        private static int FindTriple(int[] array)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                    if (counts[num] == 3)
                    {
                        return num;
                    }
                }
                else
                {
                    counts[num] = 1;
                }
            }

            return -1;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class SolutionTest
    {
        public int[] TestFindTriple(int t, List<(int n, int[] array)> testCases)
        {
            int[] results = new int[t];

            for (int i = 0; i < t; i++)
            {
                results[i] = FindTriple(testCases[i].array);
            }

            return results;
        }

        private static int FindTriple(int[] array)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                    if (counts[num] == 3)
                    {
                        return num;
                    }
                }
                else
                {
                    counts[num] = 1;
                }
            }

            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            SolutionTest solution = new();
            int t = 2;
            var testCases = new List<(int n, int[] array)>
            {
                (5, new int[] {1, 2, 3, 1, 1}),
                (4, new int[] {1, 2, 3, 4})
            };
            int[] expectedResults = {1, -1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(solution.TestFindTriple(t, testCases), expectedResults),
                ResultTester.CheckResult<int[]>(solution.TestFindTriple(t, testCases), expectedResults)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Triple");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
        }
    }
}