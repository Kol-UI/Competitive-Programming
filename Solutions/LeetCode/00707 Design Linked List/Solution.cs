// Design Linked List

/*
Design your implementation of the linked list. You can choose to use a singly or doubly linked list.
A node in a singly linked list should have two attributes: val and next. val is the value of the current node, and next is a pointer/reference to the next node.
If you want to use the doubly linked list, you will need one more attribute prev to indicate the previous node in the linked list. Assume all nodes in the linked list are 0-indexed.

Implement the MyLinkedList class:

MyLinkedList() Initializes the MyLinkedList object.
int get(int index) Get the value of the indexth node in the linked list. If the index is invalid, return -1.
void addAtHead(int val) Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
void addAtTail(int val) Append a node of value val as the last element of the linked list.
void addAtIndex(int index, int val) Add a node of value val before the indexth node in the linked list. If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, the node will not be inserted.
void deleteAtIndex(int index) Delete the indexth node in the linked list, if the index is valid.
 

Example 1:

Input
["MyLinkedList", "addAtHead", "addAtTail", "addAtIndex", "get", "deleteAtIndex", "get"]
[[], [1], [3], [1, 2], [1], [1], [1]]
Output
[null, null, null, null, 2, null, 3]

Explanation
MyLinkedList myLinkedList = new MyLinkedList();
myLinkedList.addAtHead(1);
myLinkedList.addAtTail(3);
myLinkedList.addAtIndex(1, 2);    // linked list becomes 1->2->3
myLinkedList.get(1);              // return 2
myLinkedList.deleteAtIndex(1);    // now the linked list is 1->3
myLinkedList.get(1);              // return 3
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DesignLinkedList
{
    public class MyLinkedList
    {
        public List<int> list;

        public MyLinkedList()
        {
            this.list = new List<int>();
        }

        public bool CheckValid(int index)
        {
            return (index < this.list.Count);
        }
        
        public int Get(int index)
        {
            return CheckValid(index) ? this.list[index] : -1;
        }
        
        public void AddAtHead(int val)
        {
            this.list.Insert(0, val);
        }
        
        public void AddAtTail(int val)
        {
            this.list.Add(val);
        }
        
        public void AddAtIndex(int index, int val)
        {
            if (index < this.list.Count)
            {
                this.list.Insert(index, val);
            }
            else if (index == this.list.Count)
            {
                AddAtTail(val);
            }
        }
        
        public void DeleteAtIndex(int index)
        {
            if (CheckValid(index))
            {
                this.list.RemoveAt(index);
            }
        }
    }

    /**
    * Your MyLinkedList object will be instantiated and called as such:
    * MyLinkedList obj = new MyLinkedList();
    * int param_1 = obj.Get(index);
    * obj.AddAtHead(val);
    * obj.AddAtTail(val);
    * obj.AddAtIndex(index,val);
    * obj.DeleteAtIndex(index);
    */

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Design Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}