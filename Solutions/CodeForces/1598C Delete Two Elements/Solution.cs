// Delete Two Elements
namespace CompetitiveProgramming.CodeForces.DeleteTwoElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            long[] v = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
            long sum = 0;
            foreach (var x in v) sum += x;
            double avg = (double)sum / n;
            double req = avg * 2;

            if (2 * sum % n != 0)
            {
                Console.WriteLine(0);
                continue;
            }

            long target = (long)(req);
            Dictionary<long, int> mp = new Dictionary<long, int>();
            long ans = 0;

            foreach (var x in v)
            {
                long need = target - x;
                if (mp.ContainsKey(need)) ans += mp[need];
                if (mp.ContainsKey(x)) mp[x]++;
                else mp[x] = 1;
            }

            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Delete Two Elements");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}