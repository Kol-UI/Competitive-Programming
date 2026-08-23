// Event Planning
namespace CompetitiveProgramming.Kattis.EventPlanning;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int b = int.Parse(firstLine[1]);
        int h = int.Parse(firstLine[2]);
        int w = int.Parse(firstLine[3]);

        const int INF = 10000 * 200 * 100;
        int[] m_week = new int[w];
        for (int i = 0; i < w; i++)
            m_week[i] = INF;

        for (int i = 0; i < h; i++)
        {
            int p = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] availability = new int[w];
            for (int j = 0; j < w; j++)
                availability[j] = int.Parse(input[j]);

            if (p * n > b) continue;

            for (int j = 0; j < w; j++)
            {
                if (availability[j] >= n)
                {
                    if (p * n < m_week[j])
                        m_week[j] = p * n;
                }
            }
        }

        int ans = INF;
        for (int i = 0; i < w; i++)
        {
            if (m_week[i] < ans)
                ans = m_week[i];
        }

        Console.WriteLine(ans == INF ? "stay home" : ans.ToString());
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Event Planning");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}