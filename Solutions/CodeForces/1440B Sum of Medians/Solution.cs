// Sum of Medians
namespace CompetitiveProgramming.CodeForces.SumofMedians;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Array.Sort(arr);
            long sum = 0;
            int index = arr.Length - (n / 2 + 1);
            
            for (int i = 0; i < k; i++)
            {
                sum += arr[index];
                index -= (n / 2 + 1);
            }
            
            Console.WriteLine(sum);
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
        StyleHelper.Title("Sum of Medians");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}