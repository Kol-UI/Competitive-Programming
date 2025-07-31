// Yaroslav and Permutations
namespace CompetitiveProgramming.Codeforces.YaroslavandPermutations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        foreach (int num in nums)
        {
            if (counts.ContainsKey(num)) counts[num]++;
            else counts[num] = 1;
        }

        bool possible = true;
        foreach (var pair in counts)
        {
            if (pair.Value > (n + 1) / 2)
            {
                possible = false;
                break;
            }
        }

        Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Yaroslav and Permutations");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}