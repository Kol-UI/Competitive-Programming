// Sideways Sorting
namespace CompetitiveProgramming.Kattis.SidewaysSorting;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            string[] firstLine = Console.ReadLine().Split();
            int r = int.Parse(firstLine[0]);
            int c = int.Parse(firstLine[1]);
            
            if (r + c <= 0) break;
            
            char[][] a = new char[r][];
            for (int i = 0; i < r; i++)
            {
                a[i] = Console.ReadLine().ToCharArray();
            }
            
            char[][] transposed = new char[c][];
            for (int i = 0; i < c; i++)
            {
                transposed[i] = new char[r];
                for (int j = 0; j < r; j++)
                {
                    transposed[i][j] = a[j][i];
                }
            }
            
            Array.Sort(transposed, (x, y) =>
            {
                string sx = new string(x).ToLower();
                string sy = new string(y).ToLower();
                return string.Compare(sx, sy);
            });
            
            char[][] result = new char[r][];
            for (int i = 0; i < r; i++)
            {
                result[i] = new char[c];
                for (int j = 0; j < c; j++)
                {
                    result[i][j] = transposed[j][i];
                }
            }
            
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine(new string(result[i]));
            }
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sideways Sorting");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}