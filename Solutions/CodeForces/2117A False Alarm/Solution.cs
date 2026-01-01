// False Alarm
namespace CompetitiveProgramming.CodeForces.FalseAlarm;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0];
            long x = input[1];
            
            long firstIndex = -1;
            bool possible = true;
            
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < n; i++)
            {
                if (firstIndex < 0 && numbers[i] == 1)
                {
                    firstIndex = i;
                }
                if (numbers[i] == 1 && firstIndex + x <= i)
                {
                    possible = false;
                }
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("False Alarm");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}