// Count Number of Trapezoids II
namespace CompetitiveProgramming.LeetCode.CountNumberofTrapezoidsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountTrapezoids(int[][] points)
    {
        var t = new Dictionary<int, Dictionary<int, int>>();
        var v = new Dictionary<int, Dictionary<int, int>>();
        int n = points.Length;

        for (int i = 0; i < n; i++)
        {
            int x1 = points[i][0], y1 = points[i][1];
            for (int j = i + 1; j < n; j++)
            {
                int x2 = points[j][0], y2 = points[j][1];
                int dx = x2 - x1;
                int dy = y2 - y1;

                if (dx < 0 || (dx == 0 && dy < 0))
                {
                    dx = -dx;
                    dy = -dy;
                }

                int g = GCD(dx, Math.Abs(dy));
                int sx = dx / g;
                int sy = dy / g;

                int des = sx * y1 - sy * x1;

                int key1 = (sx << 12) | (sy + 2000);
                int key2 = (dx << 12) | (dy + 2000);

                Add(t, key1, des);
                Add(v, key2, des);
            }
        }

        return Count(t) - Count(v) / 2;
    }

    private void Add(Dictionary<int, Dictionary<int, int>> map, int key, int des)
    {
        if (!map.ContainsKey(key))
            map[key] = new Dictionary<int, int>();
        if (!map[key].ContainsKey(des))
            map[key][des] = 0;
        map[key][des]++;
    }

    private int Count(Dictionary<int, Dictionary<int, int>> map)
    {
        long ans = 0;

        foreach (var inner in map.Values)
        {
            long total = 0;
            foreach (var val in inner.Values)
                total += val;

            long rem = total;
            foreach (var val in inner.Values)
            {
                rem -= val;
                ans += val * rem;
            }
        }

        return (int)ans;
    }

    private int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int tmp = a % b;
            a = b;
            b = tmp;
        }
        return a;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[][] case1 = new int[][]
        {
            new int[] {-3, 2},
            new int[] {3, 0},
            new int[] {2, 3},
            new int[] {3, 2},
            new int[] {2, -3}
        };

        int[][] case2 = new int[][]
        {
            new int[] {0, 0},
            new int[] {1, 0},
            new int[] {0, 1},
            new int[] {2, 1}
        };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.CountTrapezoids(case1), 2),
            ResultTester.CheckResult<int>(solution.CountTrapezoids(case2), 1)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Number of Trapezoids II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}