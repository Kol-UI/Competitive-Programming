namespace CompetitiveProgramming.Algorithms;

// Open Addressing - Linear Probing
// Array for keys, Array for values & Array to know if index is occupied
// Long parking lane with numbered spots
// Similar to Direct Address Table, but with collision handling
// Example: If spot 50 is taken, the car moves to spot 51
// We check the next spot, then the next, then the next...
// Can cause Primary Clustering
// When many collisions occur, Linear Probing tends to create long "blocks" of occupied elements
// If a new key hashes into one of these blocks, it must probe through the entire block to find an empty spot
// And it will eventually park at the end of the block, making it even larger
// Degrading performance
public class MyHashMapOpenAddressingLinearProbing
{
	private readonly int constraints = 1000001;
	private readonly int defaultValue = -1;
	private int[] keys;
	private int[] values;
	private bool[] isOccupied;

	public MyHashMapOpenAddressingLinearProbing()
	{
		keys = new int[constraints];
		values = new int[constraints];
		isOccupied = new bool[constraints];
		for (int i = 0; i < constraints; i++)
		{
			values[i] = defaultValue;
			isOccupied[i] = false;
		}
	}

	private int GetHash(int key)
	{
		return Math.Abs(key.GetHashCode() % constraints);
	}

	public void Put(int key, int value)
	{
		int index = GetHash(key);

		while (isOccupied[index] && keys[index] != key)
		{
			index = (index + 1) % constraints;
		}

		keys[index] = key;
		values[index] = value;
		isOccupied[index] = true;
	}

	public int Get(int key)
	{
		int index = GetHash(key);

		while (isOccupied[index])
		{
			if (keys[index] == key) return values[index];
			index = (index + 1) % constraints;
			if (index == GetHash(key)) return defaultValue;
		}

		return defaultValue;
	}

	public void Remove(int key)
	{
		int index = GetHash(key);

		while (isOccupied[index])
		{
			if (keys[index] == key)
			{
				isOccupied[index] = false;
				values[index] = defaultValue;
				return;
			}
			index = (index + 1) % constraints;
			if (index == GetHash(key)) return;
		}
	}
}