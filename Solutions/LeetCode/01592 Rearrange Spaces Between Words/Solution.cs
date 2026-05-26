// Rearrange Spaces Between Words
namespace CompetitiveProgramming.LeetCode.RearrangeSpacesBetweenWords;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ReorderSpaces(string text)
    {
        int len = text.Length, spaceCnt = 0, start = 0;
        List<string> strs = new();

        for(int i = 0; i < len; i++)
        {
            char c = text[i];
            if(c == ' ')
            {
                spaceCnt++;
                if(i-start > 0)
                {
                    int curLen = i-start;
                    if(curLen > 0)
                        strs.Add(text.Substring(start, i-start));
                }

                start = i+1;
            }
            else if(i == len-1)
            {
                int curLen = i-start+1;
                if(curLen > 0)
                    strs.Add(text.Substring(start, curLen));
            }
        }
        
        int strCnt = strs.Count;
        int gapCnt = (strCnt > 1 ? spaceCnt/(strCnt-1) : spaceCnt);
        int rest = spaceCnt - gapCnt*(strCnt-1);
        string res = "", gapStr = new string(' ', gapCnt), restStr = new string(' ', rest);
        for(int i = 0; i < strs.Count; i++)
        {
            res += strs[i];
            Console.WriteLine($"string : {strs[i]}");
            if(i < strs.Count-1)
                res += gapStr;
            else
                res += restStr;
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.ReorderSpaces("  this   is  a sentence "), "this   is   a   sentence"),
            ResultTester.CheckResult<string>(solution.ReorderSpaces(" practice   makes   perfect"), "practice   makes   perfect "),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rearrange Spaces Between Words");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}