// Optimal Shifts
namespace CompetitiveProgramming.CodeForces.OptimalShifts;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class HelloWorld
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine()!;
            
            int maxCount = 0;
            int currentCount = 0;
            
            for(int p = 0; p < 2 * s.Length; p++)
            {
                if(s[p % s.Length] == '0')
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 0;
                }
                
                if(currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            
            Console.WriteLine(maxCount);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Optimal Shifts");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}