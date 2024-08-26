// N-ary Tree Postorder Traversal

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NaryTreePostorderTraversal
{
    /*
    public class Solution
    {
        public IList<int> Postorder(Node root) {
            IList<int> result = new List<int>();
            if (root == null) {
                return result;
            }

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0) {
                Node node = stack.Pop();
                result.Insert(0, node.val);

                foreach (var child in node.children) {
                    stack.Push(child);
                }
            }

            return result;
        }
    }
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("N-ary Tree Postorder Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}