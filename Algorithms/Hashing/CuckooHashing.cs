namespace CompetitiveProgramming.Algorithms;

// Cuckoo Hashing  
// Example: Parking lot with numbered spots, each car has two possible spots  
// If a spot is taken, the occupying car gets "kicked out" to its alternative spot,  
// creating a ping-pong effect until all cars are placed  
// May create infinite cycles in worst cases  
// For educational/demonstration purposes only !  
public class MyHashMapCuckoo
{
	private readonly int constraints;
	private readonly int defaultValue = -1;
	private int[] keys;
	private int[] values;
	private int currentSize;
	private const int MAX_KICKS = 100;

	public MyHashMapCuckoo(int size = 1000003)
	{
		constraints = size;
		keys = new int[constraints];
		values = new int[constraints];

		for (int i = 0; i < constraints; i++)
		{
			keys[i] = defaultValue;
			values[i] = defaultValue;
		}
		currentSize = 0;
	}

	private int Hash1(int key)
	{
		return Math.Abs(key.GetHashCode()) % constraints;
	}

	private int Hash2(int key)
	{
		return Math.Abs((key.GetHashCode() / 1234567) % constraints);
	}

	private int[] GetPossibleIndices(int key)
	{
		return new int[] { Hash1(key), Hash2(key) };
	}

	public void Put(int key, int value)
	{
		int[] currentIndices = GetPossibleIndices(key);
		foreach (int idx in currentIndices)
		{
			if (keys[idx] == key)
			{
				values[idx] = value;
				return;
			}
		}

		int currentKey = key;
		int currentValue = value;
		int currentHashFunction = 0;

		HashSet<int> visitedIndices = new HashSet<int>();

		for (int i = 0; i < MAX_KICKS; i++)
		{
			int targetIndex = (currentHashFunction == 0) ? Hash1(currentKey) : Hash2(currentKey);

			if (visitedIndices.Contains(targetIndex))
			{
				RehashAndReinsertAll(currentKey, currentValue);
				return;
			}
			visitedIndices.Add(targetIndex);

			if (keys[targetIndex] == defaultValue)
			{
				keys[targetIndex] = currentKey;
				values[targetIndex] = currentValue;
				currentSize++;
				return;
			}
			else
			{
				int kickedKey = keys[targetIndex];
				int kickedValue = values[targetIndex];

				keys[targetIndex] = currentKey;
				values[targetIndex] = currentValue;

				currentKey = kickedKey;
				currentValue = kickedValue;

				currentHashFunction = (targetIndex == Hash1(currentKey)) ? 1 : 0;
			}
		}
		RehashAndReinsertAll(currentKey, currentValue);
	}

	private static void RehashAndReinsertAll(int failedKey = -1, int failedValue = -1)
	{
		throw new InvalidOperationException("Cuckoo Hashing: Insertion failed after too many kicks or cycle detected. Table needs to be rehashed and rebuilt.");
	}

	public int Get(int key)
	{
		int[] possibleIndices = GetPossibleIndices(key);
		foreach (int idx in possibleIndices)
		{
			if (keys[idx] == key) return values[idx];
		}
		return defaultValue;
	}

	public void Remove(int key)
	{
		int[] possibleIndices = GetPossibleIndices(key);
		foreach (int idx in possibleIndices)
		{
			if (keys[idx] == key)
			{
				keys[idx] = defaultValue;
				values[idx] = defaultValue;
				currentSize--;
				return;
			}
		}
	}

	public double LoadFactor => (double)currentSize / constraints;
}