// Make Them Equal
namespace CompetitiveProgramming.CodeForces.MakeThemEqual1154B;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        int n = int.Parse(input.Trim());
        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        SortedSet<long> s = new SortedSet<long>();
        for (int p = 0; p < n; p++)
        {
            s.Add(long.Parse(parts[p]));
        }

        if (s.Count <= 1)
        {
            Console.WriteLine("0");
        }
        else if (s.Count == 2)
        {
            long a = s.Min;
            long b = s.Max;
            if ((b - a) % 2 != 0)
            {
                Console.WriteLine(b - a);
            }
            else
            {
                Console.WriteLine((b - a) / 2);
            }
        }
        else if (s.Count == 3)
        {
            List<long> a = new List<long>(s);
            if (a[0] + a[2] != 2 * a[1])
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(a[1] - a[0]);
            }
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make Them Equal");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}