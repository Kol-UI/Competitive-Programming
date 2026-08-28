namespace CompetitiveProgramming.Algorithms;

public class ListNodeForLinkedList
{
    public int Val;
    public ListNodeForLinkedList? Next;
    public ListNodeForLinkedList(int val, ListNodeForLinkedList? next = null)
    {
        Val = val;
        Next = next;
    }
}

public class ReverseLinkedList
{
    // Approach Iterative: rewire Next pointers one by one
    public ListNodeForLinkedList? ReverseIterative(ListNodeForLinkedList? head)
    {
        ListNodeForLinkedList? prev = null;
        ListNodeForLinkedList? current = head;

        while (current != null)
        {
            ListNodeForLinkedList? next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    // Approach Recursive: reverse the rest of the list, then fix current node's link
    public ListNodeForLinkedList? ReverseRecursive(ListNodeForLinkedList? head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        ListNodeForLinkedList? newHead = ReverseRecursive(head.Next);
        head.Next.Next = head;
        head.Next = null;

        return newHead;
    }

    // Approach Stack: push all nodes, then pop to rebuild in reverse order
    public ListNodeForLinkedList? ReverseUsingStack(ListNodeForLinkedList? head)
    {
        if (head == null)
        {
            return null;
        }

        var stack = new Stack<ListNodeForLinkedList>();
        ListNodeForLinkedList? current = head;

        while (current != null)
        {
            stack.Push(current);
            current = current.Next;
        }

        ListNodeForLinkedList newHead = stack.Pop();
        ListNodeForLinkedList tail = newHead;

        while (stack.Count > 0)
        {
            tail.Next = stack.Pop();
            tail = tail.Next;
        }

        tail.Next = null;

        return newHead;
    }
}