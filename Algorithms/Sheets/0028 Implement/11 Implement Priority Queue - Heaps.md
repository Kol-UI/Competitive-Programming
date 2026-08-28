Implement Priority Queue (Heaps)

```cs
// Implement a Priority Queue that always pops the smallest (or custom-ordered) item first
// Approach 1: classic binary heap backed by a List<T>, O(log n) push/pop via sift-up/sift-down
// Approach 2: a list kept sorted on insert, O(n) push but O(1) pop, useful as a simpler baseline

public class BinaryHeapPriorityQueue<T>
{
    private readonly List<T> _items = new();
    private readonly IComparer<T> _comparer;

    public BinaryHeapPriorityQueue(IComparer<T>? comparer = null)
    {
        _comparer = comparer ?? Comparer<T>.Default;
    }

    public int Count => _items.Count;
    public bool IsEmpty => _items.Count == 0;

    private static int Parent(int i) => (i - 1) / 2;
    private static int LeftChild(int i) => 2 * i + 1;
    private static int RightChild(int i) => 2 * i + 2;

    private void Swap(int a, int b) => (_items[a], _items[b]) = (_items[b], _items[a]);

    public void Push(T item)
    {
        _items.Add(item);
        SiftUp(_items.Count - 1);
    }

    private void SiftUp(int index)
    {
        while (index > 0)
        {
            var parent = Parent(index);
            if (_comparer.Compare(_items[index], _items[parent]) >= 0)
                break;

            Swap(index, parent);
            index = parent;
        }
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Priority queue is empty");
        return _items[0];
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Priority queue is empty");

        var top = _items[0];
        var last = _items.Count - 1;
        _items[0] = _items[last];
        _items.RemoveAt(last);

        if (_items.Count > 0)
            SiftDown(0);

        return top;
    }

    private void SiftDown(int index)
    {
        while (true)
        {
            var left = LeftChild(index);
            var right = RightChild(index);
            var smallest = index;

            if (left < _items.Count && _comparer.Compare(_items[left], _items[smallest]) < 0)
                smallest = left;
            if (right < _items.Count && _comparer.Compare(_items[right], _items[smallest]) < 0)
                smallest = right;

            if (smallest == index)
                break;

            Swap(index, smallest);
            index = smallest;
        }
    }
}

public class SortedListPriorityQueue<T>
{
    private readonly List<T> _items = new();
    private readonly IComparer<T> _comparer;

    public SortedListPriorityQueue(IComparer<T>? comparer = null)
    {
        _comparer = comparer ?? Comparer<T>.Default;
    }

    public int Count => _items.Count;
    public bool IsEmpty => _items.Count == 0;

    // Insert at the position that keeps the list sorted ascending
    public void Push(T item)
    {
        var index = _items.BinarySearch(item, _comparer);
        if (index < 0)
            index = ~index;
        _items.Insert(index, item);
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Priority queue is empty");
        return _items[0];
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Priority queue is empty");

        var top = _items[0];
        _items.RemoveAt(0);
        return top;
    }
}```