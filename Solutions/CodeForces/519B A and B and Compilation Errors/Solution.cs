// A and B and Compilation Errors
namespace CompetitiveProgramming.CodeForces.AandBandCompilationErrors;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int[] brr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int[] crr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        Array.Sort(arr);
        Array.Sort(brr);
        Array.Sort(crr);

        bool found = false;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] != brr[i])
            {
                Console.WriteLine(arr[i]);
                found = true;
                break;
            }
        }
        if (!found) Console.WriteLine(arr[n - 1]);

        found = false;
        for (int i = 0; i < n - 2; i++)
        {
            if (brr[i] != crr[i])
            {
                Console.WriteLine(brr[i]);
                found = true;
                break;
            }
        }
        if (!found) Console.WriteLine(brr[n - 2]);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A and B and Compilation Errors");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}