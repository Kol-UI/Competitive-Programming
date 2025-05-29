// Even-Odd Game
namespace CompetitiveProgramming.CodeForces.EvenOddGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
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
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (int x in nums)
            {
                if ((x & 1) == 1) odd.Add(x);
                else even.Add(x);
            }
            odd.Sort((a, b) => b.CompareTo(a));
            even.Sort((a, b) => b.CompareTo(a));
            int i = 0, j = 0;
            long alice = 0, bob = 0;
            int evenCount = even.Count, oddCount = odd.Count;
            for (int x = 0; i < evenCount || j < oddCount; x++)
            {
                if ((x & 1) == 0)
                {
                    if (i < evenCount && j < oddCount)
                    {
                        if (even[i] >= odd[j]) alice += even[i++];
                        else j++;
                    }
                    else if (i < evenCount) alice += even[i++];
                    else j++;
                }
                else
                {
                    if (i < evenCount && j < oddCount)
                    {
                        if (even[i] <= odd[j]) bob += odd[j++];
                        else i++;
                    }
                    else if (j < oddCount) bob += odd[j++];
                    else i++;
                }
            }
            Console.WriteLine(alice > bob ? "Alice" : (alice < bob ? "Bob" : "Tie"));
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
        StyleHelper.Title("Even-Odd Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}