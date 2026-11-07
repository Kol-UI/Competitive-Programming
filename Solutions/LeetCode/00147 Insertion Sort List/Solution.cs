// Insertion Sort List
namespace CompetitiveProgramming.LeetCode.InsertionSortList;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8601

public class Solution
{
    public ListNode InsertionSortList(ListNode head)
    {
        ListNode dummy = new ListNode();
        ListNode curr = head;
        while (curr != null)
        {
            ListNode prev = dummy;
            while (prev.next != null && prev.next.val <= curr.val)
            {
                prev = prev.next;
            }

            ListNode next = curr.next;
            curr.next = prev.next;
            prev.next = curr;
            curr = next;
        }
        return dummy.next;
    }
}

#pragma warning restore CS8601
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Insertion Sort List");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}