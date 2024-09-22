// Minutes Before the New Year

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MinutesBeforetheNewYear
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void ProblemSolution()
        {
            int t = ReadInt();
            List<int> results = new List<int>();
            
            for (int i = 0; i < t; i++)
            {
                int[] time = ReadInts();
                int minutesBeforeNewYear = CalculateMinutesBeforeNewYear(time[0], time[1]);
                results.Add(minutesBeforeNewYear);
            }
            
            PrintResults(results);
        }

        private static int CalculateMinutesBeforeNewYear(int hours, int minutes)
        {
            int totalMinutesInDay = 24 * 60;
            int currentMinutes = ConvertToMinutes(hours, minutes);
            return totalMinutesInDay - currentMinutes;
        }

        private static int ConvertToMinutes(int hours, int minutes)
        {
            return hours * 60 + minutes;
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
            StyleHelper.Title("Minutes Before the New Year");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}