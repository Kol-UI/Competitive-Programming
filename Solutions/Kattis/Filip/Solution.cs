// Filip
namespace CompetitiveProgramming.Kattis.Filip;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string a = input[0];
        string b = input[1];
        
        char[] aArr = a.ToCharArray();
        char[] bArr = b.ToCharArray();
        
        Array.Reverse(aArr);
        Array.Reverse(bArr);
        
        string reversedA = new string(aArr);
        string reversedB = new string(bArr);
        
        if (string.Compare(reversedA, reversedB) < 0)
        {
            Console.WriteLine(reversedB);
        }
        else
        {
            Console.WriteLine(reversedA);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Filip");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}