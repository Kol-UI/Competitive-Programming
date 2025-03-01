// Recover a Tree From Preorder Traversal
namespace CompetitiveProgramming.LeetCode.RecoveraTreeFromPreorderTraversal;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#nullable disable
public class Solution
{
    public TreeNode RecoverFromPreorder(string traversal)
    {
        if(string.IsNullOrEmpty(traversal)) return null;
        
        int dashes = 0;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        int i = 0;
        while(i < traversal.Length)
        {
            if(traversal[i] == '-')
            {
                dashes++;
                i++;
            }
            else
            {
                int j = i;
                while(j < traversal.Length && traversal[j] != '-') j++;

                int val = int.Parse(traversal.Substring(i, j - i));
                TreeNode node = new TreeNode(val);

                while(stack.Count > 0 && stack.Count > dashes) stack.Pop();
                
                if(stack.Count > 0)
                {
                    if(stack.Peek().left == null)
                        stack.Peek().left = node;
                    else
                        stack.Peek().right = node;

                    stack.Push(node);
                }

                stack.Push(node);
                
                i = j;
                dashes = 0;
            }
        }

        return stack.Last();
    }
}
#nullable enable
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Recover a Tree From Preorder Traversal");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}