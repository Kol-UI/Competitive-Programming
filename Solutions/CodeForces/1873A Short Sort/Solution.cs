// Short Sort

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.ShortSort
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine()!;
                
                if (s == "abc" || s == "acb" || s == "bac" || s == "cba")
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Short Sort");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}