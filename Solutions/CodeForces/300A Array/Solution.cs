// Array
namespace CompetitiveProgramming.CodeForces.Array300A;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> first = new List<int>(), second = new List<int>(), third = new List<int>();
        
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        foreach (int num in nums)
        {
            if (num < 0) first.Add(num);
            else if (num == 0) second.Add(num);
            else third.Add(num);
        }

        if (third.Count == 0)
        {
            third.Add(first[first.Count - 1]);
            first.RemoveAt(first.Count - 1);
            third.Add(first[first.Count - 1]);
            first.RemoveAt(first.Count - 1);
        }

        if (first.Count % 2 == 0)
        {
            second.Add(first[first.Count - 1]);
            first.RemoveAt(first.Count - 1);
        }

        Console.Write(first.Count + " ");
        Console.WriteLine(string.Join(" ", first));
        
        Console.Write(third.Count + " ");
        Console.WriteLine(string.Join(" ", third));
        
        Console.Write(second.Count + " ");
        Console.WriteLine(string.Join(" ", second));
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
        StyleHelper.Title("Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}