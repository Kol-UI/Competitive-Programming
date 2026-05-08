// Design an Ordered Stream
namespace CompetitiveProgramming.LeetCode.DesignanOrderedStream;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
public class OrderedStream
{
    int n;
    int ptr;
    string[] oder;
    public OrderedStream(int n)
    {
        this.n = n;
        ptr = 1;
        oder = new string[n];
    }

    public IList<string> Insert(int idKey, string value)
    {
        oder[idKey - 1] = value;
        List<string> temp = new List<string>();
        while (ptr <= n && oder[ptr - 1] != null)
        {
            temp.Add(oder[ptr - 1]);
            ptr++;
        }
        return temp;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Design an Ordered Stream");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}