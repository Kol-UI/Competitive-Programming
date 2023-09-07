// Reverse Linked List II

/*
Given the head of a singly linked list and two integers left and right where left <= right, reverse the nodes of the list from position left to position right, and return the reversed list.

 

Example 1:


Input: head = [1,2,3,4,5], left = 2, right = 4
Output: [1,4,3,2,5]


Example 2:

Input: head = [5], left = 1, right = 1
Output: [5]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ReverseLinkedListII
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
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode prev = null!;
            ListNode current = head;
            
            while(left > 1)
            {
                prev = current;
                current = current.next;
                left--;
                right--;
            }
            
            ListNode connection = prev;
            ListNode tail = current;

            while(right > 0)
            {
                ListNode nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
                right--;
            }

            if(connection != null) connection.next = prev;
            else head = prev;

            tail.next = current;
            
            return head;
        }
    }
}