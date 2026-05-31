// T9 Spelling
namespace CompetitiveProgramming.Kattis.T9Spelling;
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
        int times = int.Parse(Console.ReadLine());
        List<string> chars = new List<string>
        {
            "2", "22", "222",
            "3", "33", "333",
            "4", "44", "444",
            "5", "55", "555",
            "6", "66", "666",
            "7", "77", "777", "7777",
            "8", "88", "888",
            "9", "99", "999", "9999",
            "0"
        };
        
        for (int i = 0; i < times; i++)
        {
            string line = Console.ReadLine();
            Console.Write($"Case #{i + 1}: ");
            int prev = 0;
            
            foreach (char c in line)
            {
                if (c != ' ')
                {
                    int idx = c - 'a';
                    if (idx >= 0 && idx < chars.Count && prev < chars.Count)
                    {
                        if (chars[prev][0] == chars[idx][0])
                        {
                            Console.Write(" ");
                        }
                        Console.Write(chars[idx]);
                        prev = idx;
                    }
                }
                else
                {
                    if (prev == 26)
                    {
                        Console.Write(" 0");
                    }
                    else
                    {
                        Console.Write("0");
                        prev = 26;
                    }
                }
            }
            Console.WriteLine();
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
        StyleHelper.Title("T9 Spelling");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}