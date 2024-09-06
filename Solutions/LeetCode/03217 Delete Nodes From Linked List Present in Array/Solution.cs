// Delete Nodes From Linked List Present in Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DeleteNodesFromLinkedListPresentinArray;

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
    public ListNode ModifiedList(int[] nums, ListNode head)
    {
        return RemoveSpecificsNumbersInLinkedList(nums, head);
    }

    private static ListNode RemoveSpecificsNumbersInLinkedList(int[] nums, ListNode head)
    {
        HashSet<int> valuesToRemove = CreateHashSetFromArray(nums);
        ListNode tempo = CreateTempoNode(head);
        RemoveNodes(tempo, valuesToRemove);
        return GetModifiedHead(tempo);
    }

    private static HashSet<int> CreateHashSetFromArray(int[] nums)
    {
        return new HashSet<int>(nums);
    }

    private static ListNode CreateTempoNode(ListNode head)
    {
        ListNode tempo = new ListNode(-1);
        tempo.next = head;
        return tempo;
    }

    private static void RemoveNodes(ListNode tempo, HashSet<int> valuesToRemove)
    {
        ListNode current = tempo;
        while (current.next != null)
        {
            if (valuesToRemove.Contains(current.next.val))
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
    }

    private static ListNode GetModifiedHead(ListNode tempo)
    {
        return tempo.next;
    }

    private static void PrintLinkedList(ListNode result)
    {
        while (result != null)
        {
            Console.Write(result.val + " -> ");
            result = result.next;
        }
        Console.WriteLine();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Delete Nodes From Linked List Present in Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}