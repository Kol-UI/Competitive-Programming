// Li Hua and Pattern
namespace CompetitiveProgramming.CodeForces.LiHuaandPattern;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = firstLine[0];
            int k = firstLine[1];
            
            int[][] a = new int[n][];
            for(int row = 0; row < n; row++)
            {
                a[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            
            int diff = 0;
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    if(a[row][col] != a[n - 1 - row][n - 1 - col])
                    {
                        diff++;
                    }
                }
            }
            
            diff /= 2;
            
            if(k < diff || ((k - diff) % 2 != 0 && n % 2 == 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Li Hua and Pattern");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}