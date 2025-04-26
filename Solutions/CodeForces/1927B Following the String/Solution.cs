// Following the String
namespace CompetitiveProgramming.CodeForces.FollowingtheString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Dictionary<int, Queue<char>> x = new Dictionary<int, Queue<char>>();

            for (int i = 0; i < 26; i++)
            {
                if (!x.ContainsKey(0))
                    x[0] = new Queue<char>();
                x[0].Enqueue((char)('a' + i));
            }

            foreach (int num in v)
            {
                char c = x[num].Dequeue();
                Console.Write(c);

                if (!x.ContainsKey(num + 1))
                    x[num + 1] = new Queue<char>();
                x[num + 1].Enqueue(c);
            }
            Console.WriteLine();
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Following the String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}
