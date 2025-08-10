// Numeric String Template
namespace CompetitiveProgramming.CodeForces.NumericStringTemplate;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            int m = int.Parse(Console.ReadLine());
            
            while (m-- > 0)
            {
                Dictionary<long, char> numToChar = new Dictionary<long, char>();
                Dictionary<char, long> charToNum = new Dictionary<char, long>();
                string s = Console.ReadLine();
                
                if (s.Length != n)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                bool res = true;
                for (int p = 0; res && p < s.Length; p++)
                {
                    long f = a[p];
                    char g = s[p];
                    
                    bool hasNum = numToChar.ContainsKey(f);
                    bool hasChar = charToNum.ContainsKey(g);
                    
                    if (hasNum ^ hasChar)
                    {
                        res = false;
                    }
                    
                    if (!hasNum)
                    {
                        numToChar[f] = g;
                        charToNum[g] = f;
                    }
                    else if (numToChar[f] != g || charToNum[g] != f)
                    {
                        res = false;
                    }
                }
                
                Console.WriteLine(res ? "YES" : "NO");
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Numeric String Template");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}