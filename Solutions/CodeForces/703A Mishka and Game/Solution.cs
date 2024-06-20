// 703A - Mishka and Game

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MishkaandGame
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfRounds = ReadInt();
            
            int mishkaWins = 0;
            int chrisWins = 0;

            for (int i = 0; i < numberOfRounds; i++)
            {
                int[] scores = ReadInts();
                int mishkaScore = scores[0];
                int chrisScore = scores[1];

                if (mishkaScore > chrisScore)
                {
                    mishkaWins++;
                }
                else if (chrisScore > mishkaScore)
                {
                    chrisWins++;
                }
            }

            if (mishkaWins > chrisWins)
            {
                Console.WriteLine("Mishka");
            }
            else if (chrisWins > mishkaWins)
            {
                Console.WriteLine("Chris");
            }
            else
            {
                Console.WriteLine("Friendship is magic!^^");
            }
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Mishka and Game");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}