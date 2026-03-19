// Matrix of Differences
namespace CompetitiveProgramming.CodeForces.MatrixofDifferences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[n, n];
            int left = 1;
            int right = n * n;
            bool alternate = false;
            
            for(int row = 0; row < n; row++)
            {
                List<int> tempRow = new List<int>();
                for(int col = 0; col < n; col++)
                {
                    if(!alternate)
                    {
                        tempRow.Add(left++);
                    }
                    else
                    {
                        tempRow.Add(right--);
                    }
                    alternate = !alternate;
                }
                
                if(row % 2 == 1)
                {
                    tempRow.Reverse();
                }
                
                for(int col = 0; col < n; col++)
                {
                    matrix[row, col] = tempRow[col];
                }
            }
            
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Matrix of Differences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}