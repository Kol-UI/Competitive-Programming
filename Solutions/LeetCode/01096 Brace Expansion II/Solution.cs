// Brace Expansion II
namespace CompetitiveProgramming.LeetCode.BraceExpansionII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> BraceExpansionII(string expression)
    {
        Stack<HashSet<string>> stack = [];
        Stack<char> ops = [];

        for (int i = 0; i < expression.Length; i++)
        {
            var c = expression[i];

            switch (c)
            {
                case '{':
                    {
                        if (i > 0 && expression[i - 1] == '}')
                        {
                            ops.Push('*');
                        }

                        ops.Push('{');
                        break;
                    }
                case '}':
                    {
                        char op;
                        while ((op = ops.Pop()) != '{')
                        {
                            var set = stack.Pop();

                            if (op == ',')
                            {
                                stack.Peek().UnionWith(set);
                            }
                            else
                            {
                                var master = stack.Pop();
                                var new_set = Helper(master, set);
                                stack.Push(new_set);
                            }
                        }
                        break;
                    }
                case ',':
                    {
                        while (ops.Peek() == '*')
                        {
                            ops.Pop();
                            var second = stack.Pop();
                            var first = stack.Pop();
                            var new_set = Helper(first, second);
                            stack.Push(new_set);
                        }

                        ops.Push(',');
                        break;
                    }
                default:
                    {
                        HashSet<string> symb = [c.ToString()];

                        if (i > 0 && expression[i - 1] == '}')
                        {
                            var new_set = Helper(stack.Pop(), symb);
                            stack.Push(new_set);
                        }
                        else
                        {
                            stack.Push(symb);
                        }

                        if (i < expression.Length - 1 && expression[i + 1] != ',' && expression[i + 1] != '}')
                        {
                            ops.Push('*');
                        }
                        break;
                    }
            }
        }

        while (stack.Count > 1)
        {
            var second = stack.Pop();
            var first = stack.Pop();
            var new_set = Helper(first, second);
            stack.Push(new_set);
        }

        if (stack.Count == 0)
            return [];

        return stack.Pop().OrderBy(x => x).ToList();
    }

    public static HashSet<string> Helper(HashSet<string> first, HashSet<string> second)
    {
        HashSet<string> new_set = [];
        foreach (var f in first)
        {
            foreach (var s in second)
            {
                new_set.Add(f + s);
            }
        }
        return new_set;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<string>>(solution.BraceExpansionII("{a,b}{c,{d,e}}"), ["ac","ad","ae","bc","bd","be"]),
            ResultTester.CheckResult<IList<string>>(solution.BraceExpansionII("{{a,z},a{b,c},{ab,z}}"), ["a","ab","ac","z"]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Brace Expansion II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}