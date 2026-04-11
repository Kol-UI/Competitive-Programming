// Speed Limit
namespace CompetitiveProgramming.Kattis.SpeedLimit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == -1)
            {
                return;
            }
            
            int prev = 0;
            int miles = 0;
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int speed = int.Parse(input[0]);
                int curr = int.Parse(input[1]);
                
                miles += speed * (curr - prev);
                prev = curr;
            }
            
            Console.WriteLine($"{miles} miles");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Speed Limit");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}