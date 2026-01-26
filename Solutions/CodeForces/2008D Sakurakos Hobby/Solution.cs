// Sakurako's Hobby
namespace CompetitiveProgramming.CodeForces.SakurakosHobby;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            int[] f = new int[n + 1];
            bool[] w = new bool[n + 1];
            
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int p = 1; p <= n; p++)
            {
                v[p] = numbers[p - 1];
            }
            
            string s = Console.ReadLine();
            
            for(int p = 1; p <= n; p++)
            {
                if(w[p]) continue;
                
                List<int> u = new List<int>();
                int x = p;
                int cnt = 0;
                
                while(!w[x])
                {
                    u.Add(x);
                    w[x] = true;
                    if(s[x - 1] == '0') cnt++;
                    x = v[x];
                }
                
                foreach(int node in u)
                {
                    f[node] = cnt;
                }
            }
            
            Console.WriteLine(string.Join(" ", f.Skip(1).Select(x => x.ToString()).ToArray()));
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
        StyleHelper.Title("Sakurako's Hobby");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}