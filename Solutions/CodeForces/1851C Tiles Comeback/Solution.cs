// Tiles Comeback
namespace CompetitiveProgramming.CodeForces.TilesComeback;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            var input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int n = input[0], k = input[1];
            var v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            
            int s = 0, e = 0;
            int l = 0, r = n - 1;
            
            while (s < k && l < n)
            {
                if (v[l] == v[0]) s++;
                l++;
            }
            
            while (e < k && r >= l)
            {
                if (v[r] == v[n - 1]) e++;
                r--;
            }
            
            Console.WriteLine((s == k && e == k) || (v[0] == v[n - 1] && (s + e) >= k) ? "YES" : "NO");
        }
    }
}


public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Tiles Comeback");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}