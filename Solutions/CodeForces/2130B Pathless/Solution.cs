// Pathless
namespace CompetitiveProgramming.CodeForces.Pathless;
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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int zeroCount = 0, oneCount = 0, twoCount = 0, total = 0;
            
            foreach(int x in values)
            {
                if(x == 0) zeroCount++;
                else if(x == 1) oneCount++;
                else twoCount++;
                total += x;
            }
            
            if(total == s || total + 2 <= s)
            {
                Console.WriteLine("-1");
                continue;
            }
            
            StringBuilder result = new StringBuilder();
            
            while(zeroCount-- > 0) result.Append("0 ");
            while(twoCount-- > 0) result.Append("2 ");
            while(oneCount-- > 0) result.Append("1 ");
            
            Console.WriteLine(result.ToString().Trim());
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
        StyleHelper.Title("Pathless");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}