// Gift Carpet
namespace CompetitiveProgramming.CodeForces.GiftCarpet;
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
        string target = "vika";
        int t = int.Parse(Console.ReadLine());
        
        while (t-- > 0)
        {
            int[] dimensions = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = dimensions[0], m = dimensions[1];
            List<string> carpet = new List<string>();
            
            for (int i = 0; i < n; i++)
                carpet.Add(Console.ReadLine());
            
            int targetIndex = 0;
            for (int col = 0; col < m && targetIndex < target.Length; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (carpet[row][col] == target[targetIndex])
                    {
                        targetIndex++;
                        break;
                    }
                }
            }
            
            Console.WriteLine(targetIndex == target.Length ? "YES" : "NO");
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
        StyleHelper.Title("Gift Carpet");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}