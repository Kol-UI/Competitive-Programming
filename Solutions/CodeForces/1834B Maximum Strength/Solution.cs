// Maximum Strength
namespace CompetitiveProgramming.CodeForces.MaximumStrength;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            string a = input[0];
            string b = input[1];
            
            long diff = a.Length - b.Length;
            if (diff > 0)
            {
                b = new string('0', (int)diff) + b;
            }
            else if (diff < 0)
            {
                a = new string('0', (int)(-diff)) + a;
            }
            
            long cnt = 0;
            for (long p = 0; p < a.Length; p++)
            {
                int dist = a[(int)p] - b[(int)p];
                if (dist == 0) continue;
                
                cnt = (dist > 0) ? dist : -dist;
                cnt += 9 * (a.Length - 1 - p);
                break;
            }
            
            Console.WriteLine(cnt);
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
        StyleHelper.Title("Maximum Strength");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}