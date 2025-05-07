// Xenia and Ringroad
namespace CompetitiveProgramming.CodeForces.XeniaandRingroad;
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
        long house = long.Parse(input[0]);
        long task = long.Parse(input[1]);
        
        long[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
        long ans = arr[0] - 1;
        
        for (int i = 1; i < task; i++)
        {
            if (arr[i] > arr[i - 1])
                ans += arr[i] - arr[i - 1];
            else if (arr[i] < arr[i - 1])
                ans += (house - arr[i - 1]) + arr[i];
        }
        
        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Xenia and Ringroad");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}