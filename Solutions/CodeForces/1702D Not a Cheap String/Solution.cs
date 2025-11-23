// Not a Cheap String
namespace CompetitiveProgramming.CodeForces.NotaCheapString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            string s = Console.ReadLine();
            int target = int.Parse(Console.ReadLine());
            
            int total = s.Sum(c => c - 'a' + 1);
            var sorted = s.Select((c, i) => (c - 'a' + 1, i))
                         .OrderByDescending(x => x.Item1)
                         .ToArray();
            
            bool[] remove = new bool[s.Length];
            for (int i = 0; i < sorted.Length && total > target; i++)
            {
                total -= sorted[i].Item1;
                remove[sorted[i].i] = true;
            }
            
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!remove[i]) result.Append(s[i]);
            }
            
            Console.WriteLine(result);
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
        StyleHelper.Title("Not a Cheap String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}