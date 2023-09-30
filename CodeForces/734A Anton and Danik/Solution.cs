// Anton and Danik

using System;
using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.AntonandDanik;

class Program
{
    //static void Main()
    static void Solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        string gameResults = Console.ReadLine()!;
        
        int antonWins = 0;
        int danikWins = 0;
        
        foreach (char result in gameResults)
        {
            if (result == 'A')
                antonWins++;
            else if (result == 'D')
                danikWins++;
        }

        if (antonWins > danikWins)
            Console.WriteLine("Anton");
        else if (danikWins > antonWins)
            Console.WriteLine("Danik");
        else
            Console.WriteLine("Friendship");
    }
}

class Test
{
    public static string DetermineWinner(int n, string gameResults)
    {
        int antonWins = 0;
        int danikWins = 0;

        foreach (char result in gameResults)
        {
            if (result == 'A')
                antonWins++;
            else if (result == 'D')
                danikWins++;
        }

        if (antonWins > danikWins)
            return "Anton";
        else if (danikWins > antonWins)
            return "Danik";
        else
            return "Friendship";
    }

    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(Test.DetermineWinner(5, "ADADA"), "Anton"),
            ResultTester.CheckResult<string>(Test.DetermineWinner(4, "DADA"), "Friendship"),
            ResultTester.CheckResult<string>(Test.DetermineWinner(6, "AADADD"), "Friendship"),
            ResultTester.CheckResult<string>(Test.DetermineWinner(1, "A"), "Anton"),
            ResultTester.CheckResult<string>(Test.DetermineWinner(2, "DD"), "Danik"),
        };
        return results;
    }
}