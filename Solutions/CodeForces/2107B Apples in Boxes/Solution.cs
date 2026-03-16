// Apples in Boxes
namespace CompetitiveProgramming.CodeForces.ApplesinBoxes;
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
            long n = input[0];
            long k = input[1];
            
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long minValue = 1000000007;
            long maxValue = 0;
            int maxCount = 0;
            long sumParity = 0;
            
            foreach(long x in numbers)
            {
                sumParity = (sumParity + x) % 2;
                
                if(x > maxValue)
                {
                    maxValue = x;
                    maxCount = 1;
                }
                else if(x == maxValue)
                {
                    maxCount++;
                }
                
                if(x < minValue) minValue = x;
            }
            
            bool condition1 = maxValue > minValue + k + 1;
            bool condition2 = maxValue == minValue + k + 1 && maxCount > 1;
            
            if(condition1 || condition2)
            {
                Console.WriteLine("Jerry");
            }
            else
            {
                Console.WriteLine(sumParity == 1 ? "Tom" : "Jerry");
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
        StyleHelper.Title("Apples in Boxes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}