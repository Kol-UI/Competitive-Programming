// Evaluate the Bracket Pairs of a String
namespace CompetitiveProgramming.LeetCode.EvaluatetheBracketPairsofaString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string Evaluate(string s, IList<IList<string>> knowledge)
    {
        var dic = BuildHash(knowledge);
        var charesult = new List<char>();
        var keyIsReaded = false;
        var keyList = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (keyIsReaded)
            {
                if (s[i] == ')')
                {
                    var key = new string(keyList.ToArray());
                    if (dic.ContainsKey(key))
                    {
                        charesult.AddRange(dic[key]);
                    }
                    else
                    {
                        charesult.Add('?');
                    }
                    keyList.Clear();
                    keyIsReaded = false;
                }
                else
                {
                    keyList.Add(s[i]);
                }
            }
            else
            {
                if (s[i] != '(')
                {
                    charesult.Add(s[i]);
                }
                else
                {
                    keyIsReaded = true;
                }
            }
        }
        var result =  new string(charesult.ToArray());
        return result;
    }

    private Dictionary<string, char[]> BuildHash(IList<IList<string>> knowledge)
    {
        var result = new Dictionary<string, char[]>();
        for (int i = 0; i < knowledge.Count; i++)
        {
            result.Add(knowledge[i][0], knowledge[i][1].ToCharArray());
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.Evaluate("(name)is(age)yearsold", [["name","bob"],["age","two"]]), "bobistwoyearsold"),
            ResultTester.CheckResult<string>(solution.Evaluate("hi(name)", [["a","b"]]), "hi?"),
            ResultTester.CheckResult<string>(solution.Evaluate("(a)(a)(a)aaa", [["a","yes"]]), "yesyesyesaaa"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Evaluate the Bracket Pairs of a String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}