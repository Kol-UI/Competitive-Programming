// Maximum Number of Non-Overlapping Substrings
namespace CompetitiveProgramming.LeetCode.MaximumNumberofNonOverlappingSubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    class Seg
    {
        public int left;
        public int right;

        public Seg(int left = -1, int right = -1)
        {
            this.left = left;
            this.right = right;
        }
    }

    public IList<string> MaxNumOfSubstrings(string s)
    {
        Seg[] seg = new Seg[26];

        for (int i = 0; i < 26; i++)
        {
            seg[i] = new Seg();
        }

        for (int i = 0; i < s.Length; i++)
        {
            int charIdx = s[i] - 'a';

            if (seg[charIdx].left == -1)
            {
                seg[charIdx].left = seg[charIdx].right = i;
            }
            else
            {
                seg[charIdx].right = i;
            }
        }

        for (int i = 0; i < 26; i++)
        {
            if (seg[i].left != -1)
            {
                int j = seg[i].left;

                while (j <= seg[i].right)
                {
                    int charIdx = s[j] - 'a';

                    if (seg[i].left <= seg[charIdx].left &&
                        seg[charIdx].right <= seg[i].right)
                        {
                    }
                    else
                    {
                        seg[i].left = Math.Min(seg[i].left, seg[charIdx].left);
                        seg[i].right =
                            Math.Max(seg[i].right, seg[charIdx].right);
                        j = seg[i].left;
                    }

                    j++;
                }
            }
        }

        Array.Sort(seg, (a, b) =>
        {
            if (a.right == b.right)
            {
                return b.left.CompareTo(a.left);
            }

            return a.right.CompareTo(b.right);
        });

        IList<string> ans = new List<string>();
        int end = -1;

        foreach (Seg segment in seg)
        {
            int left = segment.left;
            int right = segment.right;

            if (left == -1) continue;

            if (end == -1 || left > end)
            {
                end = right;
                ans.Add(s.Substring(left, right - left + 1));
            }
        }

        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<string>>(solution.MaxNumOfSubstrings("adefaddaccc"), ["e","f","ccc"]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Non-Overlapping Substrings");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}