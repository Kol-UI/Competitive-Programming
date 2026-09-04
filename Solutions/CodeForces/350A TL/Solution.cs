// TL
namespace CompetitiveProgramming.CodeForces.TL;
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

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(parts[0]);
        int m = int.Parse(parts[1]);

        int correctMax = 0;
        int correctMin = 100;
        int temp = 0;
        bool possible = true;

        string[] nParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < n; i++)
        {
            temp = int.Parse(nParts[i]);
            if (temp > correctMax) correctMax = temp;
            if (temp < correctMin) correctMin = temp;
        }

        string[] mParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < m; i++)
        {
            temp = int.Parse(mParts[i]);
            if (temp <= correctMax || temp <= 2 * correctMin)
            {
                possible = false;
                break;
            }
        }

        if (correctMax < 2 * correctMin)
        {
            temp = 2 * correctMin;
        }
        else
        {
            temp = correctMax;
        }

        if (possible)
        {
            Console.WriteLine(temp);
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
        StyleHelper.Title("TL");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}