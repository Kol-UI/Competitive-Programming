// Very Different Array
namespace CompetitiveProgramming.CodeForces.VeryDifferentArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    static public void Main()
    {
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            var sizes = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = sizes[0];
            long m = sizes[1];
            
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);
            
            long diff = 0;
            long left = 0, right = n - 1;
            long idxL = 0, idxR = m - 1;
            
            while(left <= right)
            {
                long curA = Math.Abs(a[left] - b[idxL]);
                long curB = Math.Abs(a[right] - b[idxR]);
                
                if(curA > curB)
                {
                    diff += curA;
                    left++;
                    idxL++;
                }
                else
                {
                    diff += curB;
                    right--;
                    idxR--;
                }
            }
            
            Console.WriteLine(diff);
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
        StyleHelper.Title("Very Different Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}