// Kefa and First Steps
namespace CompetitiveProgramming.CodeForces.KefaandFirstSteps;
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
        int n = int.Parse(Console.ReadLine()!);
        if(n == 0)
        {
            Console.WriteLine(0);
            return;
        }
        
        int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int cnt = 1, ans = 1;
        int cmp = numbers[0];
        
        for(int i = 1; i < n; i++)
        {
            if(numbers[i] >= cmp)
                cnt++;
            else
                cnt = 1;
            
            cmp = numbers[i];
            ans = Math.Max(ans, cnt);
        }
        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kefa and First Steps");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}