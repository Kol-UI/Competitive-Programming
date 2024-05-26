// Lucky?


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Lucky;

class Program
{
    /*
    static void Main(string[] args)
    {
        long t = long.Parse(Console.ReadLine()!);

        while (t-- > 0)
        {
            string s = Console.ReadLine()!;
            Console.WriteLine(Solve(s) ? "YES" : "NO");
        }
    }
    */
    
    public static bool Solve(string s)
    {
        long t = 0;
        for (int p = 0; p < 6; p++)
        {
            t += (p < 3 ? -1 : 1) * (s[p] - '0');
        }
        return t == 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(Program.Solve("123405"), false),
            ResultTester.CheckResult<bool>(Program.Solve("123456"), false),
            ResultTester.CheckResult<bool>(Program.Solve("666000"), false),
            ResultTester.CheckResult<bool>(Program.Solve("777111"), false),
            ResultTester.CheckResult<bool>(Program.Solve("-123321"), false),
            ResultTester.CheckResult<bool>(Program.Solve("-123411"), false),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lucky");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
    }
}