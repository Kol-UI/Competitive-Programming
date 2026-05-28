// Longest Common Suffix Queries
namespace CompetitiveProgramming.LeetCode.LongestCommonSuffixQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public class TrieNode
    {
        public int Index { get; set; } = -1;
        public Dictionary<char, TrieNode> Children { get; } = [];
    }

    public class Trie
    {
        private readonly TrieNode _root = new();

        public void AddWord(string word, int index)
        {
            var node = _root;

            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode();

                node = node.Children[c];
            }

            node.Index = index;
        }

        public int Search(string word, string[] wordsContainer)
        {
            var node = _root;

            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    break;

                node = node.Children[c];
            }

            if (node.Index != -1) return node.Index;

            var queue = new Queue<TrieNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var count = queue.Count;
                var index = int.MaxValue;
                var minLength = int.MaxValue;

                for (var i = 0; i < count; i++)
                {
                    var child = queue.Dequeue();

                    if (child.Index != -1)
                    {
                        if (wordsContainer[child.Index].Length < minLength)
                        {
                            minLength = wordsContainer[child.Index].Length;
                            index = child.Index;
                        }
                        else if (wordsContainer[child.Index].Length == minLength && child.Index < index)
                            index = child.Index;
                    }

                    foreach (var c in child.Children)
                        queue.Enqueue(c.Value);
                }

                if (index < int.MaxValue) return index;
            }

            return 0;
        }
    }

    public int[] StringIndices(string[] wordsContainer, string[] wordsQuery) 
    {
        var trie = new Trie();
        var result = new int[wordsQuery.Length];
        var set = new HashSet<string>();

        for (var i = 0; i < wordsContainer.Length; i++)
        {
            var word = wordsContainer[i];
            if (set.Contains(word)) continue;
            var array = word.ToCharArray();
            Array.Reverse(array);
            var reverse = new string(array);

            trie.AddWord(reverse, i);
            set.Add(word);
        }

        for (var i = 0; i < wordsQuery.Length; i++)
        {
            var word = wordsQuery[i];
            var array = word.ToCharArray();
            Array.Reverse(array);
            var reverse = new string(array);

            result[i] = trie.Search(reverse, wordsContainer);
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Common Suffix Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}