// Permutation Sort
namespace CompetitiveProgramming.CodeForces.PermutationSort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

public class Program
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            if (n == 0)
            {
                Console.WriteLine("0");
                continue;
            }
            string[] input = Console.ReadLine()!.Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            if (IsSorted(arr))
            {
                Console.WriteLine("0");
                continue;
            }
            if (arr[0] == n && arr[n - 1] == 1)
            {
                Console.WriteLine("3");
                continue;
            }
            if (arr[0] == 1 || arr[n - 1] == n)
            {
                Console.WriteLine("1");
                continue;
            }
            Console.WriteLine("2");
        }
    }

    private static bool IsSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Permutation Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}