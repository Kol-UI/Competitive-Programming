// Permutation Minimization by Deque
namespace CompetitiveProgramming.CodeForces.PermutationMinimizationbyDeque;
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
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            LinkedList<long> deque = new LinkedList<long>();
            
            foreach (long number in numbers)
            {
                if (deque.Count == 0 || number < deque.First.Value)
                {
                    deque.AddFirst(number);
                }
                else
                {
                    deque.AddLast(number);
                }
            }
            
            Console.WriteLine(string.Join(" ", deque));
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
        StyleHelper.Title("Permutation Minimization by Deque");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}