// Good Number
namespace CompetitiveProgramming.CodeForces.GoodNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static bool CheckGoodNumber(long input, int k)
    {
        bool[] digits = new bool[10];
        while(input > 0)
        {
            digits[input % 10] = true;
            input /= 10;
        }
        
        for(int d = 0; d <= k; d++)
        {
            if(!digits[d]) return false;
        }
        return true;
    }
    
    static public void Main()
    {
        var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = firstLine[0];
        int k = firstLine[1];
        
        long count = 0;
        for(int p = 0; p < n; p++)
        {
            long temp = long.Parse(Console.ReadLine());
            if(CheckGoodNumber(temp, k)) count++;
        }
        
        Console.WriteLine(count);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Good Number");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}