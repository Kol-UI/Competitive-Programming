// Insert Delete GetRandom O(1)

/*
Implement the RandomizedSet class:

RandomizedSet() Initializes the RandomizedSet object.
bool insert(int val) Inserts an item val into the set if not present. Returns true if the item was not present, false otherwise.
bool remove(int val) Removes an item val from the set if present. Returns true if the item was present, false otherwise.
int getRandom() Returns a random element from the current set of elements (it's guaranteed that at least one element exists when this method is called). Each element must have the same probability of being returned.
You must implement the functions of the class such that each function works in average O(1) time complexity.

 

Example 1:

Input
["RandomizedSet", "insert", "remove", "insert", "getRandom", "remove", "insert", "getRandom"]
[[], [1], [2], [2], [], [1], [2], []]
Output
[null, true, false, true, 2, true, false, 2]

Explanation
RandomizedSet randomizedSet = new RandomizedSet();
randomizedSet.insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
randomizedSet.remove(2); // Returns false as 2 does not exist in the set.
randomizedSet.insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
randomizedSet.getRandom(); // getRandom() should return either 1 or 2 randomly.
randomizedSet.remove(1); // Removes 1 from the set, returns true. Set now contains [2].
randomizedSet.insert(2); // 2 was already in the set, so return false.
randomizedSet.getRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.
*/


using System;
namespace CompetitiveProgramming.LeetCode.InsertDeleteGetRandom
{
    public class RandomizedSet
    {
        private Random rnd = new();
        private Dictionary<int, int> map = new();
        private List<int> list = new();

        public RandomizedSet() {}
        
        public bool Insert(int val)
        {
            if(map.ContainsKey(val)) return false;
            list.Add(val);
            map.Add(val, list.Count - 1);
            return true;
        }
        public bool Remove(int val)
        {
            if(!map.ContainsKey(val)) return false;
            int lastVal = list[list.Count - 1];
            list[list.Count - 1] = val;
            list[map[val]] = lastVal;
            map[lastVal] = map[val];
            map.Remove(val);
            list.RemoveAt(list.Count - 1);
            return true;
        }
        public int GetRandom()
        {
            int idx = rnd.Next(0, list.Count);
            return list[idx];
        }
    }

    /**
    * Your RandomizedSet object will be instantiated and called as such:
    * RandomizedSet obj = new RandomizedSet();
    * bool param_1 = obj.Insert(val);
    * bool param_2 = obj.Remove(val);
    * int param_3 = obj.GetRandom();
    */

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Insert Delete GetRandom O(1)");
            TestDrivenDevelopment.ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}