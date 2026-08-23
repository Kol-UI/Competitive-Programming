// Increasing Decreasing String
namespace CompetitiveProgramming.LeetCode.IncreasingDecreasingString;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string SortString(string s)
    {
        StringBuilder sb = new StringBuilder();
        var ss = s.ToCharArray();
        Array.Sort(ss);
        string direction = "asc";
        int pointer = 0;
        char prevChar = '.';
        while(sb.Length < ss.Length)
        {
            if(direction == "asc")
            {
                if(pointer == ss.Length)
                {
                    direction = "dsc";
                    prevChar = '.';
                    pointer--;
                }
                else
                {
                    if(prevChar != ss[pointer] && ss[pointer] != '?')
                    {
                        sb.Append(ss[pointer]);
                        prevChar = ss[pointer];
                        ss[pointer] = '?';
                    }
                    pointer++;
                }
            }
            else
            {
                if(pointer < 0)
                {
                    direction = "asc";
                    prevChar = '.';
                    pointer++;
                }
                else
                {
                    if(prevChar != ss[pointer] && ss[pointer] != '?')
                    {
                        sb.Append(ss[pointer]);
                        prevChar = ss[pointer];
                        ss[pointer] = '?';
                    }
                    pointer--;
                }
            }
        }
        return sb.ToString();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.SortString("aaaabbbbcccc"), "abccbaabccba"),
            ResultTester.CheckResult<string>(solution.SortString("rat"), "art"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Increasing Decreasing String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}