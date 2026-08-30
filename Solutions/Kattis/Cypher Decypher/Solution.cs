// Cypher Decypher
namespace CompetitiveProgramming.Kattis.CypherDecypher;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine() ?? "";
        int numLines = int.Parse(Console.ReadLine() ?? "0");

        for (int line = 0; line < numLines; line++)
        {
            string lineInput = Console.ReadLine() ?? "";

            for (int i = 0; i < lineInput.Length; i++)
            {
                char c = lineInput[i];
                int o = c - 'A';
                o *= s[i] - '0';
                o %= 26;
                Console.Write((char)(o + 'A'));
            }

            Console.WriteLine();
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cypher Decypher");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}