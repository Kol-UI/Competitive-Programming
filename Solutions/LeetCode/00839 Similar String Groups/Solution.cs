// Similar String Groups

/*
Two strings X and Y are similar if we can swap two letters (in different positions) of X, so that it equals Y. Also two strings X and Y are similar if they are equal.

For example, "tars" and "rats" are similar (swapping at positions 0 and 2), and "rats" and "arts" are similar, but "star" is not similar to "tars", "rats", or "arts".

Together, these form two connected groups by similarity: {"tars", "rats", "arts"} and {"star"}.  Notice that "tars" and "arts" are in the same group even though they are not similar.  Formally, each group is such that a word is in the group if and only if it is similar to at least one other word in the group.

We are given a list strs of strings where every string in strs is an anagram of every other string in strs. How many groups are there?

 

Example 1:

Input: strs = ["tars","rats","arts","star"]
Output: 2

Example 2:

Input: strs = ["omv","ovm"]
Output: 1
 

Constraints:

1 <= strs.length <= 300
1 <= strs[i].length <= 300
strs[i] consists of lowercase letters only.
All words in strs have the same length and are anagrams of each other.

using System;
namespace CompetitiveProgramming.LeetCode.SimilarStringGroups
{
    public class Solution
    {
        private static int[]? parent;
        private static int[]? rank;
        
        public static int NumSimilarGroups(string[] strs)
        {
            if (strs.Length == 1) return 1;
            parent = new int[strs.Length];
            rank = new int[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                parent[i] = i;
                rank[i] = 1;
            }
            for (int i = 0; i < strs.Length - 1; i++)
            {
                for (int j = i + 1; j < strs.Length; j++)
                {
                    if (AreSimilar(strs[i], strs[j]))
                    {
                        Union(i, j);
                    }
                }
            }

            var result = new HashSet<int>();
            for (int i = 0; i < strs.Length; i++)
            {
                result.Add(Parent(i));
            }

            return result.Count;
        }

        private static void Union(int v1, int v2)
        {
            int p1 = Parent(v1);
            int p2 = Parent(v2);
            if (p1 == p2) return;
            if (rank[p1] >= rank[p2])
            {
                parent[p2] = p1;
                rank[p1] += rank[p2];
            }
            else
            {
                parent[p1] = p2;
                rank[p2] += rank[p1];
            }
        }

        private static int Parent(int v)
        {
            while (parent[v] != v)
            {
                parent[v] = parent[parent[v]];
                v = parent[v];
            }

            return v;
        }

        private static bool AreSimilar(string s1, string s2)
        {
            if (s1.Equals(s2)) return true;
            int diff = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i]) diff++;
                if (diff > 2) return false;
            }

            return true;
        }
    }
}
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SimilarStringGroups
{
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Similar String Groups");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}