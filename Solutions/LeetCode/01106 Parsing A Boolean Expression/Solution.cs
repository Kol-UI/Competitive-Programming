// Parsing A Boolean Expression

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ParsingABooleanExpression
{
    public class Solution
    {
        public bool ParseBoolExpr(string expression)
        {
            var stack = new Stack<bool?>();

            for (var i = 1; i <= expression.Length; i++)
            {
                switch (expression[^i])
                {
                    case ',': break;
                    case '(': break;
                    case ')': stack.Push(null); break;
                    case 't': stack.Push(true); break;
                    case 'f': stack.Push(false); break;

                    case '&':
                        var and = true;
                        while (stack.TryPop(out var pop) && pop != null)
                            and &= pop.Value;
                        stack.Push(and);
                        break;

                    case '|':
                        var or = false;
                        while (stack.TryPop(out var pop) && pop != null)
                            or |= pop.Value;
                        stack.Push(or);
                        break;

                    case '!':
                        var not = false;
                        while (stack.TryPop(out var pop) && pop != null)
                            not = !pop.Value;
                        stack.Push(not);
                        break;
                }
            }

            return stack.Pop()!.Value;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            var solution = new Solution();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(solution.ParseBoolExpr("&(|(f))"), false),
                ResultTester.CheckResult<bool>(solution.ParseBoolExpr("|(f,f,f,t)"), true),
                ResultTester.CheckResult<bool>(solution.ParseBoolExpr("!(&(f,t))"), true)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Parsing A Boolean Expression");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}