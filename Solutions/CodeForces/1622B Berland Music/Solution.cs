// Berland Music
namespace CompetitiveProgramming.CodeForces.BerlandMusic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        const long multiplier = 10000000;
        
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            string s = Console.ReadLine();
            
            var items = numbers.Select((value, index) => new 
            { 
                OriginalValue = value,
                Index = index,
                ModifiedValue = value + multiplier * (s[index] - '0')
            }).ToArray();
            
            var sorted = items.OrderBy(x => x.ModifiedValue).ToArray();
            long[] result = new long[n];
            
            for (int i = 0; i < n; i++)
            {
                result[sorted[i].Index] = i + 1;
            }
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Berland Music");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}