// Silent Classroom
namespace CompetitiveProgramming.CodeForces.SilentClassroom;
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
        int n = int.Parse(Console.ReadLine());
        int[] frequency = new int[26];
        
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            frequency[s[0] - 'a']++;
        }
        
        long total = 0;
        foreach (int count in frequency)
        {
            int half1 = count / 2;
            int half2 = count - half1;
            total += (long)half1 * (half1 - 1) / 2 + (long)half2 * (half2 - 1) / 2;
        }
        
        Console.WriteLine(total);
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
        StyleHelper.Title("Silent Classroom");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}