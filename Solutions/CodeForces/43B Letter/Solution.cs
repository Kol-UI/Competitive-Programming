// Letter
namespace CompetitiveProgramming.CodeForces.Letter;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

public class Solution
{
    static public void Main()
    {
        const int N = 26;
        int[] small = new int[N];
        int[] large = new int[N];
        
        string input = Console.ReadLine()!;
        foreach(char c in input)
        {
            if(c >= 'a' && c <= 'z') small[c - 'a']++;
            if(c >= 'A' && c <= 'Z') large[c - 'A']++;
        }
        
        string message = Console.ReadLine()!;
        foreach(char c in message)
        {
            if(c >= 'a' && c <= 'z') small[c - 'a']--;
            if(c >= 'A' && c <= 'Z') large[c - 'A']--;
        }
        
        string output = "YES";
        for(int k = 0; k < N; k++)
        {
            if(small[k] < 0 || large[k] < 0)
            {
                output = "NO";
                break;
            }
        }
        
        Console.WriteLine(output);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Letter");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}