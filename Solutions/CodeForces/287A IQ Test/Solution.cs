// IQ Test
namespace CompetitiveProgramming.CodeForces.IQTest;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

public class Solution
{
    static public void Main()
    {
        const int N = 4;
        int[,] paper = new int[N, N];
        
        for(int row = 0; row < N; row++)
        {
            string line = Console.ReadLine();
            for(int col = 0; col < N; col++)
            {
                paper[row, col] = line[col] == '.' ? 1 : 0;
            }
        }
        
        bool possible = false;
        for(int row = 0; row < N - 1; row++)
        {
            for(int col = 0; col < N - 1; col++)
            {
                int sum = paper[row, col] + paper[row + 1, col] + paper[row, col + 1] + paper[row + 1, col + 1];
                if(sum != 2)
                {
                    possible = true;
                    break;
                }
            }
            if(possible) break;
        }
        
        Console.WriteLine(possible ? "YES" : "NO");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("IQ Test");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}