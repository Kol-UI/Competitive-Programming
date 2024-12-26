// Binary Tree to CDLL



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.BinaryTreetoCDLL
{
    /*
    class Solution
    {
    
        Node head; 
        Node prev;
    
        public Node bTreeToCList(Node root)
        {
            if (root == null)
            {
                return null;
            }
            
            head = null;
            prev = null;
    
            ConvertToCDLL(root);
    
            head.left = prev;
            prev.right = head;
    
            return head;
        }
    
        private void ConvertToCDLL(Node curr)
        {
            if (curr == null)
            {
                return;
            }
    
            ConvertToCDLL(curr.left);
    
            if (head == null)
            {
                head = curr;
            }
    
            if (prev != null)
            {
                prev.right = curr;
                curr.left = prev;
            }
    
            prev = curr;
            
            ConvertToCDLL(curr.right);
        }
    }
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree to CDLL");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG);
        }
    }
}