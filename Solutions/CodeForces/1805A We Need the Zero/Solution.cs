// We Need the Zero
namespace CompetitiveProgramming.CodeForces.WeNeedtheZero;
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
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long xor = 0;
            foreach (long number in numbers)
            {
                xor ^= number;
            }
            
            if (n % 2 == 1)
            {
                Console.WriteLine(xor);
            }
            else
            {
                Console.WriteLine(xor == 0 ? 0 : -1);
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
        StyleHelper.Title("We Need the Zero");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}