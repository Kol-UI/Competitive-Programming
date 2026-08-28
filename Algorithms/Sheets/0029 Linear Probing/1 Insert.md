Insert

```cs
// Linear probing : open-addressing collision resolution technique
// On collision, we scan forward (wrapping around) until an empty slot or matching key is found
// Insert either adds a new key-value pair or updates the value if the key already exists
public class LinearProbingHashTable
{
    private readonly (int Key, int Value)?[] _slots;
    private readonly int _capacity;
    private int _size;

    public int Count => _size;
    public int Capacity => _capacity;

    public LinearProbingHashTable(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be positive.", nameof(capacity));

        _capacity = capacity;
        _slots = new (int, int)?[capacity];
        _size = 0;
    }

    private int Hash(int key)
    {
        // simple modulo hash, handle negative keys
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
                // empty slot found, insert new entry
                _slots[probeIndex] = (key, value);
                _size++;
                return;
            }

            if (slot.Value.Key == key)
            {
                // key already exists, update value
                _slots[probeIndex] = (key, value);
                return;
            }
        }

        // should not happen since we check _size == _capacity above
        throw new InvalidOperationException("Hash table is full.");
    }

    public bool TryGet(int key, out int value)
    {
        int index = Hash(key);

        for (int i = 0; i < _capacity; i++)
        {
            int probeIndex = (index + i) % _capacity;
            var slot = _slots[probeIndex];

            if (slot == null)
            {
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

    public int SlotIndexOf(int key)
    {
        int index = Hash(key);

        for (int i = 0; i < _capacity; i++)
        {
            int probeIndex = (index + i) % _capacity;
            var slot = _slots[probeIndex];

            if (slot != null && slot.Value.Key == key)
                return probeIndex;
        }

        return -1;
    }
}```