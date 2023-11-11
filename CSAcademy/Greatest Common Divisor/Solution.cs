// Greatest Common Divisor



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CSAcademy.GreatestCommonDivisor;

class Solution
{
    //static void Main(String[] args)
    static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split();
        int val1 = int.Parse(input[0]);
        int val2 = int.Parse(input[1]);

        int gcd = GCD(val1, val2);

        Console.WriteLine(gcd);
    }
    
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}