namespace CompetitiveProgramming.Algorithms;

public class ListNode
{
    public int Val;
    public ListNode? Next;
    public ListNode(int val, ListNode? next = null)
    {
        Val = val;
        Next = next;
    }
}

public class ReverseLinkedList
{
    // Approach Iterative: rewire Next pointers one by one
    public ListNode? ReverseIterative(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? current = head;

        while (current != null)
        {
            ListNode? next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    // Approach Recursive: reverse the rest of the list, then fix current node's link
    public ListNode? ReverseRecursive(ListNode? head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        ListNode? newHead = ReverseRecursive(head.Next);
        head.Next.Next = head;
        head.Next = null;

        return newHead;
    }

    // Approach Stack: push all nodes, then pop to rebuild in reverse order
    public ListNode? ReverseUsingStack(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }

        var stack = new Stack<ListNode>();
        ListNode? current = head;

        while (current != null)
        {
            stack.Push(current);
            current = current.Next;
        }

        ListNode newHead = stack.Pop();
        ListNode tail = newHead;

        while (stack.Count > 0)
        {
            tail.Next = stack.Pop();
            tail = tail.Next;
        }

        tail.Next = null;

        return newHead;
    }
}