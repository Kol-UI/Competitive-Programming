// Make it Beautiful
namespace CompetitiveProgramming.CodeForces.MakeItBeautiful;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool ok = false;
            HashSet<int> s = new HashSet<int>(arr);
            if (s.Count > 1)
                ok = true;

            if (ok)
            {
                Console.WriteLine("YES");
                Array.Sort(arr);
                Array.Reverse(arr);
                int x = 0;
                int y = n - 1;
                for (int i = 0; i < n; i++)
                {
                    if ((i & 1) == 0)
                        Console.Write(arr[x++] + " ");
                    else
                        Console.Write(arr[y--] + " ");
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Make it Beautiful");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
	}
}