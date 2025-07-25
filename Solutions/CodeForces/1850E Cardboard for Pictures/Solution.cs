// Cardboard for Pictures
namespace CompetitiveProgramming.CodeForces.CardboardforPictures;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long c = long.Parse(input[1]);
            
            long[] s = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long sum = 0;
            long sumSq = 0;
            
            foreach (long num in s)
            {
                sum += num;
                sumSq += num * num;
            }
            
            c -= sumSq;
            
            long low = 0;
            long high = (long)Math.Sqrt(c / (4 * n)) + 1;
            long answer = 0;
            
            while (low <= high)
            {
                long mid = (low + high) / 2;
                long total = 4 * n * mid * mid + 4 * sum * mid;
                
                if (total == c)
                {
                    answer = mid;
                    break;
                }
                else if (total < c)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            
            Console.WriteLine(answer);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cardboard for Pictures");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}