// Bear and Finding Criminals
namespace CompetitiveProgramming.CodeForces.BearandFindingCriminals;
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
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int a = int.Parse(input[1]);
        
        int[] v = new int[n + 1];
        string[] numbers = Console.ReadLine().Split();
        for (int i = 1; i <= n; i++)
        {
            v[i] = int.Parse(numbers[i - 1]);
        }
        
        int result = v[a];
        for (int distance = 1; distance <= n; distance++)
        {
            int left = a - distance;
            int right = a + distance;
            
            if (left < 1 && right > n) break;
            else if (left >= 1 && right <= n && v[left] == v[right]) result += 2 * v[left];
            else if (left >= 1 && right > n) result += v[left];
            else if (left < 1 && right <= n) result += v[right];
        }
        
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bear and Finding Criminals");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}