// Decoding
namespace CompetitiveProgramming.CodeForces.Decoding;
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
        int len = int.Parse(Console.ReadLine()!);
        string str = Console.ReadLine()!;
        if (len == 1)
            Console.Write(str[0]);
        else
        {
            List<char> v = new List<char>();
            v.Add(str[len - 2]);
            v.Add(str[len - 1]);

            int cnt = 2;
            for (int i = len - 3; i >= 0; i--)
            {
                v.Insert(cnt / 2, str[i]);
                cnt++;
            }

            Console.Write(string.Join("", v));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Push Dominoes");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}