// Special Permutation
namespace CompetitiveProgramming.CodeForces.BSpecialPermutation;
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
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int a = int.Parse(input[1]);
            int b = int.Parse(input[2]);
            
            int[] permutation = new int[n];
            permutation[0] = a;
            permutation[n - 1] = b;
            
            int currentNumber = n;
            for (int position = 1; position < n - 1; position++)
            {
                while (currentNumber == a || currentNumber == b)
                {
                    currentNumber--;
                }
                permutation[position] = currentNumber;
                currentNumber--;
            }
            
            int firstHalfMin = n + 1;
            int secondHalfMax = -1;
            
            for (int i = 0; i < n / 2; i++)
            {
                firstHalfMin = Math.Min(firstHalfMin, permutation[i]);
            }
            
            for (int i = n / 2; i < n; i++)
            {
                secondHalfMax = Math.Max(secondHalfMax, permutation[i]);
            }
            
            if (firstHalfMin != a || secondHalfMax != b)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(string.Join(" ", permutation));
            }
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
        StyleHelper.Title("Special Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}