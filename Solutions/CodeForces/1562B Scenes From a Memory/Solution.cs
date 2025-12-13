// Scenes From a Memory
namespace CompetitiveProgramming.CodeForces.ScenesFromaMemory;
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
        bool[] composite = new bool[100];
        composite[1] = true;
        for (int p = 2; p < 11; p++)
        {
            if (composite[p]) continue;
            for (int q = 2 * p; q < 100; q += p) composite[q] = true;
        }

        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int length = int.Parse(Console.ReadLine());
            string digits = Console.ReadLine();
            
            int found = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                char c = digits[i];
                if (c == '1' || c == '4' || c == '6' || c == '8' || c == '9')
                {
                    found = c - '0';
                    break;
                }
            }

            if (found > 0)
            {
                Console.WriteLine($"1\n{found}");
                continue;
            }

            for (int i = 0; found == 0 && i < digits.Length; i++)
            {
                for (int j = i + 1; found == 0 && j < digits.Length; j++)
                {
                    int number = 10 * (digits[i] - '0') + (digits[j] - '0');
                    if (composite[number]) found = number;
                }
            }

            Console.WriteLine($"2\n{found}");
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
        StyleHelper.Title("Scenes From a Memory");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}