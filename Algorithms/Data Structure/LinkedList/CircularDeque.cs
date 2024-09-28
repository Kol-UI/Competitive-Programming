namespace CompetitiveProgramming.Algorithms
{
    public class CircularDeque
    {
        #region LC641
        class Node
        {
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
        public CircularDeque(int k)
        {
            len = 0;
            size = k;
            head = new Node(0);
            tail = new Node(0);
            head.next = tail;
            tail.prev = head;
        }
        
        public bool InsertFront(int value)
        {
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
        
        public bool InsertLast(int value)
        {
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
        
        public bool DeleteFront()
        {
            if(len > 0 && len <= size)
            {
                head.next = head.next!.next;
                len--;
                return true;
            }
            return false;
        }
        
        public bool DeleteLast() 
        {
            if(len > 0 && len <= size)
            {
                tail.prev = tail.prev!.prev;
                len--;
                return true;
            } 
            return false;
        }
        
        public int GetFront() 
        {
            if(len > 0)
            {
                return head.next!.val;
            }
            return -1;
        }
        
        public int GetRear()
        {
            if(len > 0)
            {
                return tail.prev!.val;
            }
            return -1;
        }
        
        public bool IsEmpty()
        {
            if(len == 0)
            {
                return true;
            }
            return false;
        }
        
        public bool IsFull()
        {
            if(len == size)
            {
                return true;
            }
            return false;
        }
    }
    #endregion
}