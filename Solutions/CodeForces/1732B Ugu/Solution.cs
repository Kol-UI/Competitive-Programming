// Ugu
namespace CompetitiveProgramming.CodeForces.Ugu;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            long result = -1;
            for (int position = 0; position < s.Length; position++)
            {
                bool condition = (position == 0 && s[position] == '1') || 
                                (position > 0 && s[position] != s[position - 1]);
                if (condition) result++;
            }
            
            Console.WriteLine(result > 0 ? result : 0);
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
        StyleHelper.Title("Ugu");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}