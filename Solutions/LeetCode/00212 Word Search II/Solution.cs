// Word Search II
namespace CompetitiveProgramming.LeetCode.WordSearchII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        var trie = new TrieNode();
        for (var i = 0; i < words.Length; i++)
        {
        var t = trie;
        foreach (var c in words[i])
            t = t.Next[c - 'a'] ??= new TrieNode();
        t.WordIndex = i;
        }

        var result = new HashSet<int>();
        var n = board.Length;
        var m = board[0].Length;
        var visited = new bool[n, m];
        for (var i = 0; i < n; i++)
        {
        for (var j = 0; j < m; j++)
            Find(i, j, trie);
        }
        return result.Select(i => words[i]).ToArray();

        void Find(int i, int j, TrieNode t)
        {
        if (i < 0 || i >= n || j < 0 || j >= m || visited[i, j])
            return;

        var next = t.Next[board[i][j] - 'a'];
        if (next == null)
            return;

        if (next.WordIndex != -1)
            result.Add(next.WordIndex);

        visited[i, j] = true;
        Find(i - 1, j, next);
        Find(i + 1, j, next);
        Find(i, j - 1, next);
        Find(i, j + 1, next);
        visited[i, j] = false;
        }
    }

    private class TrieNode
    {
        public readonly TrieNode[] Next = new TrieNode[26];
        public int WordIndex = -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Word Search II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}