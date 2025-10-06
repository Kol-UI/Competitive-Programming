// MEX rose
namespace CompetitiveProgramming.CodeForces.MEXrose;
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
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);
            
            HashSet<int> numbers = new HashSet<int>();
            int targetCount = 0;
            
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int number in array)
            {
                if (number == k)
                {
                    targetCount++;
                }
                else
                {
                    numbers.Add(number);
                }
            }
            
            int missingCount = 0;
            for (int number = 0; number < k; number++)
            {
                if (!numbers.Contains(number))
                {
                    missingCount++;
                }
            }
            
            int result = Math.Max(missingCount, targetCount);
            Console.WriteLine(result);
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
        StyleHelper.Title("MEX rose");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}