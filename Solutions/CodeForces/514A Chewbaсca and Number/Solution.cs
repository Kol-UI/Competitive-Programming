// Chewbaсca and Number
namespace CompetitiveProgramming.CodeForces.ChewbaccaandNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string num = Console.ReadLine()!;
        char[] digits = num.ToCharArray();

        for (int i = 1; i < digits.Length; i++)
        {
            if (digits[i] > '9' - digits[i] + '0')
            {
                digits[i] = (char)('9' - digits[i] + '0');
            }
        }

        if (digits[0] != '9' && digits[0] > '9' - digits[0] + '0')
        {
            digits[0] = (char)('9' - digits[0] + '0');
        }

        Console.WriteLine(new string(digits));
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Chewbacca and Number");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}