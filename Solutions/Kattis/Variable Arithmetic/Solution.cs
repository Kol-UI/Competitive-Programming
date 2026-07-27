// Variable Arithmetic
namespace CompetitiveProgramming.Kattis.VariableArithmetic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> vars = new Dictionary<string, int>();

        while (true)
        {
            string s = Console.ReadLine();

            if (s == "0")
                break;

            if (s.Contains("="))
            {
                string[] parts = s.Split(new string[] { " = " }, StringSplitOptions.None);
                string w = parts[0];
                int x = int.Parse(parts[1]);
                vars[w] = x;
            }
            else
            {
                string[] tokens = s.Split(new string[] { " + " }, StringSplitOptions.None);
                int num = 0;
                List<string> rm = new List<string>();
                bool hadnum = false;

                foreach (string w in tokens)
                {
                    if (int.TryParse(w, out int val))
                    {
                        num += val;
                        hadnum = true;
                    }
                    else if (vars.ContainsKey(w))
                    {
                        num += vars[w];
                        hadnum = true;
                    }
                    else
                    {
                        rm.Add(w);
                    }
                }

                if (hadnum)
                    rm.Insert(0, num.ToString());

                Console.WriteLine(string.Join(" + ", rm));
            }
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
        StyleHelper.Title("Variable Arithmetic");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}