// Robot Program
namespace CompetitiveProgramming.CodeForces.RobotProgram;
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
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0];
            long x = input[1];
            long k = input[2];
            
            string s = Console.ReadLine()!;
            
            long remainingK = k;
            long currentX = x;
            
            for(long p = 0; p < s.Length && currentX != 0 && remainingK > 0; p++)
            {
                if(s[(int)p] == 'L') currentX--;
                else if(s[(int)p] == 'R') currentX++;
                remainingK--;
            }
            
            if(currentX != 0)
            {
                Console.WriteLine("0");
                continue;
            }
            
            long result = 1;
            currentX = 0;
            
            for(int p = 0; p < n; p++)
            {
                if(s[p] == 'L') currentX--;
                else if(s[p] == 'R') currentX++;
                
                if(currentX == 0)
                {
                    result += remainingK / (p + 1);
                    break;
                }
            }
            
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
        StyleHelper.Title("Robot Program");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}