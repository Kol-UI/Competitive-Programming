// Avoiding Zero
namespace CompetitiveProgramming.CodeForces.AvoidingZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long total = numbers.Sum();
            
            if (total == 0)
            {
                Console.WriteLine("NO");
                continue;
            }
            
            Console.WriteLine("YES");
            Array.Sort(numbers);
            
            if (total > 0)
            {
                Array.Reverse(numbers);
            }
            
            Console.WriteLine(string.Join(" ", numbers));
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
        StyleHelper.Title("Avoiding Zero");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}