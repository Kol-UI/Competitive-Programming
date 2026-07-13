// Primary Arithmetic
namespace CompetitiveProgramming.Kattis.PrimaryArithmetic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split();
            string a = input[0];
            string b = input[1];

            if (a == "0" && b == "0") break;

            while (a.Length < b.Length) a = "0" + a;
            while (b.Length < a.Length) b = "0" + b;

            int carry = 0;
            int ans = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int sum = (a[i] - '0') + (b[i] - '0') + carry;
                if (sum >= 10)
                {
                    ans++;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            if (ans == 0)
                Console.WriteLine("No carry operation.");
            else if (ans == 1)
                Console.WriteLine("1 carry operation.");
            else
                Console.WriteLine($"{ans} carry operations.");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Primary Arithmetic");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}