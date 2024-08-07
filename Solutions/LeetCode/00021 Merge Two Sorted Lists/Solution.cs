// You are given the heads of two sorted linked lists list1 and list2.

// Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

// Return the head of the merged linked list.


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MergeTwoSortedLists
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
    // public class Solution
    // {
    //     public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    //     {
    //         if(list1 == null && list2 == null)        
    //         {
    //             return list2;
    //         }
    //         ListNode current = new ListNode(0);
    //         ListNode head = current;

    //         while(list1 != null && list2 != null)
    //         {
    //             if(list1.val<list2.val)
    //             {
    //                 current.next = list1;                
    //                 list1 = list1.next;
    //             }
    //             else
    //             {
    //                 current.next = list2;                
    //                 list2 = list2.next;
    //             }
    //             current = current.next;
    //         }
    //         if(list1!=null)
    //         {
    //             current.next = list1;
    //         }
    //         if(list2!=null)
    //         {
    //             current.next = list2;
    //         }
    //         return head.next;
    //     }
    // }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Two Sorted Lists");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}