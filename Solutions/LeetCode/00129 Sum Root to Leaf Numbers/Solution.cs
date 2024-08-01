using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumRoottoLeafNumbers
{
    /*
    You are given the root of a binary tree containing digits from 0 to 9 only.
    Each root-to-leaf path in the tree represents a number.
    For example, the root-to-leaf path 1 -> 2 -> 3 represents the number 123.
    Return the total sum of all root-to-leaf numbers. Test cases are generated so that the answer will fit in a 32-bit integer.
    A leaf node is a node with no children.

    
    Example 1:

    Input: root = [1,2,3]
    Output: 25
    Explanation:
    The root-to-leaf path 1->2 represents the number 12.
    The root-to-leaf path 1->3 represents the number 13.
    Therefore, sum = 12 + 13 = 25.
    
    Example 2:

    Input: root = [4,9,0,5,1]
    Output: 1026
    Explanation:
    The root-to-leaf path 4->9->5 represents the number 495.
    The root-to-leaf path 4->9->1 represents the number 491.
    The root-to-leaf path 4->0 represents the number 40.
    Therefore, sum = 495 + 491 + 40 = 1026.
    */

    public class Solution
    {
        public static int SumNumbers(TreeNode root)
        {
            int sum = 0;
            Queue<(TreeNode rt, int prevVal)> q = new Queue<(TreeNode, int)>();
            q.Enqueue((root, 0));
            while(q.Count > 0)
            {
                TreeNode rem = q.Peek().rt;
                int prev = q.Peek().prevVal;
                q.Dequeue();
                prev = prev * 10 + rem.val;
                if(rem.left != null) q.Enqueue((rem.left, prev));
                if(rem.right != null) q.Enqueue((rem.right,prev));
                if(rem.left == null && rem.right == null)
                {
                    sum += prev;
                }
            }
            return sum;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum Root to Leaf Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}