// ICPC Balloons

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.ICPCBalloons
{
    public class ProblemSolution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            List<int> results = new List<int>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int length = ReadInt();
                string solvedProblems = ReadLn();
                results.Add(CalculateBalloons(solvedProblems));
            }

            PrintResults(results);
        }

        private static int CalculateBalloons(string solvedProblems)
        {
            HashSet<char> solvedSet = new HashSet<char>();
            int balloons = 0;

            foreach (char problem in solvedProblems)
            {
                if (!solvedSet.Contains(problem))
                {
                    balloons += 2;
                    solvedSet.Add(problem);
                }
                else
                {
                    balloons += 1;
                }
            }

            return balloons;
        }
        
        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("ICPC Balloons");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}