// Divan and a New Project
namespace CompetitiveProgramming.CodeForces.DivanandaNewProject;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            var sorted = numbers.Select((value, index) => (value, index + 1))
                              .OrderByDescending(x => x.value)
                              .ToArray();
            
            long total = 0;
            long[] positions = new long[n + 1];
            
            for (int i = 0; i < n; i++)
            {
                long distance = i / 2 + 1;
                total += 2 * sorted[i].value * distance;
                long position = i % 2 == 0 ? distance : -distance;
                positions[sorted[i].Item2] = position;
            }
            
            Console.WriteLine(total);
            Console.WriteLine(string.Join(" ", positions));
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
        StyleHelper.Title("Divan and a New Project");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}