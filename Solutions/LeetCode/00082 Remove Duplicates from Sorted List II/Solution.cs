// Remove Duplicates from Sorted List II

/*
Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.

 

Example 1:

Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]

Example 2:

Input: head = [1,1,1,2,3]
Output: [2,3]
*/

using System;
namespace CompetitiveProgramming.LeetCode.RemoveDuplicatesfromSortedListII
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            var dummyHead = new ListNode(int.MinValue, head);
            var prev = dummyHead;
            
            while (prev.next != null && prev.next.next != null)
            {
                var cur = prev.next;

                if (cur.val == cur.next.val)
                {
                    while (prev.next != null && prev.next.val == cur.val) prev.next = prev.next.next;
                }
                else prev = cur;
            }

            return dummyHead.next;
        }
    }
}