using System;
namespace CompetitiveProgramming.LeetCode.DesignAddandSearchWordsDataStructure
{
    /*
        Design a data structure that supports adding new words and finding if a string matches any previously added string.
        Implement the WordDictionary class:
        WordDictionary() Initializes the object.
        void addWord(word) Adds word to the data structure, it can be matched later.
        bool search(word) Returns true if there is any string in the data structure that matches word or false otherwise. word may contain dots '.' where dots can be matched with any letter.
        
        Example:

        Input
        ["WordDictionary","addWord","addWord","addWord","search","search","search","search"]
        [[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
        Output
        [null,null,null,null,false,true,true,true]

        Explanation
        WordDictionary wordDictionary = new WordDictionary();
        wordDictionary.addWord("bad");
        wordDictionary.addWord("dad");
        wordDictionary.addWord("mad");
        wordDictionary.search("pad"); // return False
        wordDictionary.search("bad"); // return True
        wordDictionary.search(".ad"); // return True
        wordDictionary.search("b.."); // return True


        public class WordDictionary 
        {
            record Node 
            {
                public bool IsWord { get; set; }

                public Node?[] Children { get; } = new Node?[26];
            }

            private readonly Node _root = new();

            public void AddWord(string word) 
            {
                var node = _root;
                foreach (var ch in word)
                {
                    node = node.Children[ch - 'a'] ??= new Node();
                }

                node.IsWord = true;
            }
            
            public bool Search(string word) 
            {
                bool Dfs(Node? node, ReadOnlySpan<char> word)
                {
                    for(var i = 0; i < word.Length; i++)
                    {
                        if (node is null)
                        {
                            return false;
                        }

                        if (word[i] == '.')
                        {
                            foreach (var child in node.Children)
                            {
                                if (Dfs(child, word[(i+1)..]))
                                {
                                    return true;
                                }
                            }

                            return false;
                        }
                        
                        if (node.Children[word[i] - 'a'] is null)
                        {
                            return false;
                        }

                        node = node.Children[word[i] - 'a'];
                    }

                    return node?.IsWord == true;
                }

                return Dfs(_root, word.AsSpan());
            }
        }
    */
}