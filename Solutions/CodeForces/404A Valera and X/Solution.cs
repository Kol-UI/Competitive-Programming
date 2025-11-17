// Valera and X
namespace CompetitiveProgramming.CodeForces.ValeraandX;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string firstLine = Console.ReadLine();
        
        char diagonalChar = firstLine[0];
        char otherChar = firstLine[1];
        bool isValid = true;
        
        if (diagonalChar == otherChar) isValid = false;
        for (int col = 2; col < n - 1; col++)
        {
            if (firstLine[col] != otherChar)
            {
                isValid = false;
                break;
            }
        }
        if (firstLine[n - 1] != diagonalChar) isValid = false;
        
        for (int row = 1; row < n; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < n; col++)
            {
                if (col == row || col == n - 1 - row)
                {
                    if (line[col] != diagonalChar)
                    {
                        isValid = false;
                        break;
                    }
                }
                else if (line[col] != otherChar)
                {
                    isValid = false;
                    break;
                }
            }
        }
        
        Console.WriteLine(isValid ? "YES" : "NO");
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
        StyleHelper.Title("Valera and X");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}