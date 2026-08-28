Implement Singly LinkedList

```cs
// Approach 1: classic node-based singly linked list, head managed directly.
// Supports get, addAtHead, addAtTail, addAtIndex, deleteAtIndex.
public class SinglyLinkedList
{
    private class Node
    {
        public int Val;
        public Node? Next;
        public Node(int val) => Val = val;
    }

    private Node? _head;
    private int _count;

    public int Count => _count;

    public int Get(int index)
    {
        if (index < 0 || index >= _count) return -1;
        var cur = _head;
        for (int i = 0; i < index; i++) cur = cur!.Next;
        return cur!.Val;
    }

    public void AddAtHead(int val)
    {
        _head = new Node(val) { Next = _head };
        _count++;
    }

    public void AddAtTail(int val)
    {
        var node = new Node(val);
        if (_head == null)
        {
            _head = node;
        }
        else
        {
            var cur = _head;
            while (cur!.Next != null) cur = cur.Next;
            cur.Next = node;
        }
        _count++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > _count) return;
        if (index <= 0) { AddAtHead(val); return; }
        if (index == _count) { AddAtTail(val); return; }

        var prev = _head;
        for (int i = 0; i < index - 1; i++) prev = prev!.Next;
        prev!.Next = new Node(val) { Next = prev.Next };
        _count++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= _count) return;
        if (index == 0)
        {
            _head = _head!.Next;
            _count--;
            return;
        }
        var prev = _head;
        for (int i = 0; i < index - 1; i++) prev = prev!.Next;
        prev!.Next = prev.Next!.Next;
        _count--;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var cur = _head;
        while (cur != null)
        {
            sb.Append(cur.Val);
            if (cur.Next != null) sb.Append(" -> ");
            cur = cur.Next;
        }
        return sb.ToString();
    }
}

// Approach 2: same API, but uses a dummy (sentinel) head node.
// This avoids special-casing index 0 for insert/delete.
public class SinglyLinkedListWithDummy
{
    private class Node
    {
        public int Val;
        public Node? Next;
        public Node(int val = 0) => Val = val;
    }

    private readonly Node _dummy = new(0);
    private int _count;

    public int Count => _count;

    public int Get(int index)
    {
        if (index < 0 || index >= _count) return -1;
        var cur = _dummy.Next;
        for (int i = 0; i < index; i++) cur = cur!.Next;
        return cur!.Val;
    }

    public void AddAtHead(int val) => AddAtIndex(0, val);

    public void AddAtTail(int val) => AddAtIndex(_count, val);

    public void AddAtIndex(int index, int val)
    {
        if (index > _count) return;
        if (index < 0) index = 0;

        var prev = _dummy;
        for (int i = 0; i < index; i++) prev = prev.Next!;
        prev.Next = new Node(val) { Next = prev.Next };
        _count++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= _count) return;
        var prev = _dummy;
        for (int i = 0; i < index; i++) prev = prev.Next!;
        prev.Next = prev.Next!.Next;
        _count--;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var cur = _dummy.Next;
        while (cur != null)
        {
            sb.Append(cur.Val);
            if (cur.Next != null) sb.Append(" -> ");
            cur = cur.Next;
        }
        return sb.ToString();
    }
}```