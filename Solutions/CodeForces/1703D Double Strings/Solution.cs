// Double Strings
namespace CompetitiveProgramming.CodeForces.DoubleStrings;
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
            List<string> v = new List<string>();
            HashSet<string> f = new HashSet<string>();
            
            for (int p = 0; p < n; p++)
            {
                string s = Console.ReadLine();
                v.Add(s);
                f.Add(s);
            }

            int[] res = new int[n];
            for (int p = 0; p < n; p++)
            {
                string cur = v[p];
                for (int len = 1; len < cur.Length; len++)
                {
                    string x = cur.Substring(0, len);
                    string y = cur.Substring(len);
                    if (f.Contains(x) && f.Contains(y))
                        res[p] = 1;
                }
            }

            Console.WriteLine(string.Join("", res));
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
        StyleHelper.Title("Double Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}