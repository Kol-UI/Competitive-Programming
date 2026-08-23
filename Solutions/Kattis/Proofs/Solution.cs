// Proofs
namespace CompetitiveProgramming.Kattis.Proofs;
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
        int n = int.Parse(Console.ReadLine());
        HashSet<string> truth = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.None);
            string left = parts[0].Trim();
            string right = parts[1].Trim();

            if (left == "")
            {
                truth.Add(right);
            }
            else
            {
                string[] premises = left.Split();
                bool allTrue = true;
                foreach (string p in premises)
                {
                    if (!truth.Contains(p))
                    {
                        allTrue = false;
                        break;
                    }
                }

                if (!allTrue)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
                else
                {
                    truth.Add(right);
                }
            }
        }

        Console.WriteLine("correct");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Proofs");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}