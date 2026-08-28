Implement Stack via Array

```cs
// Stack implemented with a fixed-size array
// Throws when full (Push) or empty (Pop/Peek)
public class ArrayStack<T>
{
    private readonly T[] _items;
    private int _top = -1;

    public ArrayStack(int capacity)
    {
        _items = new T[capacity];
    }

    public int Count => _top + 1;
    public bool IsEmpty => _top == -1;
    public bool IsFull => _top == _items.Length - 1;

    public void Push(T item)
    {
        if (IsFull) throw new InvalidOperationException("Stack is full");
        _items[++_top] = item;
    }

    public T Pop()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty");
        return _items[_top--];
    }

    public T Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty");
        return _items[_top];
    }
}

// Stack implemented with a resizable (dynamic) array
// Grows/shrinks automatically, no fixed capacity
public class DynamicArrayStack<T>
{
    private T[] _items = new T[4];
    private int _top = -1;

    public int Count => _top + 1;
    public bool IsEmpty => _top == -1;

    public void Push(T item)
    {
        if (_top + 1 == _items.Length) Resize(_items.Length * 2);
        _items[++_top] = item;
    }

    public T Pop()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty");
        T value = _items[_top--];

        // shrink to avoid wasting memory
        if (_top + 1 > 0 && _top + 1 == _items.Length / 4)
            Resize(_items.Length / 2);

        return value;
    }

    public T Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty");
        return _items[_top];
    }

    private void Resize(int newCapacity)
    {
        var newArray = new T[Math.Max(newCapacity, 1)];
        Array.Copy(_items, newArray, _top + 1);
        _items = newArray;
    }
}```