// Dreamoon and WiFi
namespace CompetitiveProgramming.CodeForces.DreamoonandWiFi;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Globalization;

class Solution
{
    static double Solve(int n)
    {
        double output = 1;
        for (int p = 2; p <= n; p++) output *= p;
        return output;
    }

    static void Main()
    {
        string sent = Console.ReadLine();
        string received = Console.ReadLine();

        int desired = 0;
        for (int p = 0; p < sent.Length; p++)
            desired += (sent[p] == '+') ? 1 : -1;

        int sure = 0, uncertain = 0;
        for (int p = 0; p < received.Length; p++)
        {
            if (received[p] == '+') sure++;
            else if (received[p] == '-') sure--;
            else if (received[p] == '?') uncertain++;
        }

        int diff = Math.Abs(desired - sure);

        if (diff > uncertain || (diff % 2 != uncertain % 2))
        {
            Console.WriteLine("0.000000000000");
        }
        else
        {
            int dir = (uncertain + diff) / 2;
            double probability = Solve(uncertain) / Solve(dir) / Solve(uncertain - dir);
            for (int p = 0; p < uncertain; p++) probability /= 2.0;
            Console.WriteLine(probability.ToString("F11", CultureInfo.InvariantCulture));
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
        StyleHelper.Title("Dreamoon and WiFi");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}