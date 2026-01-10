// Palindrome Split
namespace CompetitiveProgramming.HackerEarth.PalindromeSplit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    static public void Main()
    {
        String line = Console.ReadLine();
        int T = Convert.ToInt32(line);
        
        for(int t = 0; t < T; t++)
        {
            string s = Console.ReadLine();
            int result = 0;
            int[] freq = new int[26];
            
            foreach(char c in s)
            {
                freq[c - 'a']++;
            }
            
            for(int i = 0; i < 26; i++)
            {
                result += freq[i] / 2;
            }
            
            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Palindrome Split");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
    }
}