// Bill Division
namespace CompetitiveProgramming.HackerRank.BillDivision;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

class Result
{
    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int fairShare = (bill.Sum() - bill[k]) / 2;
        int diff = b - fairShare;

        if (diff == 0)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(diff);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bill Division");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerRank, ProblemCategory.EasyHR);
    }
}