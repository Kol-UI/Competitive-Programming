Search

```cs
// Linear probing search looks up a key by scanning slots forward (wrapping around)
// starting from the hashed index, until the key is found or an empty slot is hit
// An empty slot means the key is not in the table (search can stop early)
public class LinearProbingSearchTable
{
    private readonly (int Key, int Value)?[] _slots;
    private readonly int _capacity;
    private int _size;

    public int Count => _size;

    public LinearProbingSearchTable(int capacity)
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

    // Search returns true and outputs the value if the key exists.
    // Stops probing as soon as an empty slot is reached (key can't be further away).
    public bool Search(int key, out int value)
    {
        int index = Hash(key);

        for (int i = 0; i < _capacity; i++)
        {
            int probeIndex = (index + i) % _capacity;
            var slot = _slots[probeIndex];

            if (slot == null)
            {
                // empty slot reached, key is not present
                value = default;
                return false;
            }

            if (slot.Value.Key == key)
            {
                value = slot.Value.Value;
                return true;
            }
        }

        value = default;
        return false;
    }
}```