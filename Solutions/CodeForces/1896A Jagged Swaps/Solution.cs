// Jagged Swaps
namespace CompetitiveProgramming.CodeForces.JaggedSwaps;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string msg = "YES";
            
            while (true)
            {
                bool swapped = false;
                for (int i = 1; i < n - 1; i++)
                {
                    if (a[i] > a[i - 1] && a[i] > a[i + 1])
                    {
                        (a[i], a[i + 1]) = (a[i + 1], a[i]);
                        swapped = true;
                    }
                }
                
                if (IsSorted(a)) break;
                if (!swapped)
                {
                    msg = "NO";
                    break;
                }
            }
            
            Console.WriteLine(msg);
        }
    }

    static bool IsSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            if (arr[i] > arr[i + 1])
                return false;
        return true;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jagged Swaps");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}