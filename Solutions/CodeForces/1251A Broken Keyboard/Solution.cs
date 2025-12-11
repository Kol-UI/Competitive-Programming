// Broken Keyboard
namespace CompetitiveProgramming.CodeForces.BrokenKeyboard;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            string text = Console.ReadLine();
            bool[] found = new bool[26];
            int count = 1;
            
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    count++;
                }
                else
                {
                    found[text[i - 1] - 'a'] = found[text[i - 1] - 'a'] || (count % 2 == 1);
                    count = 1;
                }
            }
            found[text[text.Length - 1] - 'a'] = found[text[text.Length - 1] - 'a'] || (count % 2 == 1);
            
            List<char> result = new List<char>();
            for (int i = 0; i < 26; i++)
            {
                if (found[i]) result.Add((char)('a' + i));
            }
            
            Console.WriteLine(new string(result.ToArray()));
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
        StyleHelper.Title("Broken Keyboard");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}