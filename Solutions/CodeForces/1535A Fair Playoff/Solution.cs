// Fair Playoff

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.FairPlayoff;

public class Solution
{
    //public static void Main(string[] args)
    public static void ProblemSolution()
    {
        int numberOfTestCases = ReadInt();
        List<string> results = new List<string>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            int[] skills = ReadInts();
            string result = IsFairTournament(skills) ? "YES" : "NO";
            results.Add(result);
        }

        PrintResults(results);
    }

    private static bool IsFairTournament(int[] skills)
    {
        int semiFinal1Max = Math.Max(skills[0], skills[1]);
        int semiFinal2Max = Math.Max(skills[2], skills[3]);

        int[] topTwoSkills = skills.OrderByDescending(s => s).Take(2).ToArray();

        return topTwoSkills.Contains(semiFinal1Max) && topTwoSkills.Contains(semiFinal2Max);
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
        StyleHelper.Title("Fair Playoff");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}