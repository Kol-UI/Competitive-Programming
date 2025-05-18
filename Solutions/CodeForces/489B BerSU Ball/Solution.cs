// BerSU Ball
namespace CompetitiveProgramming.CodeForces.BerSUBall;
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
        int n = int.Parse(Console.ReadLine()!);
        Dictionary<int, int> mp = new Dictionary<int, int>();
        string[] input = Console.ReadLine()!.Split();
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(input[i]);
            if (mp.ContainsKey(a)) mp[a]++;
            else mp[a] = 1;
        }

        int m = int.Parse(Console.ReadLine()!);
        int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        Array.Sort(b);

        int cnt = 0;
        foreach (int num in b)
        {
            if (mp.ContainsKey(num - 1) && mp[num - 1] > 0)
            {
                cnt++;
                mp[num - 1]--;
            }
            else if (mp.ContainsKey(num) && mp[num] > 0)
            {
                cnt++;
                mp[num]--;
            }
            else if (mp.ContainsKey(num + 1) && mp[num + 1] > 0)
            {
                cnt++;
                mp[num + 1]--;
            }
        }
        Console.WriteLine(cnt);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("BerSU Ball");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}