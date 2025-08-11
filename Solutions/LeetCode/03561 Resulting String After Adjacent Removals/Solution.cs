// Resulting String After Adjacent Removals
namespace CompetitiveProgramming.LeetCode.ResultingStringAfterAdjacentRemovals;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private bool AreConcec(char a, char b)
    {
        var next = ((int)(a - 'a') + 1)%26;
        var prev = ((int)(a - 'a') - 1) == -1 ? 25: ((int)(a - 'a') - 1)%26;
        return (int)(b - 'a') == next || (int)(b - 'a') == prev;
    }

    public string ResultingString(string s)
    {
        if(s.Length == 1) return s; 
    
        var isRemoved = new List<bool>();
        for(int i = 0; i < s.Length; i++)
        {
            isRemoved.Add(false);
        }

        var start = 0;
        var end = 1;
        var nonRemovedLeft = new Stack<int>();

        while(end < s.Length)
        {
            if(AreConcec(s[start], s[end]))
            {
                isRemoved[start] = true;
                isRemoved[end] = true;
                if(nonRemovedLeft.Count > 0)
                {
                    start = nonRemovedLeft.Pop();
                    end++;
                }
                else
                {
                    start = end + 1;
                    end += 2;
                }
            }
            else
            {
                nonRemovedLeft.Push(start);
                nonRemovedLeft.Push(end);
                start = nonRemovedLeft.Pop();
                end++;
            }
        }

        var sol = new StringBuilder();
        for(int i = 0; i < isRemoved.Count; i++)
        {
            var removed = isRemoved[i];
            if(!removed)
            {
                sol.Append(s[i]);
            }
        }

        return sol.ToString();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Resulting String After Adjacent Removals");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}