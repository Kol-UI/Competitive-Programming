// Swap Nodes in Pairs

/*
Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

Example 1:

Input: head = [1,2,3,4]
Output: [2,1,4,3]

Example 2:

Input: head = []
Output: []

Example 3:

Input: head = [1]
Output: [1]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SwapNodesinPairs
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
    /*
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            int? value = head?.val;
            ListNode? pairStartNode = head;
            ListNode? pairEndNode = pairStartNode?.next;

            while(pairEndNode != null)
            {
                pairStartNode.val = pairEndNode.val;
                pairEndNode.val = value ?? 0;

                pairStartNode = pairEndNode?.next;
                pairEndNode = pairStartNode?.next;
                value =  pairStartNode?.val;
            }

            return head;
        }
    }
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Swap Nodes in Pairs");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}