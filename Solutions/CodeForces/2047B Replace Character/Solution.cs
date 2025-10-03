// Replace Character
namespace CompetitiveProgramming.CodeForces.ReplaceCharacter;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int length = int.Parse(Console.ReadLine());
            string text = Console.ReadLine()!;
            
            int[] frequency = new int[26];
            foreach (char character in text)
            {
                frequency[character - 'a']++;
            }
            
            int minFrequency = length;
            int maxFrequency = 0;
            char minChar = ' ';
            char maxChar = ' ';
            
            for (int index = 0; index < 26; index++)
            {
                if (frequency[index] == 0) continue;
                
                if (frequency[index] < minFrequency)
                {
                    minFrequency = frequency[index];
                    minChar = (char)('a' + index);
                }
                
                if (frequency[index] >= maxFrequency)
                {
                    maxFrequency = frequency[index];
                    maxChar = (char)('a' + index);
                }
            }
            
            char[] characters = text.ToCharArray();
            for (int position = 0; position < characters.Length; position++)
            {
                if (characters[position] == minChar)
                {
                    characters[position] = maxChar;
                    break;
                }
            }
            
            Console.WriteLine(new string(characters));
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Replace Character");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}