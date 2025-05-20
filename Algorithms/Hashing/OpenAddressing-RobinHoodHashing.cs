namespace CompetitiveProgramming.Algorithms;

// Open Addressing - Robin Hood Hashing
// With Linear or Quadratic Probing, some keys can be very "unlucky" and end up
// far from their ideal hash position after a long collision chain.
// Others might be very "lucky" and land directly in their ideal spot.
// Robin Hood Hashing aims to balance the "wealth" (probe distance) between elements.
// For each element, we calculate its "Preferred Probe Distance" (PPD) or sometimes called
// "Proximity to Home" (PTH) : the distance between the element's ideal hash position
// and its current position in the table.
// Benefit: All elements tend to be "roughly" the same distance from their ideal hash.
// Example: In a parking lot, each car has a "preferred spot" (its initial hash).
// We "steal from the rich" (close elements) to "give to the poor" (distant ones).
public class MyHashMapRobinHood
{
	private readonly int constraints;
	private readonly int defaultValue = -1;
	private int[] keys;
	private int[] values;
	private int[] preferredProbeDistance;
	private int currentSize;

	public MyHashMapRobinHood(int size = 1000003)
	{
		constraints = size;

		keys = new int[constraints];
		values = new int[constraints];
		preferredProbeDistance = new int[constraints];

		for (int i = 0; i < constraints; i++)
		{
			keys[i] = defaultValue;
			values[i] = defaultValue;
			preferredProbeDistance[i] = defaultValue;
		}
		currentSize = 0;
	}

	private int GetHash(int key)
	{
		return Math.Abs(key.GetHashCode()) % constraints;
	}

	private int CalculatePreferredProbeDistance(int homeIndex, int currentIndex)
	{
		return (currentIndex - homeIndex + constraints) % constraints;
	}

	public void Put(int key, int value)
	{
		int homeIndex = GetHash(key);

		int currentKey = key;
		int currentValue = value;

		int probeIndex = homeIndex;

		for (int i = 0; i < constraints; i++)
		{
			if (values[probeIndex] == defaultValue)
			{
				keys[probeIndex] = currentKey;
				values[probeIndex] = currentValue;
				preferredProbeDistance[probeIndex] = i;
				currentSize++;
				return;
			}

			if (keys[probeIndex] == currentKey)
			{
				values[probeIndex] = currentValue;
				return;
			}

			if (i > preferredProbeDistance[probeIndex])
			{
				int tempKey = keys[probeIndex];
				int tempValue = values[probeIndex];
				int tempPreferredProbeDistance = preferredProbeDistance[probeIndex];

				keys[probeIndex] = currentKey;
				values[probeIndex] = currentValue;
				preferredProbeDistance[probeIndex] = i;

				currentKey = tempKey;
				currentValue = tempValue;
				i = tempPreferredProbeDistance;
			}

			probeIndex = (probeIndex + 1) % constraints;
		}
		throw new InvalidOperationException("Hash table is full or insertion failed due to unhandled condition.");
	}

	public int Get(int key)
	{
		int homeIndex = GetHash(key);
		int probeIndex = homeIndex;

		for (int i = 0; i < constraints; i++)
		{
			if (values[probeIndex] == defaultValue && preferredProbeDistance[probeIndex] == defaultValue) return defaultValue;
			if (keys[probeIndex] == key) return values[probeIndex];
			if (preferredProbeDistance[probeIndex] > i) return defaultValue;
			probeIndex = (probeIndex + 1) % constraints;
		}
		return defaultValue;
	}

	public void Remove(int key)
	{
		int homeIndex = GetHash(key);
		int probeIndex = homeIndex;

		for (int i = 0; i < constraints; i++)
		{
			if (values[probeIndex] == defaultValue && preferredProbeDistance[probeIndex] == defaultValue) return;

			if (keys[probeIndex] == key)
			{
				keys[probeIndex] = defaultValue;
				values[probeIndex] = defaultValue;
				preferredProbeDistance[probeIndex] = defaultValue;
				currentSize--;
				return;
			}

			if (preferredProbeDistance[probeIndex] > i) return;

			probeIndex = (probeIndex + 1) % constraints;
		}
	}

	public bool CheckIntegrity()
	{
		for (int i = 0; i < constraints; i++)
		{
			if (values[i] != defaultValue)
			{
				int actualKey = keys[i];
				int actualPreferredProbeDistance = preferredProbeDistance[i];
				int homeOfActualKey = GetHash(actualKey);

				if (actualPreferredProbeDistance != CalculatePreferredProbeDistance(homeOfActualKey, i))
				{
					Console.WriteLine($"Integrity violated: Stored PSP ({actualPreferredProbeDistance}) for key {actualKey} at index {i} does not match calculated PSP ({CalculatePreferredProbeDistance(homeOfActualKey, i)}).");
					return false;
				}
			}
		}
		return true;
	}

	public double LoadFactor => (double)currentSize / constraints;
}