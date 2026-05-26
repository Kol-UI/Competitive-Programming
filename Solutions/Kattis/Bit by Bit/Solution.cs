// Bit by Bit
namespace CompetitiveProgramming.Kattis.BitbyBit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0) break;

            int[] reg = new int[32];
            for (int i = 0; i < 32; i++) reg[i] = -1;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string op = input[0];

                if (op == "SET")
                {
                    int in1 = int.Parse(input[1]);
                    reg[in1] = 1;
                }
                else if (op == "CLEAR")
                {
                    int in1 = int.Parse(input[1]);
                    reg[in1] = 0;
                }
                else if (op == "AND")
                {
                    int in1 = int.Parse(input[1]);
                    int in2 = int.Parse(input[2]);

                    if (reg[in1] == 1 && reg[in2] == 1)
                        reg[in1] = 1;
                    else if (reg[in1] == 0 || reg[in2] == 0)
                        reg[in1] = 0;
                    else
                        reg[in1] = -1;
                }
                else if (op == "OR")
                {
                    int in1 = int.Parse(input[1]);
                    int in2 = int.Parse(input[2]);

                    if (reg[in1] == 1 || reg[in2] == 1)
                        reg[in1] = 1;
                    else if (reg[in1] == 0 && reg[in2] == 0)
                        reg[in1] = 0;
                    else
                        reg[in1] = -1;
                }
            }

            Array.Reverse(reg);

            foreach (int i in reg)
            {
                Console.Write(i == -1 ? "?" : i.ToString());
            }
            Console.WriteLine();
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
        StyleHelper.Title("Bit by Bit");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}