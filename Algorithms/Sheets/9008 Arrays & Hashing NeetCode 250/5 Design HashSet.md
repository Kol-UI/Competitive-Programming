Design a HashSet without using any built-in hash table libraries.

Implement MyHashSet class:

void add(key) Inserts the value key into the HashSet.
bool contains(key) Returns whether the value key exists in the HashSet or not.
void remove(key) Removes the value key in the HashSet. If key does not exist in the HashSet, do nothing.
 
0 <= key <= 10^6


```cs
public class MyHashSet
{
	private readonly int constraints = 1000001;
	private bool[] values;

	public MyHashSet()
	{
		values = new bool[constraints];
	}

	public void Add(int key) => values[key] = true;

	public void Remove(int key) => values[key] = false;

	public bool Contains(int key) => values[key];
}
```


'constraints' defines the maximum possible value for a key that this HashSet can handle.
It's set to 1000001, implying keys will be in the range [0, 1000000].
'values' represents the HashSet.