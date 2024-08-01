// Remove Nth Node From End of List

/*
Given the head of a linked list, remove the nth node from the end of the list and return its head.

 

Example 1:


Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]

Example 2:

Input: head = [1], n = 1
Output: []

Example 3:

Input: head = [1,2], n = 1
Output: [1]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveNthNodeFromEndofList
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            List<int> list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            int removeIndex = list.Count() - n;
            list.RemoveAt(removeIndex);

            ListNode prev = new ListNode();
            var dummy = prev;

            foreach (int i in list)
            {
                dummy.next = new ListNode(i);
                dummy = dummy.next;
            }
            
            return prev.next;        
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Nth Node From End of List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}