// Zamka
namespace CompetitiveProgramming.Kattis.Zamka;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static int GetDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    
    static void Main()
    {
        int L = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());
        
        int min = 0;
        int max = 0;
        
        for (int i = L; i <= D; i++)
        {
            if (GetDigits(i) == X)
            {
                min = i;
                break;
            }
        }
        
        for (int i = D; i >= L; i--)
        {
            if (GetDigits(i) == X)
            {
                max = i;
                break;
            }
        }
        
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Zamka");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}