Implement HashSet

```cs
// Implement your own HashSet (Add, Remove, Contains) without using the built-in System.Collections.Generic.HashSet<T>
// Approach 1: separate chaining, an array of buckets, each bucket a small list, resizes when too full
// Approach 2: direct addressing with a fixed-size bool array, simplest solution when values are small non-negative ints

public class ChainingHashSet<T> where T : notnull
{
    private List<T>[] _buckets;
    private int _count;

    public ChainingHashSet(int initialBucketCount = 8)
    {
        if (initialBucketCount <= 0)
            throw new ArgumentException("Bucket count must be positive");
        _buckets = CreateBuckets(initialBucketCount);
        _count = 0;
    }

    public int Count => _count;

    private static List<T>[] CreateBuckets(int size)
    {
        var buckets = new List<T>[size];
        for (var i = 0; i < size; i++)
            buckets[i] = new List<T>();
        return buckets;
    }

    private int GetBucketIndex(T item, int bucketCount)
    {
        var hash = item.GetHashCode();
        // force non-negative index
        return (hash & 0x7FFFFFFF) % bucketCount;
    }

    public bool Add(T item)
    {
        var index = GetBucketIndex(item, _buckets.Length);
        if (_buckets[index].Contains(item))
            return false;

        _buckets[index].Add(item);
        _count++;

        // resize when average bucket load gets too high
        if (_count > _buckets.Length * 2)
            Resize();

        return true;
    }

    public bool Remove(T item)
    {
        var index = GetBucketIndex(item, _buckets.Length);
        var removed = _buckets[index].Remove(item);
        if (removed)
            _count--;
        return removed;
    }

    public bool Contains(T item)
    {
        var index = GetBucketIndex(item, _buckets.Length);
        return _buckets[index].Contains(item);
    }

    private void Resize()
    {
        var newBuckets = CreateBuckets(_buckets.Length * 2);
        foreach (var bucket in _buckets)
        {
            foreach (var item in bucket)
            {
                var newIndex = GetBucketIndex(item, newBuckets.Length);
                newBuckets[newIndex].Add(item);
            }
        }
        _buckets = newBuckets;
    }
}

public class IntRangeHashSet
{
    private readonly bool[] _present;

    // Fixed range direct-addressing, values must be in [0, maxValue)
    public IntRangeHashSet(int maxValue = 1_000_001)
    {
        if (maxValue <= 0)
            throw new ArgumentException("maxValue must be positive");
        _present = new bool[maxValue];
        Count = 0;
    }

    public int Count { get; private set; }

    private void ValidateRange(int key)
    {
        if (key < 0 || key >= _present.Length)
            throw new ArgumentOutOfRangeException(nameof(key));
    }

    public bool Add(int key)
    {
        ValidateRange(key);
        if (_present[key])
            return false;

        _present[key] = true;
        Count++;
        return true;
    }

    public bool Remove(int key)
    {
        ValidateRange(key);
        if (!_present[key])
            return false;

        _present[key] = false;
        Count--;
        return true;
    }

    public bool Contains(int key)
    {
        ValidateRange(key);
        return _present[key];
    }
}```