// Romaji
namespace CompetitiveProgramming.CodeForces.Romaji;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static bool IsVowel(char character)
    {
        return character == 'a' || character == 'o' || character == 'u' || character == 'i' || character == 'e';
    }

    static void Main()
    {
        string text = Console.ReadLine();
        int length = text.Length;
        
        bool isValid = IsVowel(text[length - 1]) || text[length - 1] == 'n';
        
        for (int position = 0; position < length - 1; position++)
        {
            if (!IsVowel(text[position]) && text[position] != 'n' && !IsVowel(text[position + 1]))
            {
                isValid = false;
                break;
            }
        }
        
        Console.WriteLine(isValid ? "YES" : "NO");
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
        StyleHelper.Title("Romaji");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}