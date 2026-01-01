// Sale
namespace CompetitiveProgramming.CodeForces.Sale;
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
        int t = 1;
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] arr = new int[n];
            input = Console.ReadLine()!.Split();
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            Array.Sort(arr);
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(-sum);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sale");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}