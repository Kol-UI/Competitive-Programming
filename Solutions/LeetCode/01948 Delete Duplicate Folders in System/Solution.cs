// Delete Duplicate Folders in System
namespace CompetitiveProgramming.LeetCode.DeleteDuplicateFoldersinSystem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    class TrieNode {
        public string Name;
        public Dictionary<string, TrieNode> Children = new();
        public string Serial = "";
        public bool IsDeleted = false;

        public TrieNode(string name) {
            Name = name;
        }
    }

    TrieNode root = new TrieNode("");
    Dictionary<string, List<TrieNode>> serialMap = new();
    public IList<IList<string>> DeleteDuplicateFolder(IList<IList<string>> paths) {
        foreach (var path in paths) {
            TrieNode current = root;
            foreach (var folder in path) {
                if (!current.Children.ContainsKey(folder)) {
                    current.Children[folder] = new TrieNode(folder);
                }
                current = current.Children[folder];
            }
        }

        Serialize(root);

        foreach (var entry in serialMap) {
            if (entry.Value.Count > 1) {
                foreach (var node in entry.Value) {
                    node.IsDeleted = true;
                }
            }
        }

        List<IList<string>> result = new();
        CollectPaths(root, new List<string>(), result);
        return result;
    }
    private string Serialize(TrieNode node) {
        if (node.Children.Count == 0) return "";

        List<string> parts = new();
        foreach (var child in node.Children.Values) {
            string childSerial = Serialize(child);
            parts.Add(child.Name + "(" + childSerial + ")");
        }

        parts.Sort();
        string serial = string.Join("", parts);
        node.Serial = serial;

        if (!serialMap.ContainsKey(serial)) {
            serialMap[serial] = new List<TrieNode>();
        }
        serialMap[serial].Add(node);

        return serial;
    }

    private void CollectPaths(TrieNode node, List<string> path, List<IList<string>> result) {
        foreach (var child in node.Children.Values) {
            if (child.IsDeleted) continue;

            path.Add(child.Name);
            result.Add(new List<string>(path));
            CollectPaths(child, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Delete Duplicate Folders in System");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}