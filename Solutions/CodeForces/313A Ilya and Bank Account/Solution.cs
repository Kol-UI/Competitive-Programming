// Ilya and Bank Account
namespace CompetitiveProgramming.CodeForces.IlyaandBankAccount;
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
        if (num.StartsWith("-"))
        {
            if (num.Length > 1)
            {
                if (num[num.Length - 1] > num[num.Length - 2])
                {
                    num = num.Remove(num.Length - 1);
                }
                else
                {
                    char[] arr = num.ToCharArray();
                    char temp = arr[arr.Length - 1];
                    arr[arr.Length - 1] = arr[arr.Length - 2];
                    arr[arr.Length - 2] = temp;
                    num = new string(arr);
                    num = num.Remove(num.Length - 1);
                }
            }
        }
        if (num == "-0") num = "0";
        Console.WriteLine(num);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ilya and Bank Account");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}