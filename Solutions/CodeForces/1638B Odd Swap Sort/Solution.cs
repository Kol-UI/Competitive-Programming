// Odd Swap Sort
namespace CompetitiveProgramming.CodeForces.OddSwapSort;
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
            int n = int.Parse(Console.ReadLine());
            long[] x = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long a = -1, b = -1;
            bool res = true;
            
            foreach(long num in x)
            {
                if(num % 2 == 1)
                {
                    if(a <= num)
                    {
                        a = num;
                    }
                    else
                    {
                        res = false;
                    }
                }
                else
                {
                    if(b <= num)
                    {
                        b = num;
                    }
                    else
                    {
                        res = false;
                    }
                }
            }
            
            Console.WriteLine(res ? "Yes" : "No");
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
        StyleHelper.Title("Odd Swap Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}