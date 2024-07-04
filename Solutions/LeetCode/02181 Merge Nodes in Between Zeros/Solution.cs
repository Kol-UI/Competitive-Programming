// Merge Nodes in Between Zeros

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MergeNodesinBetweenZeros
{
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int val=0, ListNode next=null) {
    *         this.val = val;
    *         this.next = next;
    *     }
    * }
    */

    public class Solution
    {
        public ListNode MergeNodes(ListNode head)
        {
            ListNode currentNode = head;

            while (currentNode != null && currentNode.next != null)
            {
                if (currentNode.next.val != 0)
                {
                    currentNode.val += currentNode.next.val;
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }

                if (currentNode.next != null && currentNode.next.val == 0 && currentNode.next.next == null)
                {
                    currentNode.next = null!;
                }
            }
            return head;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Nodes in Between Zeros");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}