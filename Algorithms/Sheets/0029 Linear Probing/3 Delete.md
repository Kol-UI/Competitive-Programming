Delete

```cs
// Deletion in a linear-probing hash table cannot simply empty the slot,
// otherwise later probing chains would break (a search could stop too early).
// This uses backward-shift deletion: after removing a key, we shift subsequent
// cluster entries backward to fill the gap, avoiding tombstones.
public class LinearProbingDeleteTable
{
    private readonly (int Key, int Value)?[] _slots;
    private readonly int _capacity;
    private int _size;

    public int Count => _size;

    public LinearProbingDeleteTable(int capacity)
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

    public bool Search(int key, out int value)
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

    // Removes a key using backward-shift deletion (Wikipedia's open-addressing algorithm).
    // Returns true if the key was found and removed.
    public bool Delete(int key)
    {
        int i = Hash(key);

        // find the slot holding the key
        while (true)
        {
            if (_slots[i] == null)
                return false; // empty slot reached, key not present

            if (_slots[i]!.Value.Key == key)
                break;

            i = (i + 1) % _capacity;
        }

        // clear it right away so the wrap-around case terminates correctly
        _slots[i] = null;
        _size--;

        int j = i;
        while (true)
        {
            j = (j + 1) % _capacity;
            if (_slots[j] == null)
                break; // reached an empty slot, nothing more to shift

            int k = Hash(_slots[j]!.Value.Key);

            // if k lies cyclically in (i, j], this entry must stay put
            if (Cyclic(i, k, j))
                continue;

            // otherwise pull it back into the gap
            _slots[i] = _slots[j];
            _slots[j] = null;
            i = j;
        }

        return true;
    }

    // true if k lies strictly after i, up to and including j, in circular order
    private bool Cyclic(int i, int k, int j)
    {
        if (i <= j)
            return i < k && k <= j;
        return k <= j || k > i;
    }
}```