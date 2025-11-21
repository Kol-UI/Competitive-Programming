// Little Artem
namespace CompetitiveProgramming.CodeForces.LittleArtem;
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
            long[] dimensions = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long rows = dimensions[0];
            long cols = dimensions[1];
            
            for (long row = 0; row < rows; row++)
            {
                for (long col = 0; col < cols; col++)
                {
                    char cell = (row + col == 0) ? 'W' : 'B';
                    Console.Write(cell);
                }
                Console.WriteLine();
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
        StyleHelper.Title("Little Artem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}