// Right Left Wrong
namespace CompetitiveProgramming.CodeForces.RightLeftWrong;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

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
            long[] a = new long[n + 2];
            for (long p = 1; p <= n; p++)
            {
                a[p] = long.Parse(input[p - 1]);
                a[p] += a[p - 1];
            }
            
            string s = Console.ReadLine();
            s = "R" + s + "L";
            
            long left = 0;
            long right = n + 1;
            long total = 0;
            
            do
            {
                left++;
                while (left < s.Length && s[(int)left] != 'L') left++;
                right--;
                while (right >= 0 && s[(int)right] != 'R') right--;
                
                if (left < right)
                {
                    total += a[right] - a[left - 1];
                }
                else
                {
                    break;
                }
            } while (left < right);
            
            Console.WriteLine(total);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Right Left Wrong");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}