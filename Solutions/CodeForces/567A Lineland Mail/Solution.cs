// Lineland Mail
namespace CompetitiveProgramming.CodeForces.LinelandMail;
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
        int n = int.Parse(Console.ReadLine()!);
        if (n == 1)
        {
            Console.WriteLine("0 0");
            return;
        }

        List<int> v = new List<int>();
        string[] inputs = Console.ReadLine()!.Split();
        int x = int.Parse(inputs[0]);
        bool ok = false;

        if (x < 0)
        {
            v.Add(0);
            ok = true;
        }
        else
        {
            v.Add(x);
        }

        for (int i = 1; i < n; i++)
        {
            int temp = int.Parse(inputs[i]);
            if (ok)
                v.Add(temp + Math.Abs(x));
            else
                v.Add(temp);
        }

        Console.WriteLine($"{v[1] - v[0]} {v[n-1] - v[0]}");
        
        for (int i = 1; i < n - 1; i++)
        {
            int min = Math.Min(v[i+1] - v[i], v[i] - v[i-1]);
            int max = Math.Max(v[n-1] - v[i], v[i] - v[0]);
            Console.WriteLine($"{min} {max}");
        }

        Console.WriteLine($"{v[n-1] - v[n-2]} {v[n-1] - v[0]}");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lineland Mail");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}