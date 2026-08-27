Reverse a Stack

```cs
// Reverse the order of elements in a stack.
public class ReverseStack
{
    // Recursive approach
    public void ReverseRecursive(Stack<int> stack)
    {
        if (stack.Count == 0)
            return;

        int top = stack.Pop();
        ReverseRecursive(stack);
        InsertAtBottom(stack, top);
    }

    // Helper: insert an item at the bottom of the stack recursively
    private void InsertAtBottom(Stack<int> stack, int item)
    {
        if (stack.Count == 0)
        {
            stack.Push(item);
            return;
        }

        int top = stack.Pop();
        InsertAtBottom(stack, item);
        stack.Push(top);
    }

    // Single pass approach: pop from origin, push into a new stack
    // The new stack holds reversed order
    public Stack<int> ReverseSinglePass(Stack<int> origin)
    {
        Stack<int> result = [];

        while (origin.Count > 0)
            result.Push(origin.Pop());

        return result;
    }
    
    // Linq approach
    public Stack<int> ReverseStackLinq(Stack<int> stack)
    {
        var reversed = stack.ToList();
        stack.Clear();
        foreach (var item in reversed)
        {
            stack.Push(item);
        }
        return stack;
    }
}```