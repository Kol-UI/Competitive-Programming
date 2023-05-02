// Add Two Numbers II

/*
You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:


Input: l1 = [7,2,4,3], l2 = [5,6,4]
Output: [7,8,0,7]

Example 2:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [8,0,7]

Example 3:

Input: l1 = [0], l2 = [0]
Output: [0]
*/

using System;
namespace CompetitiveProgramming.LeetCode.AddTwoNumbersII
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode dummy = null;
            int sum = 0;
            int carry = 0;
            Stack<int> st1 = new Stack<int>();
            Stack<int> st2 = new Stack<int>();
            
            while(l1 != null)
            {
                st1.Push(l1.val);
                l1 = l1.next;
            }
            
            while(l2 != null)
            {
                st2.Push(l2.val);
                l2 = l2.next;
            }

            while(st1.Count > 0 || st2.Count > 0)
            {
                sum = carry;

                if(st1.Count > 0) sum += st1.Pop();

                if(st2.Count > 0) sum += st2.Pop();

                result = new ListNode(sum % 10 , dummy);
                dummy = result;
                carry = sum/10;
            }

            if(carry > 0) result = new ListNode(carry, dummy);
            
            return result;
        }
    }
    */
}