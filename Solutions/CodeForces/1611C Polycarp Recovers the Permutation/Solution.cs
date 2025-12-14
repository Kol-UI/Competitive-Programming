// Polycarp Recovers the Permutation
namespace CompetitiveProgramming.CodeForces.PolycarpRecoversthePermutation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            if (numbers[0] != n && numbers[n - 1] != n)
            {
                Console.WriteLine("-1");
                continue;
            }
            
            LinkedList<long> result = new LinkedList<long>();
            int left = 0;
            int right = n - 1;
            
            while (left <= right)
            {
                if (numbers[left] < numbers[right])
                {
                    result.AddFirst(numbers[left]);
                    left++;
                }
                else
                {
                    result.AddLast(numbers[right]);
                    right--;
                }
            }
            
            Console.WriteLine(string.Join(" ", result));
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
        StyleHelper.Title("Polycarp Recovers the Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}