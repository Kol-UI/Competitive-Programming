// Binary Removals
namespace CompetitiveProgramming.CodeForces.BinaryRemovals;
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
            string s = Console.ReadLine();
            int zeroPair = -1;
            int onePair = -1;
            
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == '0' && s[i] == '0') zeroPair = i;
                if (s[i - 1] == '1' && s[i] == '1' && onePair < 0) onePair = i;
            }
            
            bool valid = !(zeroPair > 0 && onePair > 0 && zeroPair > onePair);
            Console.WriteLine(valid ? "YES" : "NO");
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
        StyleHelper.Title("Binary Removals");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}