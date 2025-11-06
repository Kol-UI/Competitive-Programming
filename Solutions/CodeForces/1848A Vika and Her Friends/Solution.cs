// Vika and Her Friends
namespace CompetitiveProgramming.CodeForces.VikaandHerFriends;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);
            int k = int.Parse(firstLine[2]);
            
            string[] targetPosition = Console.ReadLine().Split();
            int targetX = int.Parse(targetPosition[0]);
            int targetY = int.Parse(targetPosition[1]);
            bool targetParity = (targetX + targetY) % 2 == 0;
            
            bool canEscape = true;
            
            for (int i = 0; i < k; i++)
            {
                string[] catcherPosition = Console.ReadLine().Split();
                int catcherX = int.Parse(catcherPosition[0]);
                int catcherY = int.Parse(catcherPosition[1]);
                bool catcherParity = (catcherX + catcherY) % 2 == 0;
                
                if (catcherParity == targetParity)
                {
                    canEscape = false;
                }
            }
            
            Console.WriteLine(canEscape ? "YES" : "NO");
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
        StyleHelper.Title("Vika and Her Friends");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}