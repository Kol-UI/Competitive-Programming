// Thermostat
namespace CompetitiveProgramming.CodeForces.Thermostat;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int l = input[0];
            int r = input[1];
            int x = input[2];
            
            var points = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = points[0];
            int b = points[1];
            
            if(a == b)
            {
                Console.WriteLine("0");
            }
            else if(a >= b + x || b >= a + x)
            {
                Console.WriteLine("1");
            }
            else if(a >= l + x && b >= l + x)
            {
                Console.WriteLine("2");
            }
            else if(r >= a + x && r >= b + x)
            {
                Console.WriteLine("2");
            }
            else if(a >= l + x && r >= b + x)
            {
                Console.WriteLine("3");
            }
            else if(r >= a + x && b >= l + x)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("-1");
            }
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
        StyleHelper.Title("Thermostat");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}