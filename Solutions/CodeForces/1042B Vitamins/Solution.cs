// Vitamins
namespace CompetitiveProgramming.CodeForces.Vitamins;
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
        const long XX = 1000000000;
        long n = long.Parse(Console.ReadLine());

        long a = XX, b = XX, c = XX;
        long ab = XX, ac = XX, bc = XX;
        long abc = XX;

        for (long i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            long cost = long.Parse(input[0]);
            string s = input[1];

            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            s = new string(arr);

            if (s == "A")
            {
                if (cost < a) a = cost;
            }
            else if (s == "B")
            {
                if (cost < b) b = cost;
            }
            else if (s == "C")
            {
                if (cost < c) c = cost;
            }
            else if (s == "AB")
            {
                if (cost < ab) ab = cost;
                if (cost < a) a = cost;
                if (cost < b) b = cost;
            }
            else if (s == "AC")
            {
                if (cost < ac) ac = cost;
                if (cost < a) a = cost;
                if (cost < c) c = cost;
            }
            else if (s == "BC")
            {
                if (cost < bc) bc = cost;
                if (cost < b) b = cost;
                if (cost < c) c = cost;
            }
            else if (s == "ABC")
            {
                if (cost < abc) abc = cost;
                if (cost < a) a = cost;
                if (cost < b) b = cost;
                if (cost < c) c = cost;
            }
        }

        long mc = a + b + c;
        if (ab + c < mc) mc = ab + c;
        if (ac + b < mc) mc = ac + b;
        if (bc + a < mc) mc = bc + a;
        if (abc < mc) mc = abc;

        if (mc >= XX) mc = -1;
        Console.WriteLine(mc);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Vitamins");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}