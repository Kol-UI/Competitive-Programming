// Number of Atoms

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofAtoms
{
    public class Solution
    {
        public string CountOfAtoms(string formula)
        {
            Stack<(string, int)> stack = new Stack<(string, int)>();
            Stack<(string, int)> stack2 = new Stack<(string, int)>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string elem = string.Empty;
            string num = string.Empty;
            bool findNum = false;
            foreach (char ch in formula)
            {
                if (findNum)
                {
                    if (char.IsDigit(ch))
                    {
                        num += ch;
                        continue;
                    }
                    else
                    {
                        ComputeNumAndElement(num);
                        num = string.Empty;
                        findNum = false;
                    }
                }

                if (char.IsDigit(ch))
                {
                    if (!string.IsNullOrEmpty(elem))
                    {
                        stack.Push((elem, 1));
                        elem = string.Empty;
                    }
                    num += ch;
                    findNum = true;
                }
                else if (char.IsUpper(ch))
                {
                    if (!string.IsNullOrEmpty(elem))
                    {
                        stack.Push((elem, 1));
                        elem = string.Empty;
                    }
                    elem += ch;
                }
                else if (char.IsLower(ch))
                {
                    elem += ch;
                }
                else
                {
                    if (!string.IsNullOrEmpty(elem))
                    {
                        stack.Push((elem, 1));
                        elem = string.Empty;
                    }
                    stack.Push(($"{ch}", 0));
                }
            }
            if (!string.IsNullOrEmpty(elem))
            {
                stack.Push((elem, 1));
            }
            ComputeNumAndElement(num);

            foreach (var item in stack)
            {
                if (item.Item1 == "(" ||  item.Item1 == ")")
                {
                    continue;
                }
                if (dict.TryGetValue(item.Item1 , out var value))
                {
                    dict[item.Item1] = value + item.Item2;
                }
                else
                {
                    dict[item.Item1] = item.Item2;
                }
            }

            List<(string, int)> list = new List<(string, int)>();
            foreach (var item in dict)
            {
                list.Add((item.Key, item.Value));
            }
            list.Sort((a, b) =>  a.Item1.CompareTo(b.Item1));

            string result = "";
            foreach (var item in list)
            {
                result += item.Item2 > 1?$"{item.Item1}{item.Item2}": $"{item.Item1}";
            }
            return result;

            void ComputeNumAndElement(string num)
            {
                if (!string.IsNullOrEmpty(num) && int.TryParse(num, out int value))
                {
                    var s = stack.Pop();
                    if (s.Item1 == ")")
                    {
                        while (stack.Peek().Item1 != "(")
                        {
                            var pop = stack.Pop();
                            pop.Item2 *= value;
                            stack2.Push(pop);
                        }
                        stack.Pop();
                        while (stack2.Count > 0)
                        {
                            stack.Push(stack2.Pop());
                        }
                    }
                    else
                    {
                        s.Item2 *= value;
                        stack.Push(s);
                    }
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Atoms");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}