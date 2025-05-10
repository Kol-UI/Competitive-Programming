// Cinema Line
namespace CompetitiveProgramming.CodeForces.CinemaLine;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] arr = new int[55];
        bool ok = true;
        
        string[] input = Console.ReadLine()!.Split();
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(input[i]);
            if (temp == 25)
                arr[25]++;
            else if (temp == 50)
            {
                if (arr[25] >= 1)
                {
                    arr[25]--;
                    arr[50]++;
                }
                else
                {
                    ok = false;
                    break;
                }
            }
            else
            {
                if (arr[25] >= 1 && arr[50] >= 1)
                {
                    arr[25]--;
                    arr[50]--;
                }
                else if (arr[25] >= 3)
                    arr[25] -= 3;
                else
                {
                    ok = false;
                    break;
                }
            }
        }
        Console.WriteLine(ok ? "YES" : "NO");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cinema Line");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}