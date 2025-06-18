// Given Length and Sum of Digits
namespace CompetitiveProgramming.CodeForces.GivenLengthandSumofDigits;

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604
using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int m = input[0];
        int s = input[1];

        if (s > m * 9)
        {
            Console.WriteLine("-1 -1");
            return;
        }
        else if (s == 0)
        {
            if (m == 1)
            {
                Console.WriteLine("0 0");
                return;
            }
            else
            {
                Console.WriteLine("-1 -1");
                return;
            }
        }

        char[] mx = new char[m];
        int remaining = s;
        for (int i = 0; i < m; i++)
        {
            int digit = Math.Min(9, remaining);
            mx[i] = (char)(digit + '0');
            remaining -= digit;
        }

        char[] mn = mx.ToArray();
        Array.Reverse(mn);

        if (mn[0] == '0')
        {
            for (int i = 0; i < m; i++)
            {
                if (mn[i] != '0')
                {
                    mn[i]--;
                    break;
                }
            }
            mn[0]++;
        }

        Console.WriteLine($"{new string(mn)} {new string(mx)}");
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
        StyleHelper.Title("Given Length and Sum of Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1400);
	}
}