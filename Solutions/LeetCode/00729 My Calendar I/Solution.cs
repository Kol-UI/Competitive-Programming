// My Calendar I

/*
You are implementing a program to use as your calendar. We can add a new event if adding the event will not cause a double booking.

A double booking happens when two events have some non-empty intersection (i.e., some moment is common to both events.).

The event can be represented as a pair of integers start and end that represents a booking on the half-open interval [start, end), the range of real numbers x such that start <= x < end.

Implement the MyCalendar class:

MyCalendar() Initializes the calendar object.
boolean book(int start, int end) Returns true if the event can be added to the calendar successfully without causing a double booking. Otherwise, return false and do not add the event to the calendar.
 

Example 1:

Input
["MyCalendar", "book", "book", "book"]
[[], [10, 20], [15, 25], [20, 30]]
Output
[null, true, false, true]

Explanation
MyCalendar myCalendar = new MyCalendar();
myCalendar.book(10, 20); // return True
myCalendar.book(15, 25); // return False, It can not be booked because time 15 is already booked by another event.
myCalendar.book(20, 30); // return True, The event can be booked, as the first event takes every time less than 20, but not including 20.
*/


using System;
namespace CompetitiveProgramming.LeetCode.MyCalendarI
{
    public class MyCalendar
    {
        int max = (int)1e9;
        SegmentTreeNode root;
        public MyCalendar() {
            root = new SegmentTreeNode(0,max,false);
        }
        public bool Book(int start, int end)
        {
            var res = QueryRange(start,end);
            if (!res)
                AddRange(start,end);

            return !res;

        }
        public void AddRange(int left, int right) 
        {
            Update(root,left,right-1,true);
        }
        
        public bool QueryRange(int left, int right) 
        {
            return Search(root,left,right-1);
        }

        private void Update(SegmentTreeNode node, int begin, int end, bool state)
        {
            if (node.begin == begin && node.end == end) 
            {
                node.state = state;
                node.left = node.right = null!;
            }
            else
            {
                int mid = node.begin + (node.end-node.begin) / 2;
                if (node.left == null)
                {
                    node.left = new SegmentTreeNode(node.begin, mid, node.state);
                    node.right = new SegmentTreeNode(mid+1, node.end, node.state);
                }
                
                if (mid < begin) 
                    Update(node.right, begin, end, state);
                else if (mid+1 > end) 
                    Update(node.left, begin, end, state);
                else 
                {
                    Update(node.left, begin, mid, state);
                    Update(node.right, mid + 1, end, state);
                }
                
                node.state = node.left.state && node.right.state;
            }
        }
        
        private bool Search(SegmentTreeNode node, int begin, int end)
        {
            if (node.left == null) 
                return node.state;
            
            if (node.begin == begin && node.end == end) 
                return true;
            else
            {
                int mid = node.begin + (node.end-node.begin) / 2;
                if (mid < begin) 
                    return Search(node.right, begin, end);
                else if (mid+1 > end) 
                    return Search(node.left, begin, end);
                else 
                    return Search(node.left, begin, mid) || Search(node.right, mid+1, end);
            }
        }
    
        public class SegmentTreeNode
        {
            public bool state;
            public int begin, end;
            public SegmentTreeNode left, right;
            public SegmentTreeNode(int begin, int end, bool state)
            {
                this.state = state;
                this.begin = begin;
                this.end = end;
                this.left = null!;
                this.right = null!;
            }
        }
    }

    /**
    * Your MyCalendar object will be instantiated and called as such:
    * MyCalendar obj = new MyCalendar();
    * bool param_1 = obj.Book(start,end);
    */
}