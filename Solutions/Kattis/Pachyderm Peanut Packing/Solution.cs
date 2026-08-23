// Pachyderm Peanut Packing
namespace CompetitiveProgramming.Kattis.PachydermPeanutPacking;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    struct Box
    {
        public double x1, y1, x2, y2;
        public string size;
    }

    static bool InBox(Box b, double x, double y)
    {
        return b.x1 <= x && x <= b.x2 && b.y1 <= y && y <= b.y2;
    }

    static void Main()
    {
        bool first = true;
        string line;

        while ((line = Console.ReadLine()) != null && line != "")
        {
            int n = int.Parse(line);
            if (n == 0) break;

            if (!first)
                Console.WriteLine();
            first = false;

            List<Box> boxes = new List<Box>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Box b;
                b.x1 = double.Parse(input[0]);
                b.y1 = double.Parse(input[1]);
                b.x2 = double.Parse(input[2]);
                b.y2 = double.Parse(input[3]);
                b.size = input[4];
                boxes.Add(b);
            }

            int p = int.Parse(Console.ReadLine());

            for (int i = 0; i < p; i++)
            {
                string[] input = Console.ReadLine().Split();
                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);
                string size = input[2];

                Console.Write($"{size} ");

                bool printed = false;
                foreach (Box b in boxes)
                {
                    if (InBox(b, x, y))
                    {
                        printed = true;
                        if (b.size == size)
                            Console.WriteLine("correct");
                        else
                            Console.WriteLine(b.size);
                    }
                }

                if (!printed)
                    Console.WriteLine("floor");
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pachyderm Peanut Packing");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}