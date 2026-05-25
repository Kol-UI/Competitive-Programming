// Das Blinkenlights
namespace CompetitiveProgramming.Kattis.DasBlinkenlights;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int p = int.Parse(input[0]);
        int q = int.Parse(input[1]);
        int s = int.Parse(input[2]);
        
        int lcm = p * q / Gcd(p, q);
        
        if (lcm <= s)
            Console.WriteLine("yes");
        else
            Console.WriteLine("no");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Das Blinkenlights");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}