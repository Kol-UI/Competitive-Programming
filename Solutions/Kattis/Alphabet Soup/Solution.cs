// Alphabet Soup
namespace CompetitiveProgramming.Kattis.AlphabetSoup;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        string input = Console.ReadLine();
        HashSet<char> alphabet = new HashSet<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        HashSet<char> inputSet = new HashSet<char>(input);
        
        alphabet.ExceptWith(inputSet);
        
        if (alphabet.Count == 0)
        {
            Console.WriteLine("Alphabet Soup!");
        }
        else
        {
            char[] sorted = alphabet.OrderBy(c => c).ToArray();
            Console.WriteLine(new string(sorted));
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alphabet Soup");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}