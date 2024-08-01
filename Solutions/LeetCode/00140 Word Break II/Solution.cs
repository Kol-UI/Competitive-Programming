// Word Break II

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.WordBreakII
{
    public class Solution 
    {
        public IList<string> WordBreak(string s, IList<string> wordDict) 
        {
            HashSet<string> set = new HashSet<string>(wordDict);

            List<string> result = new List<string>();
            List<string> current = new List<string>();
            void Backtrack(int index)
            {
                if (index == s.Length)
                {
                    string s = String.Join(" ", current.ToArray());
                    result.Add(s);
                    return;
                }

                for (int i = index; i < s.Length; i++)
                {
                    string w = s.Substring(index, i - index + 1);
                    if (set.Contains(w)) 
                    {
                        current.Add(w);
                        Backtrack(i + 1);
                        current.RemoveAt(current.Count - 1);
                    }
                }
            }

            Backtrack(0);
            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Curry");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}