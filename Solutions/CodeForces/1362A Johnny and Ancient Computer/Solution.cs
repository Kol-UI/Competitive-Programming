// Johnny and Ancient Computer
namespace CompetitiveProgramming.CodeForces.JohnnyandAncientComputer;
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
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = input[0];
            long b = input[1];
            
            if(a > b)
            {
                long temp = a;
                a = b;
                b = temp;
            }
            
            int count = 0;
            
            while(a < b)
            {
                if(b % 8 == 0 && b / 8 >= a)
                {
                    b /= 8;
                }
                else if(b % 4 == 0 && b / 4 >= a)
                {
                    b /= 4;
                }
                else if(b % 2 == 0 && b / 2 >= a)
                {
                    b /= 2;
                }
                else
                {
                    break;
                }
                count++;
            }
            
            int result = (a == b) ? count : -1;
            Console.WriteLine(result);
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
        StyleHelper.Title("Johnny and Ancient Computer");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}