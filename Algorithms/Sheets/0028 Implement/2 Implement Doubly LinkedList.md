Implement Doubly LinkedList

```cs
// Approach 1: classic doubly linked list, head/tail tracked directly.
// Supports get, addAtHead, addAtTail, addAtIndex, deleteAtIndex.
public class DoublyLinkedList
{
    private class Node
    {
        public int Val;
        public Node? Prev;
        public Node? Next;
        public Node(int val) => Val = val;
    }

    private Node? _head;
    private Node? _tail;
    private int _count;

    public int Count => _count;

    public int Get(int index)
    {
        if (index < 0 || index >= _count) return -1;
        var cur = NodeAt(index);
        return cur!.Val;
    }

    public void AddAtHead(int val)
    {
        var node = new Node(val) { Next = _head };
        if (_head != null) _head.Prev = node;
        _head = node;
        _tail ??= node;
        _count++;
    }

    public void AddAtTail(int val)
    {
        var node = new Node(val) { Prev = _tail };
        if (_tail != null) _tail.Next = node;
        _tail = node;
        _head ??= node;
        _count++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > _count) return;
        if (index <= 0) { AddAtHead(val); return; }
        if (index == _count) { AddAtTail(val); return; }

        var next = NodeAt(index);
        var prev = next!.Prev;
        var node = new Node(val) { Prev = prev, Next = next };
        prev!.Next = node;
        next.Prev = node;
        _count++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= _count) return;
        var node = NodeAt(index);

        if (node!.Prev != null) node.Prev.Next = node.Next;
        else _head = node.Next;

        if (node.Next != null) node.Next.Prev = node.Prev;
        else _tail = node.Prev;

        _count--;
    }

    // Walk from head or tail, whichever is closer.
    private Node? NodeAt(int index)
    {
        Node? cur;
        if (index < _count / 2)
        {
            cur = _head;
            for (int i = 0; i < index; i++) cur = cur!.Next;
        }
        else
        {
            cur = _tail;
            for (int i = _count - 1; i > index; i--) cur = cur!.Prev;
        }
        return cur;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var cur = _head;
        while (cur != null)
        {
            sb.Append(cur.Val);
            if (cur.Next != null) sb.Append(" <-> ");
            cur = cur.Next;
        }
        return sb.ToString();
    }

    // Reverse traversal, useful to check Prev links are correct.
    public string ToStringReversed()
    {
        var sb = new StringBuilder();
        var cur = _tail;
        while (cur != null)
        {
            sb.Append(cur.Val);
            if (cur.Prev != null) sb.Append(" <-> ");
            cur = cur.Prev;
        }
        return sb.ToString();
    }
}

// Approach 2: same API, but uses two sentinel nodes (dummy head and dummy tail).
// This avoids special-casing empty list / head / tail updates.
public class DoublyLinkedListWithDummy
{
    private class Node
    {
        public int Val;
        public Node? Prev;
        public Node? Next;
        public Node(int val = 0) => Val = val;
    }

    private readonly Node _dummyHead = new(0);
    private readonly Node _dummyTail = new(0);
    private int _count;

    public DoublyLinkedListWithDummy()
    {
        _dummyHead.Next = _dummyTail;
        _dummyTail.Prev = _dummyHead;
    }

    public int Count => _count;

    public int Get(int index)
    {
        if (index < 0 || index >= _count) return -1;
        return NodeAt(index)!.Val;
    }

    public void AddAtHead(int val) => AddAtIndex(0, val);

    public void AddAtTail(int val) => AddAtIndex(_count, val);

    public void AddAtIndex(int index, int val)
    {
        if (index > _count) return;
        if (index < 0) index = 0;

        var next = index == _count ? _dummyTail : NodeAt(index);
        var prev = next!.Prev;

        var node = new Node(val) { Prev = prev, Next = next };
        prev!.Next = node;
        next.Prev = node;
        _count++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= _count) return;
        var node = NodeAt(index)!;
        node.Prev!.Next = node.Next;
        node.Next!.Prev = node.Prev;
        _count--;
    }

    private Node? NodeAt(int index)
    {
        Node cur;
        if (index < _count / 2)
        {
            cur = _dummyHead.Next!;
            for (int i = 0; i < index; i++) cur = cur.Next!;
        }
        else
        {
            cur = _dummyTail.Prev!;
            for (int i = _count - 1; i > index; i--) cur = cur.Prev!;
        }
        return cur;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var cur = _dummyHead.Next;
        while (cur != _dummyTail)
        {
            sb.Append(cur!.Val);
            if (cur.Next != _dummyTail) sb.Append(" <-> ");
            cur = cur.Next;
        }
        return sb.ToString();
    }

    public string ToStringReversed()
    {
        var sb = new StringBuilder();
        var cur = _dummyTail.Prev;
        while (cur != _dummyHead)
        {
            sb.Append(cur!.Val);
            if (cur.Prev != _dummyHead) sb.Append(" <-> ");
            cur = cur.Prev;
        }
        return sb.ToString();
    }
}```