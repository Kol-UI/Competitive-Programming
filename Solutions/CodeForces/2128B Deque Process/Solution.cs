// Deque Process
namespace CompetitiveProgramming.CodeForces.DequeProcess;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Text;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] v = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            StringBuilder result = new StringBuilder();
            
            for(int p = 0; p < n / 2; p++)
            {
                bool condition = (p % 2 == 0) == (v[p] < v[n - 1 - p]);
                result.Append(condition ? "LR" : "RL");
            }
            
            if(n % 2 == 1) result.Append("L");
            
            Console.WriteLine(result.ToString());
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
        StyleHelper.Title("Deque Process");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}