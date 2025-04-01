// Array merging
namespace CompetitiveProgramming.CodeForces.Arraymerging;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] a = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            
            Dictionary<int, int> af = new Dictionary<int, int>();
            Dictionary<int, int> bf = new Dictionary<int, int>();
            
            int cnt = 1;
            for (int i = 0; i + 1 < n; i++)
            {
                if (a[i] == a[i + 1])
                    cnt++;
                else
                    cnt = 1;
                if (!af.ContainsKey(a[i])) af[a[i]] = 0;
                af[a[i]] = Math.Max(af[a[i]], cnt);
            }
            if (!af.ContainsKey(a[n - 1])) af[a[n - 1]] = 0;
            af[a[n - 1]] = Math.Max(af[a[n - 1]], 1);
            
            cnt = 1;
            for (int i = 0; i + 1 < n; i++)
            {
                if (b[i] == b[i + 1])
                    cnt++;
                else
                    cnt = 1;
                if (!bf.ContainsKey(b[i])) bf[b[i]] = 0;
                bf[b[i]] = Math.Max(bf[b[i]], cnt);
            }
            if (!bf.ContainsKey(b[n - 1])) bf[b[n - 1]] = 0;
            bf[b[n - 1]] = Math.Max(bf[b[n - 1]], 1);
            
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                int afVal = af.ContainsKey(a[i]) ? af[a[i]] : 0;
                int bfVal = bf.ContainsKey(a[i]) ? bf[a[i]] : 0;
                ans = Math.Max(ans, afVal + bfVal);
                
                afVal = af.ContainsKey(b[i]) ? af[b[i]] : 0;
                bfVal = bf.ContainsKey(b[i]) ? bf[b[i]] : 0;
                ans = Math.Max(ans, afVal + bfVal);
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Array merging");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}