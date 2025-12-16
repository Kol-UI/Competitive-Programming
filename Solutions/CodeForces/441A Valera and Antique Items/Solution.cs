// Valera and Antique Items
namespace CompetitiveProgramming.CodeForces.ValeraandAntiqueItems;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int v = int.Parse(input[1]);
        
        List<int> sellers = new List<int>();
        
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split();
            int k = int.Parse(data[0]);
            bool valid = false;
            
            for (int j = 1; j <= k; j++)
            {
                int price = int.Parse(data[j]);
                if (price < v) valid = true;
            }
            
            if (valid) sellers.Add(i + 1);
        }
        
        Console.WriteLine(sellers.Count);
        Console.WriteLine(string.Join(" ", sellers));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Valera and Antique Items");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}