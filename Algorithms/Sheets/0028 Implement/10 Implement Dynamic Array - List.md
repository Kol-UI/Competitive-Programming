Implement Dynamic Array (List)

```cs
// Implement your own dynamic array (like List<T>) backed by a plain array
// Approach 1: classic doubling array, capacity only ever grows
// Approach 2: same idea but also shrinks capacity when usage drops too low, to save memory

public class SimpleDynamicArray<T>
{
    private T[] _items;
    private int _count;

    public SimpleDynamicArray(int initialCapacity = 4)
    {
        if (initialCapacity <= 0)
            throw new ArgumentException("Capacity must be positive");
        _items = new T[initialCapacity];
        _count = 0;
    }

    public int Count => _count;
    public int Capacity => _items.Length;

    public T this[int index]
    {
        get
        {
            ValidateIndex(index);
            return _items[index];
        }
        set
        {
            ValidateIndex(index);
            _items[index] = value;
        }
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    // Double capacity when full
    private void EnsureCapacity()
    {
        if (_count < _items.Length)
            return;

        var newItems = new T[_items.Length * 2];
        Array.Copy(_items, newItems, _count);
        _items = newItems;
    }

    public void Add(T item)
    {
        EnsureCapacity();
        _items[_count] = item;
        _count++;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > _count)
            throw new ArgumentOutOfRangeException(nameof(index));

        EnsureCapacity();
        Array.Copy(_items, index, _items, index + 1, _count - index);
        _items[index] = item;
        _count++;
    }

    public void RemoveAt(int index)
    {
        ValidateIndex(index);
        Array.Copy(_items, index + 1, _items, index, _count - index - 1);
        _count--;
        _items[_count] = default!;
    }
}

public class ShrinkingDynamicArray<T>
{
    private T[] _items;
    private int _count;

    public ShrinkingDynamicArray(int initialCapacity = 4)
    {
        if (initialCapacity <= 0)
            throw new ArgumentException("Capacity must be positive");
        _items = new T[initialCapacity];
        _count = 0;
    }

    public int Count => _count;
    public int Capacity => _items.Length;

    public T this[int index]
    {
        get
        {
            ValidateIndex(index);
            return _items[index];
        }
        set
        {
            ValidateIndex(index);
            _items[index] = value;
        }
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    private void Resize(int newCapacity)
    {
        newCapacity = Math.Max(newCapacity, 1);
        var newItems = new T[newCapacity];
        Array.Copy(_items, newItems, _count);
        _items = newItems;
    }

    public void Add(T item)
    {
        if (_count == _items.Length)
            Resize(_items.Length * 2);

        _items[_count] = item;
        _count++;
    }

    public void RemoveAt(int index)
    {
        ValidateIndex(index);
        Array.Copy(_items, index + 1, _items, index, _count - index - 1);
        _count--;
        _items[_count] = default!;

        // shrink when usage drops below a quarter of capacity
        if (_count > 0 && _count <= _items.Length / 4)
            Resize(_items.Length / 2);
    }
}```