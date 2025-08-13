// YetnotherrokenKeoard
namespace CompetitiveProgramming.CodeForces.YetnotherrokenKeoard;
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
            string s = Console.ReadLine();
            List<int> smalls = new List<int>();
            List<int> caps = new List<int>();
            bool[] show = new bool[s.Length];
            Array.Fill(show, true);

            for (int p = 0; p < s.Length; p++)
            {
                if (s[p] == 'b')
                {
                    show[p] = false;
                    if (smalls.Count > 0)
                    {
                        show[smalls[smalls.Count - 1]] = false;
                        smalls.RemoveAt(smalls.Count - 1);
                    }
                }
                else if (s[p] == 'B')
                {
                    show[p] = false;
                    if (caps.Count > 0)
                    {
                        show[caps[caps.Count - 1]] = false;
                        caps.RemoveAt(caps.Count - 1);
                    }
                }
                else if (s[p] >= 'a' && s[p] <= 'z')
                {
                    smalls.Add(p);
                }
                else if (s[p] >= 'A' && s[p] <= 'Z')
                {
                    caps.Add(p);
                }
            }

            for (int p = 0; p < s.Length; p++)
            {
                if (show[p])
                {
                    Console.Write(s[p]);
                }
            }
            Console.WriteLine();
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
        StyleHelper.Title("YetnotherrokenKeoard");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}