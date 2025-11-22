// Postfix - Reverse Polish Notation

public class PostfixEvaluator
{
    // string[] tokens = { "2", "3", "+", "5", "*" }; // (2 + 3) * 5 = 25

    // ["3", "4", "+", "5", "6", "+", "*"] => (3 + 4) × (5 + 6) = 77
    public int EvaluatePostfix(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                if (stack.Count < 2)
                {
                    throw new InvalidOperationException("Invalid postfix expression: insufficient operands.");
                }

                int op2 = stack.Pop();
                int op1 = stack.Pop();
                int result;

                switch (token)
                {
                    case "+": result = op1 + op2; break;
                    case "-": result = op1 - op2; break;
                    case "*": result = op1 * op2; break;
                    case "/": 
                        if (op2 == 0) throw new DivideByZeroException();
                        result = op1 / op2; 
                        break;
                    default:
                        throw new InvalidOperationException($"Unsupported operator : {token}");
                }
                
                stack.Push(result);
            }
        }

        if (stack.Count != 1)
        {
            throw new InvalidOperationException("Invalid postfix expression.");
        }

        return stack.Pop();
    }
}