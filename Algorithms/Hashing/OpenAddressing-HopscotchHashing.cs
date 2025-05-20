namespace CompetitiveProgramming.Algorithms;

// Open Addressing - Hopscotch Hashing
// Uses an array with a neighborhood system
// If the spot is taken, search within the neighborhood
// If the empty slot is too far, it will relocate elements along the path,
// similar to rearranging cars in a parking lot to fit a new one in
// But note: These relocations are constrained, an element can only be moved
// if it stays within the neighborhood of its own ideal hash position
// Each table slot maintains a small bitfield indicating which nearby keys
// consider this slot their ideal hash position
// A car (element) can never be moved to a position that would place it
// outside its own neighborhood relative to its ideal hash position (its center)
// Summary: In a parking lot, if a car's spot is taken, it will push other cars around
public class MyHashMapHopscotch
{
	private readonly int constraints;
	private readonly int defaultValue = -1;
	private readonly int H;

	private int[] keys;
	private int[] values;
	private ulong[] hopInfo;

	private int currentSize;

	private const int MAX_LINEAR_PROBE_FOR_EMPTY = 128;
	private const int MAX_RELOCATE_ATTEMPTS = 512;

	public MyHashMapHopscotch(int size = 100003, int neighborhoodSize = 32)
	{
		if (size <= neighborhoodSize)
		{
			throw new ArgumentException("Table size must be greater than neighborhood size (H).");
		}
		constraints = size;
		H = neighborhoodSize;

		keys = new int[constraints];
		values = new int[constraints];
		hopInfo = new ulong[constraints];

		for (int i = 0; i < constraints; i++)
		{
			keys[i] = defaultValue;
			values[i] = defaultValue;
			hopInfo[i] = 0;
		}
		currentSize = 0;
	}

	private int GetHash(int key)
	{
		return Math.Abs(key.GetHashCode()) % constraints;
	}

	private int GetDistance(int homeIndex, int currentIndex)
	{
		return (currentIndex - homeIndex + constraints) % constraints;
	}

	public void Put(int key, int value)
	{
		int homeIndex = GetHash(key);

		ulong currentHopInfo = hopInfo[homeIndex];
		for (int offset = 0; offset < H; offset++)
		{
			if (((currentHopInfo >> offset) & 1UL) != 0)
			{
				int probedIndex = (homeIndex + offset) % constraints;
				if (keys[probedIndex] == key)
				{
					values[probedIndex] = value;
					return;
				}
			}
		}

		int emptySpot = -1;
		int probeCount = 0;

		for (int i = 0; i < constraints; i++)
		{
			int checkIndex = (homeIndex + i) % constraints;
			if (values[checkIndex] == defaultValue)
			{
				emptySpot = checkIndex;
				break;
			}
			probeCount++;
			if (probeCount > MAX_LINEAR_PROBE_FOR_EMPTY && currentSize > constraints / 2)
			{
				throw new InvalidOperationException("Hash table too full or congested, unable to find an empty slot quickly. Resizing required.");
			}
		}

		if (emptySpot == -1)
		{
			throw new InvalidOperationException("The hash table is full.");
		}

		int targetIndex = emptySpot;
		int attempts = 0;

		while (GetDistance(homeIndex, targetIndex) >= H)
		{
			int bestSourceIndex = -1;

			for (int offset = 1; offset < H; offset++)
			{
				int candidateSourceIndex = (targetIndex - offset + constraints) % constraints;
				if (values[candidateSourceIndex] != defaultValue)
				{
					int candidateHomeIndex = GetHash(keys[candidateSourceIndex]);

					if (GetDistance(candidateHomeIndex, targetIndex) < H)
					{
						bestSourceIndex = candidateSourceIndex;
						break;
					}
				}
			}

			if (bestSourceIndex != -1)
			{
				int movedKey = keys[bestSourceIndex];
				int movedValue = values[bestSourceIndex];
				int movedHomeIndex = GetHash(movedKey);

				keys[targetIndex] = movedKey;
				values[targetIndex] = movedValue;

				hopInfo[movedHomeIndex] &= ~(1UL << GetDistance(movedHomeIndex, bestSourceIndex));
				hopInfo[movedHomeIndex] |= (1UL << GetDistance(movedHomeIndex, targetIndex));

				keys[bestSourceIndex] = defaultValue;
				values[bestSourceIndex] = defaultValue;

				targetIndex = bestSourceIndex;
			}
			else
			{
				throw new InvalidOperationException("Unable to relocate an element to bring the empty slot closer. The table might be full or requires resizing.");
			}

			attempts++;
			if (attempts > MAX_RELOCATE_ATTEMPTS)
			{
				throw new InvalidOperationException("Too many relocation attempts to insert the key. Resizing suggested.");
			}
		}

		keys[targetIndex] = key;
		values[targetIndex] = value;

		hopInfo[homeIndex] |= (1UL << GetDistance(homeIndex, targetIndex));
		currentSize++;
	}

	public int Get(int key)
	{
		int homeIndex = GetHash(key);
		ulong currentHopInfo = hopInfo[homeIndex];

		for (int offset = 0; offset < H; offset++)
		{
			if (((currentHopInfo >> offset) & 1UL) != 0)
			{
				int probeIndex = (homeIndex + offset) % constraints;
				if (keys[probeIndex] == key) return values[probeIndex];
			}
		}
		return defaultValue;
	}

	public void Remove(int key)
	{
		int homeIndex = GetHash(key);
		ulong currentHopInfo = hopInfo[homeIndex];

		for (int offset = 0; offset < H; offset++)
		{
			if (((currentHopInfo >> offset) & 1UL) != 0)
			{
				int probeIndex = (homeIndex + offset) % constraints;
				if (keys[probeIndex] == key)
				{
					keys[probeIndex] = defaultValue;
					values[probeIndex] = defaultValue;

					hopInfo[homeIndex] &= ~(1UL << offset);
					currentSize--;
					return;
				}
			}
		}
	}

	public bool CheckIntegrity()
	{
		for (int i = 0; i < constraints; i++)
		{
			if (values[i] != defaultValue)
			{
				int actualKey = keys[i];
				int homeOfActualKey = GetHash(actualKey);
				int distance = GetDistance(homeOfActualKey, i);

				if (distance >= H)
				{
					Console.WriteLine($"Integrity violated: Key {actualKey} at index {i} is too far from its home {homeOfActualKey}. Distance: {distance}");
					return false;
				}

				if (((hopInfo[homeOfActualKey] >> distance) & 1UL) == 0)
				{
					Console.WriteLine($"Integrity violated: Bit not set for key {actualKey} at index {i} (home {homeOfActualKey}, distance {distance}) in hopInfo."); 
					return false;
				}
			}
		}
		return true;
	}

	public double LoadFactor => (double)currentSize / constraints;
}