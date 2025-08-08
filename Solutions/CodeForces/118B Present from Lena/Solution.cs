// Present from Lena
namespace CompetitiveProgramming.CodeForces.PresentFromLena;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row <= 2 * n; row++)
        {
            int modRow = Math.Min(row, 2 * n - row);
            string line = "";
            
            for (int col = 0; col <= 2 * n; col++)
            {
                if (col >= n - modRow && col <= n + modRow)
                {
                    int value = Math.Min(col + modRow - n, n + modRow - col);
                    line += value.ToString();
                    
                    if (col < n + modRow || value > 0)
                        line += " ";
                }
                else if (col < n - modRow)
                {
                    line += "  ";
                }
            }
            
            Console.WriteLine(line.TrimEnd());
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
        StyleHelper.Title("Present from Lena");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}