// Snapshot Array

/*
Implement a SnapshotArray that supports the following interface:

SnapshotArray(int length) initializes an array-like data structure with the given length. Initially, each element equals 0.
void set(index, val) sets the element at the given index to be equal to val.
int snap() takes a snapshot of the array and returns the snap_id: the total number of times we called snap() minus 1.
int get(index, snap_id) returns the value at the given index, at the time we took the snapshot with the given snap_id
 

Example 1:

Input: ["SnapshotArray","set","snap","set","get"]
[[3],[0,5],[],[0,6],[0,0]]
Output: [null,null,0,null,5]
Explanation: 
SnapshotArray snapshotArr = new SnapshotArray(3); // set the length to be 3
snapshotArr.set(0,5);  // Set array[0] = 5
snapshotArr.snap();  // Take a snapshot, return snap_id = 0
snapshotArr.set(0,6);
snapshotArr.get(0,0);  // Get the value of array[0] with snap_id = 0, return 5
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SnapshotArray
{
    public class SnapshotArray
    {
        private readonly List<Dictionary<int, int>> _array;
        private int _snapshotId;

        public SnapshotArray(int length)
        {
            _array = new List<Dictionary<int, int>>(length);

            for (var i = 0; i < length; i++)
                _array.Add(new Dictionary<int, int> {[0] = 0});
        }

        public void Set(int index, int val)
        {
            _array[index][_snapshotId] = val;
        }

        public int Snap()
        {
            return _snapshotId++;
        }

        public int Get(int index, int snapId)
        {
            var dictionary = _array[index];
            
            while (!dictionary.ContainsKey(snapId))
                --snapId;

            return dictionary[snapId];
        }
    }

    /**
    * Your SnapshotArray object will be instantiated and called as such:
    * SnapshotArray obj = new SnapshotArray(length);
    * obj.Set(index,val);
    * int param_2 = obj.Snap();
    * int param_3 = obj.Get(index,snap_id);
    */

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Snapshot Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}