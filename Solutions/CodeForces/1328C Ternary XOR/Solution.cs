// Ternary XOR
namespace CompetitiveProgramming.CodeForces.TernaryXOR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            string str = Console.ReadLine()!;
            string a = "", b = "";
            bool found = false;

            for (int i = 0; i < n; i++)
            {
                if (str[i] != '1')
                {
                    if (str[i] == '0')
                    {
                        a += "0";
                        b += "0";
                    }
                    else
                    {
                        if (found)
                        {
                            a += "0";
                            b += "2";
                        }
                        else
                        {
                            a += "1";
                            b += "1";
                        }
                    }
                }
                else
                {
                    if (found)
                    {
                        a += "0";
                        b += "1";
                    }
                    else
                    {
                        a += "1";
                        b += "0";
                        found = true;
                    }
                }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ternary XOR");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}