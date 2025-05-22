// Odd Selection
namespace CompetitiveProgramming.CodeForces.OddSelection;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int x = int.Parse(input[1]);
            int odd = 0, even = 0;
            string[] nums = Console.ReadLine()!.Split();
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(nums[i]);
                if ((temp & 1) == 1)
                    odd++;
                else
                    even++;
            }
            bool ok = true;
            if (odd == 0 || (x == n && odd % 2 == 0) || (n == odd && x % 2 == 0))
                ok = false;
            Console.WriteLine(ok ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Odd Selection");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}