// Save the Magazines
namespace CompetitiveProgramming.CodeForces.SavetheMagazines;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Linq;
using System.Text;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            StringBuilder sb = new StringBuilder(s);
            sb.Append('0');
            
            long prev = -1;
            int idx = -1;
            
            for(int p = 1; p <= n; p++)
            {
                if(sb[p - 1] == '0' && sb[p] == '1')
                {
                    prev = a[p - 1];
                    idx = p - 1;
                }
                else if(idx >= 0 && sb[p - 1] == '1')
                {
                    if(a[p - 1] < prev)
                    {
                        sb[idx] = '1';
                        idx = p - 1;
                        sb[p - 1] = '0';
                        prev = a[p - 1];
                    }
                    if(sb[p] == '0')
                    {
                        prev = -1;
                        idx = -1;
                    }
                }
            }
            
            long cnt = 0;
            for(int p = 0; p < n; p++)
            {
                if(sb[p] == '1') cnt += a[p];
            }
            
            Console.WriteLine(cnt);
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
        StyleHelper.Title("Save the Magazines");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}