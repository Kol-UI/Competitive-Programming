Implement Stack via LinkedList

```cs
// Stack implemented with a singly linked list
public class LinkedListStack<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;
        public Node(T value, Node? next)
        {
            Value = value;
            Next = next;
        }
    }

    private Node? _head;
    private int _count;

    public int Count => _count;
    public bool IsEmpty => _head == null;

    public void Push(T item)
    {
        _head = new Node(item, _head);
        _count++;
    }

    public T Pop()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty");
        T value = _head!.Value;
        _head = _head.Next;
        _count--;
        return value;
    }

    public T Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty");
        return _head!.Value;
    }
}```