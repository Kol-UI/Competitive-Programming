Load Factor

```cs
// Load factor measures how full a hash table is: size / capacity.
// It's a key metric for open addressing (like linear probing), since performance
// degrades sharply as the load factor approaches 1 (few or no empty slots left to probe into).
public class LinearProbingLoadFactorTable
{
    private readonly (int Key, int Value)?[] _slots;
    private readonly int _capacity;
    private int _size;

    public int Count => _size;
    public int Capacity => _capacity;

    public LinearProbingLoadFactorTable(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be positive.", nameof(capacity));

        _capacity = capacity;
        _slots = new (int, int)?[capacity];
        _size = 0;
    }

    private int Hash(int key)
    {
        int h = key % _capacity;
        return h < 0 ? h + _capacity : h;
    }

    public void Insert(int key, int value)
    {
        if (_size == _capacity)
            throw new InvalidOperationException("Hash table is full.");

        int index = Hash(key);

        for (int i = 0; i < _capacity; i++)
        {
            int probeIndex = (index + i) % _capacity;
            var slot = _slots[probeIndex];

            if (slot == null)
            {
                _slots[probeIndex] = (key, value);
                _size++;
                return;
            }

            if (slot.Value.Key == key)
            {
                _slots[probeIndex] = (key, value);
                return;
            }
        }
    }

    // Returns size / capacity as a double, e.g. 0.5 for a half-full table.
    public double LoadFactor()
    {
        return (double)_size / _capacity;
    }

    // Common practical check: table is "overloaded" past a given threshold
    // (e.g. 0.7 is a typical resize trigger for open addressing).
    public bool IsOverloaded(double threshold)
    {
        if (threshold < 0 || threshold > 1)
            throw new ArgumentOutOfRangeException(nameof(threshold), "Threshold must be between 0 and 1.");

        return LoadFactor() > threshold;
    }
}```