Boats to Save People :

You are given an integer array people where people[i] is the weight of the ith person, and an infinite number of boats where each boat can carry a maximum weight of limit.

Each boat carries at most two people at the same time, provided the sum of the weight of those people is at most limit.

Return the minimum number of boats to carry every given person.



Example 1:

Input: people = [5,1,4,2], limit = 6

Output: 2

Explanation:

First boat [5,1].

Second boat [4,2].



Example 2:

Input: people = [1,3,2,3,2], limit = 3

Output: 4

Explanation:

First boat [3].

Second boat [3].

Third boat [1,2].

Fourth boat [2].


```cs
// Two Pointers Approch
public class BoatstoSavePeople
{
	public int NumRescueBoats(int[] people, int limit)
	{
		Array.Sort(people);
		int left = 0;
		int right = people.Length - 1;
		int numberOfBoats = 0;
		// left = lightest person
		// right = heaviest person
		while (left <= right)
		{
			// heavy passenger
			int remain = limit - people[right];
			right--;
			numberOfBoats++;

			// light passenger
			if (left <= right && remain >= people[left])
			{
				left++;
			}
		}
		return numberOfBoats;
	}
}
```