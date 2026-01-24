// Tenzing and Books
namespace CompetitiveProgramming.CodeForces.TenzingandBooks;
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
            int x = firstLine[1];
            
            int k = 0;
            
            for(int u = 0; u < 3; u++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                bool read = true;
                
                for(int p = 0; p < n; p++)
                {
                    int cur = numbers[p];
                    if((x | cur) != x)
                    {
                        read = false;
                    }
                    if(read)
                    {
                        k |= cur;
                    }
                }
            }
            
            Console.WriteLine(x == k ? "Yes" : "No");
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
        StyleHelper.Title("Tenzing and Books");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}