using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveDuplicatesfromSortedList
{
    public class Solution
    {
        // Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

        // Example 1:
        // Input: head = [1,1,2]
        // Output: [1,2]

        // Example 2:
        // Input: head = [1,1,2,3,3]
        // Output: [1,2,3]

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
        // */
        // public ListNode DeleteDuplicates(ListNode head)
        // {
        //     if(head == null)
        //     {
        //         return null;
        //     }

        //     if(head.next == null)
        //     {
        //         return head;
        //     }

        //     ListNode prevNode = head;
        //     for(ListNode node = head.next; node != null; node = node.next)
        //     {
        //         if(node.val == prevNode.val)
        //         {
        //             prevNode.next = node.next;
        //         }
        //         else 
        //         {
        //             prevNode = node;
        //         }
        //     }
        //     return head;
        // }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicates from Sorted List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}