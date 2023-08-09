// Word Ladder

/*
A transformation sequence from word beginWord to word endWord using a dictionary wordList is a sequence of words beginWord -> s1 -> s2 -> ... -> sk such that:

Every adjacent pair of words differs by a single letter.
Every si for 1 <= i <= k is in wordList. Note that beginWord does not need to be in wordList.
sk == endWord
Given two words, beginWord and endWord, and a dictionary wordList, return the number of words in the shortest transformation sequence from beginWord to endWord, or 0 if no such sequence exists.

 

Example 1:

Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log","cog"]
Output: 5
Explanation: One shortest transformation sequence is "hit" -> "hot" -> "dot" -> "dog" -> cog", which is 5 words long.


Example 2:

Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log"]
Output: 0
Explanation: The endWord "cog" is not in wordList, therefore there is no valid transformation sequence.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.WordLadder
{
    public class Solution
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (wordList.IndexOf(endWord) == -1) return 0;

            var set = CreateInitalList(beginWord, wordList);
            var rs = 2;

            if (set.Contains(endWord)) return rs;

            var dic = CreateDictionaryForLadder(wordList);
            var visited = new HashSet<string>();

            while(set.Count > 0)
            {
                rs++;
                visited.UnionWith(set);
                var set2 = new HashSet<string>();

                foreach (var item in set)
                {
                    for (int j = 0; j < dic[item].Count; j++)
                    {
                        if (!visited.Contains(dic[item][j]))
                        {
                            if (dic[item][j] == endWord) return rs;
                            set2.Add(dic[item][j]);
                        }
                    }
                }
                set = set2;
            }
            return 0;
        }
        private static Dictionary<string, List<string>> CreateDictionaryForLadder(IList<string> wordList)
        {
            var rs = new Dictionary<string, List<string>>();

            for (int i = 0; i < wordList.Count; i++)
            {
                var list = new List<string>();
                foreach (var item in rs)
                {
                    if (DiffInOnePosition(wordList[i], item.Key))
                    {
                        item.Value.Add(wordList[i]);
                        list.Add(item.Key);
                    }
                }
                rs.Add(wordList[i], list);
            }
            
            return rs;
        }
        private static bool DiffInOnePosition(string s0, string s1)
        {
            var count = 0;
            for (int i = 0; i < s0.Length; i++)
            {
                if (s0[i] != s1[i])
                {
                    count++;
                    if (count > 1) return false;
                }
            }
            return true;
        }
        private static HashSet<string> CreateInitalList(string s, IList<string> wordList)
        {
            var rs = new HashSet<string>();
            for (int i = 0; i < wordList.Count; i++)
            {
                if (DiffInOnePosition(s, wordList[i])) rs.Add(wordList[i]);
            }
            return rs;
        }
    }

    public class Test
    {
        public static bool[] TestCase()
        {
            string beginWord1 = "hit";
            string endWord1 = "cog";
            List<string> wordList1 = new()
            {
                "hot", "dot", "dog", "lot", "log", "cog"
            };

            string beginWord2 = "hit";
            string endWord2 = "cog";
            List<string> wordList2 = new()
            {
                "hot","dot","dog","lot","log"
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LadderLength(beginWord1, endWord1, wordList1), 5),
                ResultTester.CheckResult<int>(Solution.LadderLength(beginWord2, endWord2, wordList2), 0)
            };
            return results;
        }
    }
}