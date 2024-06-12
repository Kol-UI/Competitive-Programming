// Choosing Teams

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.ChoosingTeams
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int[] nk = ReadInts();
            int n = nk[0];
            int k = nk[1];
            
            int[] participations = ReadInts();
            
            List<int> eligibleParticipants = new List<int>();
            foreach (int participation in participations)
            {
                if (participation + k <= 5)
                {
                    eligibleParticipants.Add(participation);
                }
            }
            
            int numberOfTeams = eligibleParticipants.Count / 3;
            
            Console.WriteLine(numberOfTeams);
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
            StyleHelper.Title("Choosing Teams");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}