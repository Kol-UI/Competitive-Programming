using System;
using CompetitiveProgramming.Helpers;
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

    public class Test
    {
        public static bool[] TestImplementTriePrefixTree()
        {
            LeetCode.ImplementTriePrefixTree.Trie obj_208 = new LeetCode.ImplementTriePrefixTree.Trie();
            string word1_208 = "Trie";
            StyleHelper.SubTitle(word1_208);
            obj_208.Insert(word1_208);
            bool searchResult1_208 = obj_208.Search(word1_208);
            bool startsWithResult1_208 = obj_208.StartsWith(word1_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult1_208, startsWithResult1_208);

            string word2_208 = "insert";
            StyleHelper.SubTitle(word2_208);
            obj_208.Insert(word2_208);
            bool searchResult2_208 = obj_208.Search(word2_208);
            bool startsWithResult2_208 = obj_208.StartsWith(word2_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult2_208, startsWithResult2_208);

            string word3_208 = "search";
            StyleHelper.SubTitle(word3_208);
            obj_208.Insert(word3_208);
            bool searchResult3_208 = obj_208.Search(word3_208);
            bool startsWithResult3_208 = obj_208.StartsWith(word3_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult3_208, startsWithResult3_208);
            
            StyleHelper.SubTitle(word3_208);
            obj_208.Insert(word3_208);
            bool searchResult3_2_208 = obj_208.Search(word3_208);
            bool startsWithResult3_2_208 = obj_208.StartsWith(word3_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult3_2_208, startsWithResult3_2_208);

            string word4_208 = "startsWith";
            StyleHelper.SubTitle(word4_208);
            obj_208.Insert(word4_208);
            bool searchResult4_208 = obj_208.Search(word4_208);
            bool startsWithResult4_208 = obj_208.StartsWith(word4_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult4_208, startsWithResult4_208);

            StyleHelper.SubTitle(word2_208);
            obj_208.Insert(word2_208);
            bool searchResult2_2_208 = obj_208.Search(word2_208);
            bool startsWithResult2_2_208 = obj_208.StartsWith(word2_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult2_2_208, startsWithResult2_2_208);

            StyleHelper.SubTitle(word3_208);
            obj_208.Insert(word3_208);
            bool searchResult3_3_208 = obj_208.Search(word3_208);
            bool startsWithResult3_3_208 = obj_208.StartsWith(word3_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult3_3_208, startsWithResult3_3_208);

            string word5_208 = "apple";
            StyleHelper.SubTitle(word5_208);
            obj_208.Insert(word5_208);
            bool searchResult5_208 = obj_208.Search(word5_208);
            bool startsWithResult5_208 = obj_208.StartsWith(word5_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult5_208, startsWithResult5_208);

            LeetCode.ImplementTriePrefixTree.Trie trie = new LeetCode.ImplementTriePrefixTree.Trie();
            StyleHelper.SubTitle(word5_208);
            trie.Insert(word5_208);
            bool test1_2_208 = trie.StartsWith(word5_208);
            bool test1_208 = trie.Search(word5_208);
            Console.WriteLine(test1_2_208);
            Console.WriteLine(test1_208);

            string word6_208 = "app";
            StyleHelper.SubTitle(word6_208);
            bool test2_208 = trie.Search(word6_208);
            Console.WriteLine(test2_208);

            bool[] results = new bool[]
            {
                true
            };
            return results;
        }
    }
}