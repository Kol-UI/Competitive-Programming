// Sum

namespace CompetitiveProgramming.CodeForces.Sum;

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

class Program
{
    //static void Main()
    static void Input()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] inputs = Console.ReadLine()!.Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            string result = Solution(a, b, c);

            Console.WriteLine(result);
        }
    }
    
    public static string Solution(int a, int b, int c)
    {
        int[] numbers = new int[3]{a, b, c};
        
        Array.Sort(numbers);

        if (numbers[2] == numbers[0] + numbers[1])
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(Program.Solution(1, 4, 3), "YES"),
            ResultTester.CheckResult<string>(Program.Solution(2, 5, 8), "NO"),
            ResultTester.CheckResult<string>(Program.Solution(9, 11, 20), "YES"),
            ResultTester.CheckResult<string>(Program.Solution(0, 0, 0), "YES"),
            ResultTester.CheckResult<string>(Program.Solution(20, 20, 20), "NO"),
            ResultTester.CheckResult<string>(Program.Solution(4, 12, 3), "NO"),
            ResultTester.CheckResult<string>(Program.Solution(15, 7, 8), "YES"),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
    }
}