// Detective Task
namespace CompetitiveProgramming.CodeForces.DetectiveTask;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            string s = Console.ReadLine()!;
            
            int firstZeroFromEnd = s.Length - 1;
            int lastOneFromStart = 0;
            
            for(int p = 0; p < s.Length; p++)
            {
                if(s[p] == '0' && p < firstZeroFromEnd)
                {
                    firstZeroFromEnd = p;
                }
                else if(s[p] == '1')
                {
                    lastOneFromStart = p;
                }
            }
            
            int result = firstZeroFromEnd - lastOneFromStart + 1;
            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Detective Task");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}