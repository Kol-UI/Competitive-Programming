namespace CompetitiveProgramming.Algorithms;

public class ReverseQueue
{
    // Approach 1 : Stack
    public void ReverseWithStack(Queue<int> queue)
    {
        Stack<int> stack = [];

        while (queue.Count > 0)
            stack.Push(queue.Dequeue());

        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());
    }

    // Approach 2 : Recursive
    public void ReverseRecursive(Queue<int> queue)
    {
        if (queue.Count == 0)
            return;

        int front = queue.Dequeue();
        ReverseRecursive(queue);
        queue.Enqueue(front);
    }

    // Approach 3 : Linq
    public void ReverseQueueLinq(Queue<int> queue)
    {
        var reversed = queue.Reverse().ToList();
        queue.Clear();
        foreach (var item in reversed)
        {
            queue.Enqueue(item);
        }
    }
}