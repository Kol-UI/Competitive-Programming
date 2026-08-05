// Minimize Permutation Subarrays
namespace CompetitiveProgramming.CodeForces.MinimizePermutationSubarrays;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            long one = 0, two = 0, fin = 0;

            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (x == 1) one = p;
                else if (x == 2) two = p;
                else if (x == n) fin = p;
            }

            long left = 1;
            long right = 1;

            if (one < two && two < fin)
            {
                left += two;
                right += fin;
            }
            else if (two < one && one < fin)
            {
                left += one;
                right += fin;
            }
            else if (fin < one && one < two)
            {
                left += fin;
                right += one;
            }
            else if (fin < two && two < one)
            {
                left += fin;
                right += two;
            }

            Console.WriteLine($"{left} {right}");
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
        StyleHelper.Title("Minimize Permutation Subarrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}