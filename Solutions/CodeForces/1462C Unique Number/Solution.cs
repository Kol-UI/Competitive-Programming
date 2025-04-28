// Unique Number
namespace CompetitiveProgramming.CodeForces.UniqueNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            List<int> v = new List<int>();
            int n = int.Parse(Console.ReadLine()!);
            if (n > 45)
            {
                Console.WriteLine("-1");
                continue;
            }
            for (int i = 9; i > 0; i--)
            {
                if (n <= i)
                {
                    v.Insert(0, n);
                    n = 0;
                    break;
                }
                else
                {
                    v.Insert(0, i);
                    n -= i;
                }
            }
            if (n != 0)
                Console.WriteLine("-1");
            else
            {
                foreach (int num in v)
                    Console.Write(num);
                Console.WriteLine();
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Unique Number");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}