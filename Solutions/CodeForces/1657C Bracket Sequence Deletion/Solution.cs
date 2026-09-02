// Bracket Sequence Deletion
namespace CompetitiveProgramming.CodeForces.BracketSequenceDeletion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

class Program
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        int t = int.Parse(tLine.Trim());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string s = Console.ReadLine().Trim();

            int cnt = 0;
            int rem = n;
            int i = 0;

            while (i < n - 1)
            {
                if (s[i] == '(' || (s[i] == ')' && s[i + 1] == ')'))
                {
                    cnt++;
                    rem -= 2;
                    i += 2;
                }
                else
                {
                    int j = i + 1;
                    while (j < n && s[j] != ')')
                    {
                        j++;
                    }

                    if (j < n)
                    {
                        cnt++;
                        int len = j - i + 1;
                        rem -= len;
                        i = j + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"{cnt} {rem}");
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
        StyleHelper.Title("Bracket Sequence Deletion");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}