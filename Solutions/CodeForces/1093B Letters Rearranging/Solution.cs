// Letters Rearranging
namespace CompetitiveProgramming.CodeForces.LettersRearranging;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            string text = Console.ReadLine();
            int differentPosition = -1;
            
            for (int position = 0; position < text.Length; position++)
            {
                if (text[position] != text[0])
                {
                    differentPosition = position;
                    break;
                }
            }
            
            if (differentPosition < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                if (text[0] == text[text.Length - 1])
                {
                    char[] characters = text.ToCharArray();
                    char temp = characters[0];
                    characters[0] = characters[differentPosition];
                    characters[differentPosition] = temp;
                    text = new string(characters);
                }
                Console.WriteLine(text);
            }
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
        StyleHelper.Title("Letters Rearranging");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}