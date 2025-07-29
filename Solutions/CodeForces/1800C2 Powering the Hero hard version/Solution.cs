// Powering the Hero (hard version)
namespace CompetitiveProgramming.CodeForces.PoweringtheHerohardversion;
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
            PriorityQueue<long> pq = new PriorityQueue<long>();
            long res = 0;
            
            long[] nums = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in nums)
            {
                if (x != 0) pq.Enqueue(-x);
                else if (pq.Count > 0) res += -pq.Dequeue();
            }
            
            Console.WriteLine(res);
        }
    }
}

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> data = new List<T>();

    public int Count => data.Count;

    public void Enqueue(T item)
    {
        data.Add(item);
        int ci = data.Count - 1;
        while (ci > 0)
        {
            int pi = (ci - 1) / 2;
            if (data[ci].CompareTo(data[pi]) >= 0) break;
            T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
            ci = pi;
        }
    }

    public T Dequeue()
    {
        T frontItem = data[0];
        data[0] = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);

        int pi = 0;
        while (true)
        {
            int ci = pi * 2 + 1;
            if (ci >= data.Count) break;
            int rc = ci + 1;
            if (rc < data.Count && data[rc].CompareTo(data[ci]) < 0) ci = rc;
            if (data[pi].CompareTo(data[ci]) <= 0) break;
            T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp;
            pi = ci;
        }
        return frontItem;
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
        StyleHelper.Title("Powering the Hero (hard version)");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}