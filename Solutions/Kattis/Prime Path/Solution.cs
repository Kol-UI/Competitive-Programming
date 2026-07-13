// Prime Path
namespace CompetitiveProgramming.Kattis.PrimePath;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int mxN = 10000;
        bool[] isPrime = new bool[mxN];
        for (int i = 0; i < mxN; i++) isPrime[i] = true;
        isPrime[0] = false;
        isPrime[1] = false;

        for (int i = 2; i < mxN; i++)
        {
            if (!isPrime[i]) continue;
            for (int j = i * i; j < mxN; j += i)
                isPrime[j] = false;
        }

        List<int>[] adj = new List<int>[mxN];
        for (int i = 0; i < mxN; i++)
            adj[i] = new List<int>();

        for (int i = 1000; i < mxN; i++)
        {
            if (!isPrime[i]) continue;
            string s = i.ToString();

            for (int pos = 0; pos < 4; pos++)
            {
                for (int dig = 0; dig < 10; dig++)
                {
                    char[] chars = s.ToCharArray();
                    chars[pos] = (char)('0' + dig);
                    int nnum = int.Parse(new string(chars));

                    if (nnum <= i || nnum < 1000 || !isPrime[nnum])
                        continue;

                    adj[i].Add(nnum);
                    adj[nnum].Add(i);
                }
            }
        }

        int t = int.Parse(Console.ReadLine());
        for (int idx = 0; idx < t; idx++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((a, 0));

            HashSet<int> vis = new HashSet<int>();
            vis.Add(a);

            int ans = -1;

            while (q.Count > 0)
            {
                var (u, d) = q.Dequeue();
                if (u == b)
                {
                    ans = d;
                    break;
                }

                foreach (int v in adj[u])
                {
                    if (!vis.Contains(v))
                    {
                        vis.Add(v);
                        q.Enqueue((v, d + 1));
                    }
                }
            }

            Console.WriteLine(ans == -1 ? "Impossible" : ans.ToString());
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
        StyleHelper.Title("Prime Path");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}