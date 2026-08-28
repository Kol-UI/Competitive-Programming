Implement Queue via LinkedList

```cs
// Implement a Queue (FIFO) data structure using a linked list.
// Approach 1: custom singly linked list with head/tail pointers.
// Approach 2: reuse .NET's built-in LinkedList<T> as the storage.

public class LinkedListQueue<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;
        public Node(T value) => Value = value;
    }

    private Node? _head;
    private Node? _tail;
    private int _count;

    public int Count => _count;
    public bool IsEmpty => _count == 0;

    // Add item at the back
    public void Enqueue(T item)
    {
        var node = new Node(item);
        if (_tail is null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _tail.Next = node;
            _tail = node;
        }
        _count++;
    }

    // Remove and return item at the front
    public T Dequeue()
    {
        if (_head is null)
            throw new InvalidOperationException("Queue is empty");

        var value = _head.Value;
        _head = _head.Next;
        if (_head is null)
            _tail = null;
        _count--;
        return value;
    }

    // Return front item without removing it
    public T Peek()
    {
        if (_head is null)
            throw new InvalidOperationException("Queue is empty");
        return _head.Value;
    }
}

public class DotNetLinkedListQueue<T>
{
    private readonly LinkedList<T> _list = new();

    public int Count => _list.Count;
    public bool IsEmpty => _list.Count == 0;

    public void Enqueue(T item) => _list.AddLast(item);

    public T Dequeue()
    {
        if (_list.First is null)
            throw new InvalidOperationException("Queue is empty");
        var value = _list.First.Value;
        _list.RemoveFirst();
        return value;
    }

    public T Peek()
    {
        if (_list.First is null)
            throw new InvalidOperationException("Queue is empty");
        return _list.First.Value;
    }
}```