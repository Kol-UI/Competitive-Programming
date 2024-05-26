// LOL Lovers


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.LOLLovers
{

    class Program
    {
        //static void Main()
        static void Solution()
        {
            int t = 1;

            while (t-- > 0)
            {
                SolveCase();
            }
        }

        static void SolveCase()
        {
            int n;
            string s;

            n = int.Parse(Console.ReadLine()!);
            s = Console.ReadLine()!;

            int countL = 0, countO = 0, netL = 0, netO = 0;

            foreach (char c in s)
            {
                if (c == 'L')
                    netL++;
                else
                    netO++;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (s[i] == 'L')
                    countL++;
                else
                    countO++;

                if (countL != netL - countL && countO != netO - countO)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("LOL Lovers");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}