// Less or Equal
namespace CompetitiveProgramming.CodeForces.LessorEqual;
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
        long[] input = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
        long n = input[0], k = input[1];
        long[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
        Array.Sort(arr);

        if (k == 0)
        {
            Console.WriteLine(arr[0] > 1 ? 1 : -1);
            return;
        }

        if (k == n)
        {
            Console.WriteLine(arr[n - 1]);
            return;
        }

        Console.WriteLine(arr[k - 1] != arr[k] ? arr[k - 1] : -1);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Less or Equal");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}