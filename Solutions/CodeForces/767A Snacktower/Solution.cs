// Snacktower
namespace CompetitiveProgramming.CodeForces.Snacktower;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int current = n;

        for (int i = 0; i < n; i++)
        {
            pq.Enqueue(v[i], -v[i]);

            if (pq.Peek() == current)
            {
                while (pq.Count > 0 && pq.Peek() == current)
                {
                    Console.Write(pq.Dequeue() + " ");
                    current--;
                }
                if (current != 0)
                    Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Snacktower");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}