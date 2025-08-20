// Helmets in Night Light
namespace CompetitiveProgramming.CodeForces.HelmetsinNightLight;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] nr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = nr[0], r = nr[1];
            
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            List<Tuple<long, long>> people = new List<Tuple<long, long>>();
            for (int i = 0; i < n; i++)
            {
                people.Add(new Tuple<long, long>(b[i], a[i]));
            }
            
            people = people.OrderBy(x => x.Item1).ToList();
            
            long cost = r;
            long remaining = n - 1;
            
            for (int i = 0; i < n && remaining > 0; i++)
            {
                long canInform = Math.Min(remaining, people[i].Item2);
                cost += Math.Min(canInform * people[i].Item1, canInform * r);
                remaining -= canInform;
            }
            
            Console.WriteLine(cost);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Helmets in Night Light");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}