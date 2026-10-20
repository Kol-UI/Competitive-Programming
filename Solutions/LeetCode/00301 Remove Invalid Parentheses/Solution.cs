// Remove Invalid Parentheses
namespace CompetitiveProgramming.LeetCode.RemoveInvalidParentheses;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> RemoveInvalidParentheses(string s)
    {
        var result = new List<string>();
        var queue = new Queue<string>();
        var visited = new HashSet<string>();

        queue.Enqueue(s);
        visited.Add(s);

        bool found = false;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int k = 0; k < levelSize; k++)
            {
                string current = queue.Dequeue();

                if (IsValid(current))
                {
                    result.Add(current);
                    found = true;
                }

                if (found)
                    continue;

                for (int i = 0; i < current.Length; i++)
                {
                    char c = current[i];

                    if (c != '(' && c != ')')
                        continue;

                    ReadOnlySpan<char> n1 = current.AsSpan().Slice(0, i);
                    ReadOnlySpan<char> n2 = current.AsSpan().Slice(i + 1);

                    var next = n1.ToString() + n2.ToString();

                    if (visited.Add(next))
                    {
                        queue.Enqueue(next);
                    }
                }
            }

            if (found)
                break;
        }

        return result;
    }

    private bool IsValid(string s)
    {
        int balance = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                balance++;
            }
            else if (c == ')')
            {
                balance--;

                if (balance < 0)
                    return false;
            }
        }

        return balance == 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<string>>(solution.RemoveInvalidParentheses("()())()"), ["(())()","()()()"]),
            ResultTester.CheckResult<IList<string>>(solution.RemoveInvalidParentheses("(a)())()"), ["(a())()","(a)()()"]),
            ResultTester.CheckResult<IList<string>>(solution.RemoveInvalidParentheses(")("), [""]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove Invalid Parentheses");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}