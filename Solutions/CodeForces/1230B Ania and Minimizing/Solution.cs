// Ania and Minimizing
namespace CompetitiveProgramming.CodeForces.AniaandMinimizing;
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
        int k = int.Parse(input[1]);
        char[] digits = Console.ReadLine().ToCharArray();
        
        if (k == 0)
        {
            Console.WriteLine(new string(digits));
        }
        else if (n == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (digits[0] != '1')
            {
                digits[0] = '1';
                k--;
            }
            
            for (int i = 1; i < n && k > 0; i++)
            {
                if (digits[i] == '0') continue;
                digits[i] = '0';
                k--;
            }
            
            Console.WriteLine(new string(digits));
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
        StyleHelper.Title("Ania and Minimizing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}