namespace CompetitiveProgramming.Algorithms;

// Direct Address Table
// Array for keys & Array for values
public class MyHashMap
{
	private readonly int constraints = 1000001;
	private readonly int defaultValue = -1;
	private bool[] keys;
	private int[] values;

	public MyHashMap()
	{
		keys = new bool[constraints];
		values = new int[constraints];
		for (int i = 0; i < constraints; i++)
		{
			values[i] = defaultValue;
		}
	}

	public void Put(int key, int value)
	{
		keys[key] = true;
		values[key] = value;
	}

	public int Get(int key) => keys[key] ? values[key] : defaultValue;

	public void Remove(int key)
	{
		keys[key] = false;
		values[key] = defaultValue;
	}
}

