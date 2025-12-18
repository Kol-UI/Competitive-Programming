// Reverse Sort
namespace CompetitiveProgramming.CodeForces.ReverseSort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            int left = 0;
            while (left < s.Length && s[left] == '0') left++;
            
            int right = s.Length - 1;
            while (right >= 0 && s[right] == '1') right--;
            
            List<int> indices = new List<int>();
            while (left < right)
            {
                indices.Add(left);
                indices.Add(right);
                left++;
                right--;
                while (left < s.Length && s[left] == '0') left++;
                while (right >= 0 && s[right] == '1') right--;
            }
            
            if (indices.Count > 0)
            {
                indices.Sort();
                Console.WriteLine($"1\n{indices.Count}");
                foreach (int idx in indices) Console.Write($" {idx + 1}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}


#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reverse Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}