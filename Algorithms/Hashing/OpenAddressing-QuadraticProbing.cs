namespace CompetitiveProgramming.Algorithms;

// Open Addressing - Quadratic Probing
// Similar to Linear Probing but designed to combat Primary Clustering  
// Example: Parking lot - if a spot is occupied  
// Instead of checking the immediate next spot, we use increasingly larger "jumps"  
// If the initial spot is taken, check 1 spot away  
// If that's occupied, check 2^2 = 4 spots from the original  
// If still occupied, check 3^2 = 9 spots from the original  
// Then 4^2 = 16 spots away, and so on  

// Benefit: Since probes are no longer sequential, Quadratic Probing better disperses elements  
// and prevents long contiguous "blocks" from forming.  
// This improves performance because searches are less likely to traverse long chains of elements.  

// Can cause Secondary Clustering  
// In hash tables using quadratic probing, this refers to the tendency for keys  
// that hash to the same initial index to follow the same quadratic probing sequence during collisions,  
// which can still create "clusters" of elements and slow down operations.  
public class MyHashMapQuadraticProbing
{
	private readonly int constraints;
	private readonly int defaultValue = -1;
	private int[] keys;
	private int[] values;
	private bool[] isOccupied;

	public MyHashMapQuadraticProbing(int size = 1000003) // Not 1M because primary number needed
	{
		constraints = size;
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
		int initialIndex = GetHash(key);
		int index = initialIndex;
		int i = 0;

		while (isOccupied[index] && keys[index] != key)
		{
			i++;
			index = (initialIndex + i * i) % constraints;
			if (i >= constraints) throw new InvalidOperationException("Hash table is full or cannot find a spot.");
		}

		keys[index] = key;
		values[index] = value;
		isOccupied[index] = true;
	}

	public int Get(int key)
	{
		int initialIndex = GetHash(key);
		int index = initialIndex;
		int i = 0;

		while (isOccupied[index])
		{
			if (keys[index] == key) return values[index];
			i++;
			index = (initialIndex + i * i) % constraints;
			if (i >= constraints || index == initialIndex) return defaultValue;
		}

		return defaultValue;
	}

	public void Remove(int key)
	{
		int initialIndex = GetHash(key);
		int index = initialIndex;
		int i = 0;

		while (isOccupied[index])
		{
			if (keys[index] == key)
			{
				isOccupied[index] = false;
				values[index] = defaultValue;
				return;
			}
			i++;
			index = (initialIndex + i * i) % constraints;
			if (i >= constraints || index == initialIndex) return;
		}
	}
}