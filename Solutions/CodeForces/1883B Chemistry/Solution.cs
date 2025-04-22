// Chemistry
namespace CompetitiveProgramming.CodeForces.Chemistry;
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
            int k = int.Parse(input[1]);
            string str = Console.ReadLine()!;
            int[] freq = new int[26];
            
            foreach (char c in str)
            {
                freq[c - 'a']++;
            }

            int cnt = 0;
            foreach (int count in freq)
            {
                cnt += (count % 2);
            }
            
            cnt -= k;
            bool ok = cnt <= 1;
            Console.WriteLine(ok ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Chemistry");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}