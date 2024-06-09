// Turtle and Piggy Are Playing a Game

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.TurtleandPiggyArePlayingaGame
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
                int[] lr = ReadInts();
                int l = lr[0];
                int r = lr[1];

                int maxScore = (int)Math.Log(r, 2);

                results.Add(maxScore);
            }
            
            PrintResults(results);
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
        private static void PrintResults(List<int> results) => results.ForEach(Console.WriteLine);
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Turtle and Piggy Are Playing a Game");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}