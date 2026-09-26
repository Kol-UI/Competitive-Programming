// Water Journal
namespace CompetitiveProgramming.Kattis.WaterJournal;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Text;

class Solution
{
    static void Main()
    {
        string line1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line1)) return;

        string[] parts1 = line1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(parts1[0]);
        int a = int.Parse(parts1[1]);
        int b = int.Parse(parts1[2]);

        bool acov = false;
        bool bcov = false;

        for (int i = 0; i < n - 1; i++)
        {
            string line = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(line)) line = Console.ReadLine();

            int x = int.Parse(line.Trim());
            if (x == a)
            {
                acov = true;
            }
            if (x == b)
            {
                bcov = true;
            }
        }

        if (!acov && !bcov && a != b)
        {
            Console.WriteLine(-1);
        }
        else if (!acov)
        {
            Console.WriteLine(a);
        }
        else if (!bcov)
        {
            Console.WriteLine(b);
        }
        else
        {
            StringBuilder sb = new StringBuilder();
            for (int i = a; i <= b; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.Write(sb.ToString());
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Water Journal");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}