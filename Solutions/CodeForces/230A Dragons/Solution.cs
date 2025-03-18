// Dragons
namespace CompetitiveProgramming.CodeForces.Dragons;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

public class Program
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split(' ');
        int strength = int.Parse(input[0]);
        int dragon = int.Parse(input[1]);

        bool ok = true;
        List<Tuple<int, int>> v = new List<Tuple<int, int>>(dragon);

        for (int i = 0; i < dragon; i++)
        {
            input = Console.ReadLine()!.Split(' ');
            v.Add(new Tuple<int, int>(int.Parse(input[0]), int.Parse(input[1])));
        }

        v.Sort((x, y) => x.Item1.CompareTo(y.Item1));

        for (int i = 0; i < dragon; i++)
        {
            if (strength > v[i].Item1)
            {
                strength += v[i].Item2;
            }
            else
            {
                ok = false;
                break;
            }
        }

        if (ok)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Dragons");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}