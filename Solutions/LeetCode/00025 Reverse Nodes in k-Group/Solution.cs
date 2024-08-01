// Reverse Nodes in k-Group

/*
Given the head of a linked list, reverse the nodes of the list k at a time, and return the modified list.

k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.

You may not alter the values in the list's nodes, only nodes themselves may be changed.

 

Example 1:

Input: head = [1,2,3,4,5], k = 2
Output: [2,1,4,3,5]

Example 2:

Input: head = [1,2,3,4,5], k = 3
Output: [3,2,1,4,5]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ReverseNodesinkGroup
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
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            int count = k;
            
            if(head == null) return null!;

            ListNode curr = head;
            ListNode prev = null!;

            while(curr != null && count > 0)
            {
                var nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
                count--;
            }

            if(count > 0) return ReverseLL(prev);

            head.next = ReverseKGroup(curr!, k);
            return prev;
        }

        public ListNode ReverseLL(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null!;

            while(curr != null)
            {
                var nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
            }

            return prev;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Nodes in k-Group");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}