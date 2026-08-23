// Hardware
namespace CompetitiveProgramming.Kattis.Hardware;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine()!);

        for (int tc = 0; tc < testCases; tc++)
        {
            string s = Console.ReadLine()!;
            string t = Console.ReadLine()!;
            Console.WriteLine(s);
            Console.WriteLine(t);

            int n = int.Parse(t.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
            List<int> adr = new List<int>();

            while (n > 0)
            {
                s = Console.ReadLine()!;
                if (s.StartsWith('+'))
                {
                    string[] parts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int x = int.Parse(parts[1]);
                    int y = int.Parse(parts[2]);
                    int z = int.Parse(parts[3]);

                    int cnt = 0;
                    for (int tgs = x; tgs <= y; tgs += z)
                    {
                        adr.Add(tgs);
                        cnt++;
                    }
                    n -= cnt;
                }
                else
                {
                    n -= 1;
                    adr.Add(int.Parse(s));
                }
            }

            int[] mp = new int[10];
            foreach (int x in adr)
            {
                string numStr = x.ToString();
                foreach (char c in numStr)
                {
                    mp[c - '0']++;
                }
            }

            int sm = 0;
            for (int i = 0; i < mp.Length; i++)
            {
                Console.WriteLine($"Make {mp[i]} digit {i}");
                sm += mp[i];
            }

            string plural = sm == 1 ? "" : "s";
            Console.WriteLine($"In total {sm} digit{plural}");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hardware");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}