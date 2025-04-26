// Rudolf and the Ugly String
namespace CompetitiveProgramming.CodeForces.RudolfandtheUglyString;
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
            int n = int.Parse(Console.ReadLine()!);
            string str = Console.ReadLine()!;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (str[i] == 'p')
                {
                    if (i - 2 >= 0 && str[i - 2] == 'm' && str[i - 1] == 'a')
                        ans++;
                    else if (i + 2 < n && str[i + 1] == 'i' && str[i + 2] == 'e')
                        ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rudolf and the Ugly String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}