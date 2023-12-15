// Swapping Nodes in a Linked List

/*
You are given the head of a linked list, and an integer k.

Return the head of the linked list after swapping the values of the kth node from the beginning and the kth node from the end (the list is 1-indexed).


Example 1:

Input: head = [1,2,3,4,5], k = 2
Output: [1,4,3,2,5]

Example 2:

Input: head = [7,9,6,6,7,8,3,0,9,5], k = 5
Output: [7,9,6,6,8,7,3,0,9,5]
*/

using System;
namespace CompetitiveProgramming.LeetCode.SwappingNodesinaLinkedList
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
        public ListNode SwapNodes(ListNode head, int k)
        {
            var cur = head;
            var nodeList = new List<ListNode>();

            while (cur != null)
            {
                nodeList.Add(cur);
                cur = cur.next;
            }

            int tempVal = nodeList[k - 1].val;
            nodeList[k - 1].val = nodeList[nodeList.Count() - k].val;
            nodeList[nodeList.Count() - k].val = tempVal;

            return head;
        }
    }
}