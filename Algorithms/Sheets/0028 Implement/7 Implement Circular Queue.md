Implement Circular Queue

```cs
// Implement a fixed-size Circular Queue (FIFO with wrap-around)
// Approach 1: array-based buffer with head index and item count
// Approach 2: fixed-size custom linked list (nodes reused, no allocation on enqueue/dequeue...)

public class CircularQueueArray<T>
{
    private readonly T[] _buffer;
    private int _head;
    private int _count;

    public CircularQueueArray(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be positive");
        _buffer = new T[capacity];
        _head = 0;
        _count = 0;
    }

    public int Count => _count;
    public int Capacity => _buffer.Length;
    public bool IsEmpty => _count == 0;
    public bool IsFull => _count == _buffer.Length;

    // Add item at the rear, wrapping around if needed
    public bool Enqueue(T item)
    {
        if (IsFull)
            return false;

        var tail = (_head + _count) % _buffer.Length;
        _buffer[tail] = item;
        _count++;
        return true;
    }

    // Remove item from the front
    public bool Dequeue()
    {
        if (IsEmpty)
            return false;

        _buffer[_head] = default!;
        _head = (_head + 1) % _buffer.Length;
        _count--;
        return true;
    }

    public T Front()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue is empty");
        return _buffer[_head];
    }

    public T Rear()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue is empty");
        var tail = (_head + _count - 1) % _buffer.Length;
        return _buffer[tail];
    }
}

public class CircularQueueLinkedList<T>
{
    private class Node
    {
        public T Value = default!;
        public Node? Next;
    }

    private readonly int _capacity;
    private Node? _head;
    private Node? _tail;
    private int _count;

    public CircularQueueLinkedList(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be positive");
        _capacity = capacity;
    }

    public int Count => _count;
    public int Capacity => _capacity;
    public bool IsEmpty => _count == 0;
    public bool IsFull => _count == _capacity;

    public bool Enqueue(T item)
    {
        if (IsFull)
            return false;

        var node = new Node { Value = item };
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
        return true;
    }

    public bool Dequeue()
    {
        if (IsEmpty || _head is null)
            return false;

        _head = _head.Next;
        if (_head is null)
            _tail = null;
        _count--;
        return true;
    }

    public T Front()
    {
        if (IsEmpty || _head is null)
            throw new InvalidOperationException("Queue is empty");
        return _head.Value;
    }

    public T Rear()
    {
        if (IsEmpty || _tail is null)
            throw new InvalidOperationException("Queue is empty");
        return _tail.Value;
    }
}```