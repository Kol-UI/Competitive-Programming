// Jumping on Tiles
namespace CompetitiveProgramming.CodeForces.JumpingonTiles;
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
            string str = Console.ReadLine()!;
            var mp = new Dictionary<char, int>();
            for (char c = 'a'; c <= 'z'; c++)
                mp[c] = c - 'a' + 1;
            
            int ans = Math.Abs(mp[str.First()] - mp[str.Last()]);
            char a = str.First(), b = str.Last();
            if (a > b) (a, b) = (b, a);
            
            var v = new List<(char, int)>();
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] >= a && str[i] <= b)
                    v.Add((str[i], i + 1));
            }
            
            if (str.First() > str.Last())
                v.Sort((x, y) => y.Item1.CompareTo(x.Item1));
            else
                v.Sort((x, y) => x.Item1.CompareTo(y.Item1));
            
            Console.WriteLine($"{ans} {v.Count + 2}");
            Console.Write("1 ");
            foreach (var i in v)
                Console.Write($"{i.Item2} ");
            Console.WriteLine(str.Length);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jumping on Tiles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}