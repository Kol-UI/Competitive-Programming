using System;
namespace CompetitiveProgramming.LeetCode.ImplementTriePrefixTree
{
    /*
        A trie (pronounced as "try") or prefix tree is a tree data structure used to efficiently store and retrieve keys in a dataset of strings. There are various applications of this data structure, such as autocomplete and spellchecker.
        Implement the Trie class:
        Trie() Initializes the trie object.
        void insert(String word) Inserts the string word into the trie.
        boolean search(String word) Returns true if the string word is in the trie (i.e., was inserted before), and false otherwise.
        boolean startsWith(String prefix) Returns true if there is a previously inserted string word that has the prefix prefix, and false otherwise.
        
        Example 1:
        Input
        ["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
        [[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
        Output
        [null, null, true, false, true, null, true]
        Explanation
        Trie trie = new Trie();
        trie.insert("apple");
        trie.search("apple");   // return True
        trie.search("app");     // return False
        trie.startsWith("app"); // return True
        trie.insert("app");
        trie.search("app");     // return True
    */

    /**
    * Your Trie object will be instantiated and called as such:
    * Trie obj = new Trie();
    * obj.Insert(word);
    * bool param_2 = obj.Search(word);
    * bool param_3 = obj.StartsWith(prefix);
    */
    public class Trie
    {
        private class TrieNode
        {
            public char Key { get; set; }
            public bool IsEndOfWord { get; set; }
            public Dictionary<char, TrieNode> Children { get; set; }

            public TrieNode(char key)
            {
                Key = key;
                Children = new Dictionary<char, TrieNode>();
            }
        }

        private TrieNode root;

        public Trie()
        {
            root = new TrieNode('*');
        }

        public void Insert(string word)
        {
            var current = root;
            foreach (var c in word)
            {
                if (!current.Children.TryGetValue(c, out var childNode))
                    current.Children[c] = childNode = new TrieNode(c);
                current = childNode;
            }
            current.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            var current = root;
            foreach (var c in word)
            {
                if (!current.Children.TryGetValue(c, out var childNode))
                    return false;
                current = childNode;
            }
            return current.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            var current = root;
            foreach (var c in prefix)
            {
                if (!current.Children.TryGetValue(c, out var child))
                    return false;
                current = child;
            }
            return true;
        }
    }
}