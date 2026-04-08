// Shuffle Hashing
namespace CompetitiveProgramming.CodeForces.ShuffleHashing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static bool AllZeros(List<long> v)
    {
        for (long p = 0; p < v.Count; p++)
        {
            if (v[(int)p] != 0) return false;
        }
        return true;
    }

    static void Main()
    {
        const int N = 26;
        long t = long.Parse(Console.ReadLine());
        
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            List<long> f = new List<long>();
            for (int i = 0; i < N; i++) f.Add(0);
            for (long p = 0; p < s.Length; p++)
            {
                f[s[(int)p] - 'a']++;
            }
            
            string r = Console.ReadLine();
            if (r.Length < s.Length)
            {
                Console.WriteLine("NO");
                continue;
            }
            
            for (long p = 0; p < s.Length; p++)
            {
                f[r[(int)p] - 'a']--;
            }
            
            if (AllZeros(f))
            {
                Console.WriteLine("YES");
                continue;
            }
            
            bool ans = false;
            for (long p = s.Length; p < r.Length; p++)
            {
                f[r[(int)(p - s.Length)] - 'a']++;
                f[r[(int)p] - 'a']--;
                if (AllZeros(f))
                {
                    ans = true;
                    break;
                }
            }
            
            Console.WriteLine(ans ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shuffle Hashing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}