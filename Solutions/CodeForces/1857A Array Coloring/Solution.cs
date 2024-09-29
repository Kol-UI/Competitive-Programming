// Array Coloring

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.ArrayColoring
{
    public class Solution
    {
        //public static void Main()
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            
            while (t-- > 0)
            {
                Console.WriteLine(Solve());
            }
        }

        public static string Solve()
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            int sum = a.Sum();
            
            return (sum % 2 != 0) ? "NO" : "YES";
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Array Coloring");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}