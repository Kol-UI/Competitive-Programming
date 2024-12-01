// Quintomania
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#nullable disable
namespace CompetitiveProgramming.CodeForces.Quintomania
{
    using System;
    using System.Linq;

    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine());
            
            for (int tc = 0; tc < t; ++tc)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                if (Solve(a))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        static bool Solve(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int diff = Math.Abs(a[i + 1] - a[i]);
                if (diff != 5 && diff != 7)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Quintomania");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}
#nullable enable