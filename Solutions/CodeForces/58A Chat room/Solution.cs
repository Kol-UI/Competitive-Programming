// Chat room
namespace CompetitiveProgramming.CodeForces.Chatroom;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string word = Console.ReadLine()!;
        string target = "hello";
        int index = 0;

        foreach (char c in word)
        {
            if (c == target[index])
            {
                index++;
                if (index == target.Length)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
        }
        Console.WriteLine("NO");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Chat room");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}