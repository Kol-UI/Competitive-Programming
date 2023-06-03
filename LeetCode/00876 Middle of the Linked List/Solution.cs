// Middle of the Linked List


/*
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
Example 2:


Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
*/

using System;
namespace CompetitiveProgramming.LeetCode.MiddleoftheLinkedList
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
        public ListNode MiddleNode(ListNode head)
        {
            int middleIndex = ListLength(head) / 2;

            return NodeAt(middleIndex, head);
        }

        private int ListLength(ListNode head)
        {
            int length = 1;

            while (head.next != null)
            {
                length++;
                head = head.next;
            }

            return length;
        }

        private ListNode NodeAt(int i, ListNode head)
        {
            if (i == 0) return head;

            return NodeAt(i - 1, head.next);
        }
    }
}