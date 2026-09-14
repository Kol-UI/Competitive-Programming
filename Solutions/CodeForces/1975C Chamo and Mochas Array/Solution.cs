// Chamo and Mocha's Array
namespace CompetitiveProgramming.CodeForces.ChamoandMochasArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine().Trim());
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long[] v = new long[n];
            for (int p = 0; p < n; p++)
            {
                v[p] = long.Parse(parts[p]);
            }

            if (n == 2)
            {
                Console.WriteLine(v[0] < v[1] ? v[0] : v[1]);
                continue;
            }

            SortedMultiset s = new SortedMultiset();
            s.Add(v[0]);
            s.Add(v[1]);
            s.Add(v[2]);

            long res = s.GetMedian();
            for (int p = 3; p < n; p++)
            {
                s.Remove(v[p - 3]);
                s.Add(v[p]);
                long cand = s.GetMedian();
                res = res > cand ? res : cand;
            }

            Console.WriteLine(res);
        }
    }
}

class SortedMultiset
{
    private readonly List<long> _list = new List<long>();

    public void Add(long val)
    {
        int index = _list.BinarySearch(val);
        if (index < 0) index = ~index;
        _list.Insert(index, val);
    }

    public void Remove(long val)
    {
        int index = _list.BinarySearch(val);
        if (index >= 0)
        {
            _list.RemoveAt(index);
        }
    }

    public long GetMedian()
    {
        return _list[1];
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Chamo and Mocha's Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}