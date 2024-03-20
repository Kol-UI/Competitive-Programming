// Merge In Between Linked Lists


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MergeInBetweenLinkedLists
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
        public static ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {

            int currNode = 0;

            ListNode aRef = list1;
            ListNode bRef = list1;
            ListNode list1Head = list1;

            while (list1 != null)
            {
                if (currNode == a - 1)
                {
                    aRef = list1;
                } 
                if (currNode == b)
                {
                    bRef = list1;
                }
                currNode++;
                list1 = list1.next;
            }

            ListNode list2Head = list2;

            while (list2.next != null)
            {
                list2 = list2.next;
            }

            aRef.next = list2Head;
            list2.next = bRef.next;

            return list1Head;
        }
    }
}