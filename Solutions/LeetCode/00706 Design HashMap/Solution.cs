// Design HashMap

/*
Design a HashMap without using any built-in hash table libraries.

Implement the MyHashMap class:

MyHashMap() initializes the object with an empty map.
void put(int key, int value) inserts a (key, value) pair into the HashMap. If the key already exists in the map, update the corresponding value.
int get(int key) returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
void remove(key) removes the key and its corresponding value if the map contains the mapping for the key.
 

Example 1:

Input
["MyHashMap", "put", "put", "get", "get", "put", "get", "remove", "get"]
[[], [1, 1], [2, 2], [1], [3], [2, 1], [2], [2], [2]]
Output
[null, null, null, 1, -1, null, 1, null, -1]

Explanation
MyHashMap myHashMap = new MyHashMap();
myHashMap.put(1, 1); // The map is now [[1,1]]
myHashMap.put(2, 2); // The map is now [[1,1], [2,2]]
myHashMap.get(1);    // return 1, The map is now [[1,1], [2,2]]
myHashMap.get(3);    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
myHashMap.put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
myHashMap.get(2);    // return 1, The map is now [[1,1], [2,1]]
myHashMap.remove(2); // remove the mapping for 2, The map is now [[1,1]]
myHashMap.get(2);    // return -1 (i.e., not found), The map is now [[1,1]]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DesignHashMap
{
    // Direct Address Table
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


    public class MyHashMap2
    {
        class Data
        {
            public int Key;
            public int Value;
        }

        private LinkedList<Data>?[] _data = new LinkedList<Data>?[1000];

        public void Put(int key, int value)
        {
            var index = key % _data.Length;

            _data[index] ??= new LinkedList<Data>();

            var node = _data[index]!.First;
            while (node != null)
            {
                if (node.Value.Key == key)
                {
                    node.Value.Value = value;
                    return;
                }

                node = node.Next;
            }

            _data[index]!.AddFirst(new Data {Key = key, Value = value});
        }

        public int Get(int key)
        {
            var node = GetNode(key);
            return node != null ? node.Value.Value : -1;
        }

        public void Remove(int key)
        {
            var node = GetNode(key);
            if (node != null)
            {
                _data[key % _data.Length]!.Remove(node);
            }
        }

        private LinkedListNode<Data>? GetNode(int key)
        {
            var node = _data[key % _data.Length]?.First;
            while (node != null)
            {
                if (node.Value.Key == key)
                {
                    return node;
                }

                node = node.Next;
            }

            return null;
        }
    }

    /**
    * Your MyHashMap object will be instantiated and called as such:
    * MyHashMap obj = new MyHashMap();
    * obj.Put(key,value);
    * int param_2 = obj.Get(key);
    * obj.Remove(key);
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design HashMap");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}