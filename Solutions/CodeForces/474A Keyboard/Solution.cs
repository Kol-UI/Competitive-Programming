// Keyboard
namespace CompetitiveProgramming.CodeForces.Keyboard;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string keyboard = "qwertyuiopasdfghjkl;zxcvbnm,./";
        string direction = Console.ReadLine()!;
        string message = Console.ReadLine()!;
        int offset = direction == "R" ? -1 : 1;
        System.Text.StringBuilder result = new System.Text.StringBuilder();
        
        foreach (char c in message)
        {
            int index = keyboard.IndexOf(c);
            result.Append(keyboard[index + offset]);
        }
        
        Console.WriteLine(result.ToString());
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Keyboard");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}