// Stones on the Table



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.StonesontheTable
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);
            string s = Console.ReadLine()!;
            
            int minRemovals = 0;

            for (int i = 1; i < n; i++)
            {
                if (s[i] == s[i - 1])
                {
                    minRemovals++;
                }
            }

            Console.WriteLine(minRemovals);
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stones on the Table");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}