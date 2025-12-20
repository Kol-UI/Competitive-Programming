// Yuu Koito and Minimum Absolute Sum
namespace CompetitiveProgramming.CodeForces.YuuKoitoandMinimumAbsoluteSum;
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
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            if (numbers[0] < 0 && numbers[n - 1] < 0)
            {
                numbers[0] = 0;
                numbers[n - 1] = 0;
            }
            else if (numbers[0] < 0)
            {
                numbers[0] = numbers[n - 1];
            }
            else if (numbers[n - 1] < 0)
            {
                numbers[n - 1] = numbers[0];
            }
            
            for (int i = 1; i < n - 1; i++)
            {
                if (numbers[i] < 0) numbers[i] = 0;
            }
            
            long difference = numbers[n - 1] - numbers[0];
            Console.WriteLine(difference < 0 ? -difference : difference);
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
        StyleHelper.Title("Yuu Koito and Minimum Absolute Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}