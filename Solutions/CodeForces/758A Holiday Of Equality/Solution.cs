// Holiday Of Equality


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.HolidayOfEquality
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void SolutionMain()
        {
            int n = ReadInt();
            
            int[] welfare = ReadInts();
            
            int maxWelfare = welfare.Max();
            
            int totalBurles = welfare.Sum(w => maxWelfare - w);
            
            Console.WriteLine(totalBurles);
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
    }

    public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Holiday Of Equality");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}
}