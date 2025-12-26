// Deepest Leaves Sum
namespace CompetitiveProgramming.CodeForces.DeepestLeavesSum;
using CompetitiveProgramming.Algorithms;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int DeepestLeavesSum(TreeNode root)
    {
        int layerSum = 0;
        Queue<TreeNode> que = new();
        que.Enqueue(root);

        while(que.Count > 0)
        {
            int sum = 0;
            int qLen = que.Count;
            for(int i = 0; i < qLen; i++)
            {
                TreeNode node = que.Dequeue();
                sum += node.val;
                
                if(node.left != null)
                    que.Enqueue(node.left);

                if(node.right != null)
                    que.Enqueue(node.right);
            }

            layerSum = sum;
        }

        return layerSum;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Deepest Leaves Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}