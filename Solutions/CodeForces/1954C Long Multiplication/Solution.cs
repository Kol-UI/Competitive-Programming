// Long Multiplication
namespace CompetitiveProgramming.CodeForces.LongMultiplication;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            char[] a = Console.ReadLine().ToCharArray();
            char[] b = Console.ReadLine().ToCharArray();
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    char temp = a[i];
                    a[i] = b[i];
                    b[i] = temp;
                }
            }
            
            bool first = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    if (first)
                    {
                        if (a[i] < b[i])
                        {
                            char temp = a[i];
                            a[i] = b[i];
                            b[i] = temp;
                        }
                        first = false;
                    }
                    else
                    {
                        if (a[i] > b[i])
                        {
                            char temp = a[i];
                            a[i] = b[i];
                            b[i] = temp;
                        }
                    }
                }
            }
            
            Console.WriteLine(new string(a));
            Console.WriteLine(new string(b));
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Long Multiplication");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}