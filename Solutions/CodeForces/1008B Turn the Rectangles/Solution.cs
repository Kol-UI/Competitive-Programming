// Turn the Rectangles
namespace CompetitiveProgramming.CodeForces.TurntheRectangles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int w, h, mx = int.MaxValue;
        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()!.Split();
            w = int.Parse(input[0]);
            h = int.Parse(input[1]);
            
            if (w < h)
            {
                int temp = w;
                w = h;
                h = temp;
            }
            
            if (w <= mx)
            {
                mx = w;
            }
            else if (h <= mx)
            {
                mx = h;
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }
        }
        
        Console.WriteLine("YES");
    }
}

public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Turn the Rectangles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}