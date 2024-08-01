// Clone Graph

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CloneGraph
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> neighbors;

        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val) {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    }
    

    // Dictionary DFS

    public class Solution
    {
        public static Node CloneGraph(Node node)
        {
            if(node == null)
            {
                return null;
            }
            
            Dictionary<int, Node> visited = new();
            return DFS(node, visited);
        }

        private static Node DFS(Node node, Dictionary<int, Node> visited)
        {
            if(visited.ContainsKey(node.val))
            {
                return visited[node.val];
            }

            Node newNode = new Node(node.val, new List<Node>());
            visited.Add(node.val, newNode);

            foreach(var neighbor in node.neighbors)
            {
                newNode.neighbors.Add(DFS(neighbor, visited));
            }

            return newNode;
        }
    }
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Clone Graph");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}