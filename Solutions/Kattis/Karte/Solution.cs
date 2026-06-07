// Karte
namespace CompetitiveProgramming.Kattis.Karte;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static int Left(bool[] v)
    {
        int cards = 13;
        foreach (bool b in v)
        {
            if (b) cards--;
        }
        return cards;
    }

    static void Main()
    {
        string s = Console.ReadLine();
        
        bool[] p = new bool[14];
        bool[] k = new bool[14];
        bool[] h = new bool[14];
        bool[] t = new bool[14];
        
        bool duplicate = false;
        
        for (int i = 0; i < s.Length; i += 3)
        {
            char suit = s[i];
            int num = 10 * (s[i + 1] - '0') + (s[i + 2] - '0');
            
            if (suit == 'P')
            {
                if (p[num])
                {
                    duplicate = true;
                    Console.WriteLine("GRESKA");
                    break;
                }
                p[num] = true;
            }
            else if (suit == 'K')
            {
                if (k[num])
                {
                    duplicate = true;
                    Console.WriteLine("GRESKA");
                    break;
                }
                k[num] = true;
            }
            else if (suit == 'H')
            {
                if (h[num])
                {
                    duplicate = true;
                    Console.WriteLine("GRESKA");
                    break;
                }
                h[num] = true;
            }
            else if (suit == 'T')
            {
                if (t[num])
                {
                    duplicate = true;
                    Console.WriteLine("GRESKA");
                    break;
                }
                t[num] = true;
            }
        }
        
        if (!duplicate)
        {
            Console.WriteLine($"{Left(p)} {Left(k)} {Left(h)} {Left(t)}");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Karte");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}