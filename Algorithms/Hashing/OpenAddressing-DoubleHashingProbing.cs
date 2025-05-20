namespace CompetitiveProgramming.Algorithms;

// Open Addressing - Double Hashing Probing
// Reduces risks of both Primary & Secondary Clustering
// Recap: Linear Probing = jump of 1 & Quadratic Probing = jump of i^2
// Double Hashing uses a second hash function to determine jump distance
// Example: In parking, if spot is taken, each car has its own jump distance
public class MyHashMapDoubleHashing
{
	private readonly int constraints;
	private readonly int defaultValue = -1;
	private readonly int H2_PRIME;
	private int[] keys;
	private int[] values;
	private bool[] isOccupied;
	private bool[] isDeleted;

	public MyHashMapDoubleHashing(int size = 1000003)
	{
		constraints = size;
		H2_PRIME = 7;

		keys = new int[constraints];
		values = new int[constraints];
		isOccupied = new bool[constraints];
		isDeleted = new bool[constraints];

		for (int i = 0; i < constraints; i++)
		{
			values[i] = defaultValue;
			isOccupied[i] = false;
			isDeleted[i] = false;
		}
	}

	private int GetHash1(int key)
	{
		return Math.Abs(key.GetHashCode()) % constraints;
	}

	private int GetHash2(int key)
	{
		int hash2 = H2_PRIME - (Math.Abs(key.GetHashCode()) % H2_PRIME);
		if (hash2 == 0) hash2 = 1;
		return hash2;
	}

	public void Put(int key, int value)
	{
		int initialIndex = GetHash1(key);
		int step = GetHash2(key);
		int index = initialIndex;
		int i = 0;

		while (isOccupied[index] && keys[index] != key)
		{
			i++;
			index = (initialIndex + i * step) % constraints;

			if (i >= constraints)
			{
				throw new InvalidOperationException("The hash table is full or unable to find an insertion spot.");
			}
		}

		keys[index] = key;
		values[index] = value;
		isOccupied[index] = true;
		isDeleted[index] = false;
	}

	public int Get(int key)
	{
		int initialIndex = GetHash1(key);
		int step = GetHash2(key);
		int index = initialIndex;
		int i = 0;

		while (isOccupied[index] || isDeleted[index])
		{
			if (isOccupied[index] && keys[index] == key) return values[index];
			i++;
			index = (initialIndex + i * step) % constraints;
			if (i >= constraints) return defaultValue;
		}

		return defaultValue;
	}

	public void Remove(int key)
	{
		int initialIndex = GetHash1(key);
		int step = GetHash2(key);
		int index = initialIndex;
		int i = 0;

		while (isOccupied[index] || isDeleted[index])
		{
			if (isOccupied[index] && keys[index] == key)
			{
				isOccupied[index] = false;
				isDeleted[index] = true;
				values[index] = defaultValue;
				return;
			}

			i++;
			index = (initialIndex + i * step) % constraints;

			if (i >= constraints) return;
		}
	}
}