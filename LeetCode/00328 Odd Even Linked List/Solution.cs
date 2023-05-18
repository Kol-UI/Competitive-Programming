// Odd Even Linked List

/*
Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.

The first node is considered odd, and the second node is even, and so on.

Note that the relative order inside both the even and odd groups should remain as it was in the input.

You must solve the problem in O(1) extra space complexity and O(n) time complexity.

 

Example 1:

Input: head = [1,2,3,4,5]
Output: [1,3,5,2,4]

Example 2:

Input: head = [2,1,3,5,6,4,7]
Output: [2,3,6,7,1,5,4]
*/

using System;
namespace CompetitiveProgramming.LeetCode.OddEvenLinkedList
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
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head is null) return head;

            ListNode oddPtr = head;
            ListNode prevOddPtr = null;
            ListNode evenPtr = head.next;
            ListNode evenPtrStart = evenPtr;

            while (oddPtr is not null && oddPtr.next is not null)
            {
                prevOddPtr = oddPtr;
                oddPtr.next = oddPtr.next.next;
                oddPtr = oddPtr.next;

                if (evenPtr is not null && evenPtr.next is not null)
                {
                    evenPtr.next = evenPtr.next.next;
                    evenPtr = evenPtr.next;
                }
            }

            if (oddPtr is null) prevOddPtr.next = evenPtrStart;
            else oddPtr.next = evenPtrStart;

            return head;
        }
    }
    */
}