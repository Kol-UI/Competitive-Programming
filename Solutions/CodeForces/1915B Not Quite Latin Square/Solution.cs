// Not Quite Latin Square
#nullable disable
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.NotQuiteLatinSquare
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        //public static void Main()
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int a = 0, b = 0, c = 0;
                for (int i = 0; i < 3; i++)
                {
                    string line = Console.ReadLine();
                    for (int j = 0; j < 3; j++)
                    {
                        char ans = line[j];
                        if (ans == 'A')
                        {
                            a++;
                        }
                        else if (ans == 'B')
                        {
                            b++;
                        }
                        else if (ans == 'C')
                        {
                            c++;
                        }
                    }
                }

                if (a == b)
                    Console.WriteLine("C");
                else if (b == c)
                    Console.WriteLine("A");
                else
                    Console.WriteLine("B");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Not Quite Latin Square");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}
#nullable enable