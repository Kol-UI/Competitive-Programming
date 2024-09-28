// Design Circular Deque

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DesignCircularDeque
{
    public class MyCircularDeque {
        class Node{
            public int val;
            public Node? next;
            public Node? prev;

            public Node(int val)
            {
                this.val = val;
            }
        }
        private Node head;
        private Node tail;
        private int len;
        private int size;
        public MyCircularDeque(int k) {
            len = 0;
            size = k;
            head = new Node(0);
            tail = new Node(0);
            head.next = tail;
            tail.prev = head;
        }
        
        public bool InsertFront(int value) {
            if(len == 0)
            {
                Node temp = new Node(value);
                head.next = temp;
                temp.prev = head;
                temp.next = tail;
                tail.prev = temp;
                len++;
                return true;
            }
            else if(len > 0 && len < size)
            {
                Node temp = new Node(value);
                Node headNext = head.next!;
                head.next = temp;
                temp.prev = head;
                temp.next = headNext;
                headNext.prev = temp;
                len++;
                return true;
            }
            return false;
        }
        
        public bool InsertLast(int value) {
            if(len == 0)
            {
            return InsertFront(value);
            }
            else if(len > 0 && len < size)
            {
                Node temp = new Node(value);
                Node tailPrev = tail.prev!;
                
                tail.prev = temp;
                temp.next = tail;
                temp.prev = tailPrev;
                tailPrev.next = temp;
                len++;
                return true;
            }
            return false;
        }
        
        public bool DeleteFront() {
            if(len > 0 && len <= size)
            {
                head.next = head.next!.next;
                len--;
                return true;
            }
            return false;
        }
        
        public bool DeleteLast() {
        if(len > 0 && len <= size)
        {
            tail.prev = tail.prev!.prev;
            len--;
            return true;
        } 
        return false;
        }
        
        public int GetFront() {
            if(len > 0)
            {
                return head.next!.val;
            }
            return -1;
        }
        
        public int GetRear() {
            if(len > 0)
            {
                return tail.prev!.val;
            }
            return -1;
        }
        
        public bool IsEmpty() {
            if(len == 0)
            {
                return true;
            }
            return false;
        }
        
        public bool IsFull() {
            if(len == size)
            {
                return true;
            }
            return false;
        }
    }

    /**
    * Your MyCircularDeque object will be instantiated and called as such:
    * MyCircularDeque obj = new MyCircularDeque(k);
    * bool param_1 = obj.InsertFront(value);
    * bool param_2 = obj.InsertLast(value);
    * bool param_3 = obj.DeleteFront();
    * bool param_4 = obj.DeleteLast();
    * int param_5 = obj.GetFront();
    * int param_6 = obj.GetRear();
    * bool param_7 = obj.IsEmpty();
    * bool param_8 = obj.IsFull();
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Circular Deque");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}