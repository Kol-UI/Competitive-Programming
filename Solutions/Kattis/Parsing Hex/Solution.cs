// Parsing Hex
namespace CompetitiveProgramming.Kattis.ParsingHex;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            for (int i = 0; i < line.Length - 2; )
            {
                if (line[i] == '0' && char.ToLower(line[i + 1]) == 'x')
                {
                    int j;
                    for (j = i + 2; j < line.Length; j++)
                    {
                        char c = line[j];
                        if (!((c >= '0' && c <= '9') ||
                              (c >= 'a' && c <= 'f') ||
                              (c >= 'A' && c <= 'F')))
                            break;
                    }
                    if (j == i + 2)
                    {
                        i += 3;
                        continue;
                    }
                    string hex = line.Substring(i, j - i);
                    long value = long.Parse(hex.Substring(2), NumberStyles.HexNumber);
                    Console.WriteLine($"{hex} {value}");
                    i = j;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Parsing Hex");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}