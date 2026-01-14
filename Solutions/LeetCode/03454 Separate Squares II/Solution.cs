// Separate Squares II
namespace CompetitiveProgramming.LeetCode.SeparateSquaresII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    const int START = 1, END = -1;

    class Event {
        public int x1, x2, y, type;
        public Event(int x1, int x2, int y, int type) {
            this.x1 = x1;
            this.x2 = x2;
            this.y = y;
            this.type = type;
        }
    }

    class Node {
        public int coveredCount;
        public int coveredLength;
        public bool leftCovered = false, rightCovered = false;
    }

    class SegmentTree {
        List<int> vals;
        Node[] tree;
        int size;

        public SegmentTree(SortedSet<int> xVals) {
            vals = xVals.ToList();
            size = vals.Count;
            tree = new Node[size * 4];
            for (int i = 0; i < tree.Length; i++) tree[i] = new Node();
        }

        public void Update(int l, int r, int delta) => Update(l, r, delta, 1, 0, size - 1);

        private void Update(int l, int r, int delta, int v, int vl, int vr) {
            if (vl > r || vr < l) return;

            if (l <= vl && vr <= r) {
                tree[v].coveredCount += delta;
            } else {
                int mid = (vl + vr) / 2;
                Update(l, r, delta, v * 2, vl, mid);
                Update(l, r, delta, v * 2 + 1, mid + 1, vr);
            }

            if (tree[v].coveredCount > 0) {
                tree[v].coveredLength = vals[vr] - vals[vl] + 1;
                tree[v].leftCovered = tree[v].rightCovered = true;
            } else if (vl == vr) {
                tree[v].coveredLength = 0;
                tree[v].leftCovered = tree[v].rightCovered = false;
            } else {
                tree[v].coveredLength = tree[v * 2].coveredLength + tree[v * 2 + 1].coveredLength;
                int mid = (vl + vr) / 2;
                if (tree[v * 2].rightCovered && tree[v * 2 + 1].leftCovered) {
                    tree[v].coveredLength += vals[mid + 1] - vals[mid] - 1;
                }
                tree[v].leftCovered = tree[v * 2].leftCovered;
                tree[v].rightCovered = tree[v * 2 + 1].rightCovered;
            }
        }

        public int CoveredLength() => tree[1].coveredLength;
    }

    public double SeparateSquares(int[][] squares) {
        var xSet = new SortedSet<int>();
        foreach (var sq in squares) {
            int x = sq[0], l = sq[2];
            xSet.Add(x - 1);
            xSet.Add(x);
            xSet.Add(x + l - 1);
            xSet.Add(x + l);
        }

        var xMap = new Dictionary<int, int>();
        int index = 0;
        foreach (int x in xSet) xMap[x] = index++;

        var events = new List<Event>();
        foreach (var sq in squares) {
            int x1 = sq[0], y = sq[1], l = sq[2];
            int x2 = x1 + l - 1;
            events.Add(new Event(xMap[x1], xMap[x2], y, START));
            events.Add(new Event(xMap[x1], xMap[x2], y + l, END));
        }

        events.Sort((a, b) => a.y.CompareTo(b.y));
        var segtree = new SegmentTree(xSet);

        int prevY = events[0].y;
        long totalArea = 0;

        foreach (var e in events) {
            totalArea += 1L * (e.y - prevY) * segtree.CoveredLength();
            prevY = e.y;
            segtree.Update(e.x1, e.x2, e.type);
        }

        long currentArea = 0;
        prevY = events[0].y;

        foreach (var e in events) {
            long nextArea = currentArea + 1L * (e.y - prevY) * segtree.CoveredLength();
            if (nextArea >= (totalArea + 1) / 2) {
                double remaining = (totalArea / 2.0) - currentArea;
                return prevY + remaining / segtree.CoveredLength();
            }
            currentArea = nextArea;
            prevY = e.y;
            segtree.Update(e.x1, e.x2, e.type);
        }

        throw new Exception("No valid line found.");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Separate Squares II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}