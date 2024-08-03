// N-ary Tree Level Order Traversal

/*
Given an n-ary tree, return the level order traversal of its nodes' values.

Nary-Tree input serialization is represented in their level order traversal, each group of children is separated by the null value (See examples).

 

Example 1:
Input: root = [1,null,3,2,4,null,5,6]
Output: [[1],[3,2,4],[5,6]]
Example 2:
Input: root = [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]
Output: [[1],[2,3,4,5],[6,7,8,9,10],[11,12,13],[14]]
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NaryTreeLevelOrderTraversal
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
    

    public class Solution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var queue = (root == null) ? new List<Node>() : new List<Node>(){root};
            var res = new List<IList<int>>();
            
            while(queue.Count != 0)
            {
                res.Add((from node in queue select node.val).ToList());
                queue = (from node in queue from child in node.children select child).ToList();
            }

            return res;
            
        }
    }
    */

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("N-ary Tree Level Order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}