Implement a last-in-first-out (LIFO) stack using only two queues.

The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).

Implement the MyStack class:

void push(int x) Pushes element x to the top of the stack.

int pop() Removes the element on the top of the stack and returns it.

int top() Returns the element on the top of the stack.

boolean empty() Returns true if the stack is empty, false otherwise.


Notes:

You must use only standard operations of a queue, which means that only push to back, peek/pop from front, size and is empty operations are valid.

Depending on your language, the queue may not be supported natively.

You may simulate a queue using a list or deque (double-ended queue) as long as you use only a queue's standard operations.


Example 1:

Input: ["MyStack", "push", "push", "top", "pop", "empty"]

[[], [1], [2], [], [], []]

Output: [null, null, null, 2, 2, false]

Explanation:

MyStack myStack = new MyStack();

myStack.push(1);

myStack.push(2);

myStack.top(); // return 2

myStack.pop(); // return 2

myStack.empty(); // return False


```cs

// Two Queues Approch

public class MyStackTwoQueues
{
    private Queue<int> mainQueue; // Contain Stack, top in front
    private Queue<int> tempQueue;

    public MyStackTwoQueues() 
    {
        mainQueue = new();
        tempQueue = new();
    }

    public void Push(int x) 
    {
        // 1) add new element
        tempQueue.Enqueue(x);

        // 2) transfer old elements after new one
        while (mainQueue.Count > 0)
        {
            tempQueue.Enqueue(mainQueue.Dequeue());
        }

        // 3) swap queues.
        (tempQueue, mainQueue) = (mainQueue, tempQueue);
    }

    /*
        Swap example : 

        oldest on left
        mainQueue [1, 2, 3]

        - Push(4) :

        Step 1 :
        tempQueue [4]
        mainQueue [1, 2, 3]

        Step 2 :
        tempQueue [4, 1, 2, 3]
        mainQueue []

        Step 3 (Swap) :
        tempQueue []
        mainQueue [4, 1, 2, 3]


        Pop :
        mainQueue [1, 2, 3]
        return 4

        Top :
        mainQueue [4, 1, 2, 3]
        return 4

        Empty :
        mainQueue [4, 1, 2, 3]
        return false

    */

    public int Pop() => mainQueue.Dequeue();

    public int Top() => mainQueue.Peek();

    public bool Empty() => mainQueue.Count == 0;
}




// One Queue Approch

public class MyStackOneQueue
{
    private Queue<int> mainQueue;

    public MyStackOneQueue() 
    {
        mainQueue = new();
    }

    public void Push(int x) 
    {
        // 1) add new element
        mainQueue.Enqueue(x);

        // 2) move oldest values to put at start
        int count = mainQueue.Count;
        for(int i = 0; i < count - 1; i++)
        {
            int value = mainQueue.Dequeue();
            mainQueue.Enqueue(value);
        }
    }

    /*
        Swap example : 

        oldest on left
        mainQueue [1, 2, 3]

        - Push(4) :

        Step 1 :
        mainQueue [1, 2, 3, 4]

        Step 2 (Loop) :
        - mainQueue [1, 2, 3, 4]
        - mainQueue [2, 3, 4, 1]
        - mainQueue [3, 4, 1, 2]
        - mainQueue [4, 1, 2, 3]

        Pop :
        mainQueue [1, 2, 3]
        return 4

        Top :
        mainQueue [4, 1, 2, 3]
        return 4

        Empty :
        mainQueue [4, 1, 2, 3]
        return false

    */

    public int Pop() => mainQueue.Dequeue();

    public int Top() => mainQueue.Peek();

    public bool Empty() => mainQueue.Count == 0;
}
```