// Sum of Prefix Scores of Strings

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofPrefixScoresofStrings
{
    public class Solution 
    {
        public class Trie
        {
            public int totalCount;
            public Dictionary<char, Trie> children;   

            public Trie()
            {
                totalCount = 0;
                children = new Dictionary<char, Trie>();
            }
        }

        public int[] SumPrefixScores(string[] words) 
        {
            var root = new Trie();
            var n = words.Length; 

            foreach(var word in words)
            {
                var temp = root;
                foreach(var ch in word)
                {
                    temp.children.TryAdd(ch, new Trie());
                    temp = temp.children[ch];
                    temp.totalCount += 1;
                }
            }

            var result = new int[n];
            for(int i = 0; i < n; ++i)
            {
                var temp = root;
                var count = 0;
        
                foreach(var ch in words[i])
                {
                    temp.children.TryAdd(ch, new Trie());
                    temp = temp.children[ch];
                    count += temp.totalCount;
                }

                result[i] = count;
            }

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Prefix Scores of Strings");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}