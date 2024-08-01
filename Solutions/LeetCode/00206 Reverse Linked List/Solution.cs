using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReverseLinkedList
{
    // Given the head of a singly linked list, reverse the list, and return the reversed list.
    // Input: head = [1,2]
    // Output: [2,1]

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


    // public class Solution
    // {
    //     public static ListNode? ReverseList(ListNode head)
    //     {
    //         if (head is null)
    //         {
    //             return null;
    //         }
    //         ListNode tail = null, next;

    //         while (head != null)
    //         {
    //             next = head.next;
    //             head.next = tail;
    //             tail = head;
    //             head = next;
    //         }

    //         return tail;
    //     }
    // }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}