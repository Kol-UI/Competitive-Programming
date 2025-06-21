// Jzzhu and Children
namespace CompetitiveProgramming.CodeForces.JzzhuandChildren;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[] arr = new int[n];
        string[] elements = Console.ReadLine()!.Split();
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(elements[i]);
        }

        int pos = n;
        int temp = 0;

        for (int i = 0; i < n; i++)
        {
            int x = (arr[i] + m - 1) / m;

            if (x >= temp)
            {
                pos = i + 1;
                temp = x;
            }
        }

        Console.WriteLine(pos);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jzzhu and Children");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}