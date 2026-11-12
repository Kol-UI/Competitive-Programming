// Anton and currency you all know
namespace CompetitiveProgramming.CodeForces.Antonandcurrencyyouallknow;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        int target = -1;
        string s = Console.ReadLine();
        char[] arr = s.ToCharArray();

        for (int p = arr.Length - 1; p >= 0; p--)
        {
            if ((arr[p] - '0') % 2 != 0) continue;
            else if (target == -1 || arr[p] <= arr[arr.Length - 1]) target = p;
        }

        if (target >= 0)
        {
            char temp = arr[arr.Length - 1];
            arr[arr.Length - 1] = arr[target];
            arr[target] = temp;
            Console.WriteLine(new string(arr));
        }
        else
        {
            Console.WriteLine(target);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Anton and currency you all know");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}