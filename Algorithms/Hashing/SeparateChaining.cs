namespace CompetitiveProgramming.Algorithms;

// Separate Chaining
// Cabinet with drawers, each drawer contains a chain of objects (e.g., even & odd drawers)
public class MyHashMapSeparateChaining
{
	private readonly int constraints = 1000001;
	private LinkedList<KeyValuePair<int, int>>?[] table;

	public MyHashMapSeparateChaining()
	{
		table = new LinkedList<KeyValuePair<int, int>>?[constraints];
		for (int i = 0; i < constraints; i++) table[i] = null;
	}

	private int GetHash(int key) => key % constraints;

	public void Put(int key, int value)
	{
		int index = GetHash(key);

		if (table[index] == null)
		{
			table[index] = new LinkedList<KeyValuePair<int, int>>();
		}

		table[index]!.AddLast(new KeyValuePair<int, int>(key, value));
	}

	public int Get(int key)
	{
		int index = GetHash(key);

		if (table[index] != null)
		{
			foreach (var pair in table[index]!)
			{
				if (pair.Key == key) return pair.Value;
			}
		}

		return -1;
	}

	public void Remove(int key)
	{
		int index = GetHash(key);

		if (table[index] != null)
		{
			LinkedListNode<KeyValuePair<int, int>>? current = table[index]!.First;
			while (current != null)
			{
				if (current.Value.Key == key)
				{
					LinkedListNode<KeyValuePair<int, int>>? next = current.Next;
					table[index]!.Remove(current);
					current = next;
				}
				else current = current.Next;
			}

			if (table[index]!.Count == 0) table[index] = null;
		}
	}
}