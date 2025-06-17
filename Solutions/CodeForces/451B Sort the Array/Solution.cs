// Sort the Array
namespace CompetitiveProgramming.CodeForces.SortheArray;
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
        int n = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int ini = 0, ter = 0;
        bool ok = false;
        
        for (int i = 1; i < n; i++)
        {
            if (arr[i] < arr[i - 1])
            {
                if (!ok)
                {
                    ok = true;
                    ini = i - 1;
                    ter = i;
                }
                else
                {
                    ter++;
                }
            }
            else if (ter != 0)
            {
                break;
            }
        }
        
        Array.Reverse(arr, ini, ter - ini + 1);
        
        bool isSorted = true;
        for (int i = 1; i < n; i++)
        {
            if (arr[i] < arr[i - 1])
            {
                isSorted = false;
                break;
            }
        }
        
        if (isSorted)
        {
            Console.WriteLine("yes");
            Console.WriteLine($"{ini + 1} {ter + 1}");
        }
        else
        {
            Console.WriteLine("no");
        }
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
        StyleHelper.Title("Sort the Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
	}
}