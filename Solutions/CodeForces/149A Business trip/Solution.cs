// Business trip
namespace CompetitiveProgramming.CodeForces.Businesstrip;
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
        int k = int.Parse(Console.ReadLine()!);
        int[] arr = Console.ReadLine()!
                           .Split(' ')
                           .Select(int.Parse)
                           .ToArray();

        Array.Sort(arr);
        Array.Reverse(arr);

        int ans = 0;
        int cnt = 0;

        for (int i = 0; i < 12; i++)
        {
            if (ans >= k)
                break;

            ans += arr[i];
            cnt++;
        }

        if (ans < k)
            Console.WriteLine("-1");
        else
            Console.WriteLine(cnt);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Business trip");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}