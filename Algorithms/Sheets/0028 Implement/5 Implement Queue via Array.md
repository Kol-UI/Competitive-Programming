Implement Queue via Array

```cs
// Queue implemented with a fixed-size circular array
// Throws when full (Enqueue) or empty (Dequeue/Peek)
public class ArrayQueue<T>
{
    private readonly T[] _items;
    private int _head;
    private int _count;

    public ArrayQueue(int capacity)
    {
        _items = new T[capacity];
    }

    public int Count => _count;
    public bool IsEmpty => _count == 0;
    public bool IsFull => _count == _items.Length;

    public void Enqueue(T item)
    {
        if (IsFull) throw new InvalidOperationException("Queue is full");
        int tail = (_head + _count) % _items.Length;
        _items[tail] = item;
        _count++;
    }

    public T Dequeue()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty");
        T value = _items[_head];
        _head = (_head + 1) % _items.Length;
        _count--;
        return value;
    }

    public T Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty");
        return _items[_head];
    }
}

// Queue implemented with a resizable circular array
// Grows automatically, no fixed capacity
public class DynamicArrayQueue<T>
{
    private T[] _items = new T[4];
    private int _head;
    private int _count;

    public int Count => _count;
    public bool IsEmpty => _count == 0;

    public void Enqueue(T item)
    {
        if (_count == _items.Length) Resize(_items.Length * 2);
        int tail = (_head + _count) % _items.Length;
        _items[tail] = item;
        _count++;
    }

    public T Dequeue()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty");
        T value = _items[_head];
        _head = (_head + 1) % _items.Length;
        _count--;

        // shrink to avoid wasting memory
        if (_count > 0 && _count == _items.Length / 4)
            Resize(_items.Length / 2);

        return value;
    }

    public T Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty");
        return _items[_head];
    }

    private void Resize(int newCapacity)
    {
        var newArray = new T[Math.Max(newCapacity, 1)];
        for (int i = 0; i < _count; i++)
            newArray[i] = _items[(_head + i) % _items.Length];
        _items = newArray;
        _head = 0;
    }
}```