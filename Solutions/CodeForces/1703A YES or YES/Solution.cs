// YES or YES
namespace CompetitiveProgramming.CodeForces.YESorYES;

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

class Program
{
    //static void Main()
    static void Problem()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string str = Console.ReadLine()!;

            string result = Solution(str, "YES");

            Console.WriteLine(result);
        }
    }

    public static string Solution(string string1, string string2)
    {
        bool areEqual = String.Equals(string1, string2, StringComparison.OrdinalIgnoreCase);
        if (areEqual == true)
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
            ResultTester.CheckResult<string>(Program.Solution("YES", "YES"), "YES"),
            ResultTester.CheckResult<string>(Program.Solution("yES", "YES"), "YES"),
            ResultTester.CheckResult<string>(Program.Solution("yes", "YES"), "YES"),
            ResultTester.CheckResult<string>(Program.Solution("Yes", "YES"), "YES"),
            ResultTester.CheckResult<string>(Program.Solution("YeS", "YES"), "YES"),
            ResultTester.CheckResult<string>(Program.Solution("Noo", "YES"), "NO"),
            ResultTester.CheckResult<string>(Program.Solution("orZ", "YES"), "NO"),
            ResultTester.CheckResult<string>(Program.Solution("yEz", "YES"), "NO"),
            ResultTester.CheckResult<string>(Program.Solution("Yas", "YES"), "NO"),
            ResultTester.CheckResult<string>(Program.Solution("XES", "YES"), "NO"),
        };
        return results;
    }
}