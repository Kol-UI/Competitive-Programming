// Sum of the Others
namespace CompetitiveProgramming.Kattis.SumoftheOthers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int[] xs = line.Split().Select(int.Parse).ToArray();
            int s = xs.Sum();
            
            foreach (int x in xs)
            {
                if (s - x == x)
                {
                    Console.WriteLine(x);
                    break;
                }
            }
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of the Others");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}