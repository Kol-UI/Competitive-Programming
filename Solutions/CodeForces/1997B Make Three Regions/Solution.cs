// Make Three Regions
namespace CompetitiveProgramming.CodeChef.MakeThreeRegions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8601
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            string[] v = new string[2];
            v[0] = Console.ReadLine();
            v[1] = Console.ReadLine();
            
            int cnt = 0;
            for(int col = 1; col + 1 < v[0].Length; col++)
            {
                for(int row = 0; row < 2; row++)
                {
                    if(v[row][col - 1] == 'x' || v[row][col] == 'x' || v[row][col + 1] == 'x')
                        continue;
                    if(v[1 - row][col] == 'x')
                        continue;
                    if(v[1 - row][col - 1] == '.' || v[1 - row][col + 1] == '.')
                        continue;
                    cnt++;
                }
            }
            
            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8601
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make Three Regions");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}