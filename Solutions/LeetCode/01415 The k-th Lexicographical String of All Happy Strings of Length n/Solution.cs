// The k-th Lexicographical String of All Happy Strings of Length n
namespace CompetitiveProgramming.LeetCode.ThekthLexicographicalStringofAllHappyStringsofLengthn;

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string GetHappyString(int n, int k)
    {
        backtrack("", n);
        
        if(lst.Count >= k)
            return lst[k-1];
        else return "";
    }

    private List<string> lst = new();

    private void backtrack(string str, int n)
    {
        if(str.Length == n)
        {
            lst.Add(new string(str));
            return;
        }

        for(int i = 0; i < 3; i++)
        {
            char character = (char)(i+'a');
            if((str.Length > 0 && str[str.Length - 1] != character) || str.Length == 0)
            {
                backtrack(str+character, n);
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("The k-th Lexicographical String of All Happy Strings of Length n");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}