// Transform the Expression



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.SphereOnlineJudge.TransformtheExpression
{
    class Program
    {
        static int GetOperatorPriority(char op)
        {
            return op switch
            {
                '+' or '-' => 1,
                '*' or '/' => 2,
                '^' => 3,
                _ => 0,
            };
        }

        static string InfixToRPN(string infix)
        {
            Stack<char> operatorStack = new();
            List<char> output = new();

            foreach (char token in infix)
            {
                if (char.IsLetter(token))
                {
                    output.Add(token);
                }
                else if (token == '(')
                {
                    operatorStack.Push(token);
                }
                else if (token == ')')
                {
                    while (operatorStack.Count > 0 && operatorStack.Peek() != '(')
                    {
                        output.Add(operatorStack.Pop());
                    }
                    operatorStack.Pop();
                }
                else
                {
                    while (operatorStack.Count > 0 && GetOperatorPriority(operatorStack.Peek()) >= GetOperatorPriority(token))
                    {
                        output.Add(operatorStack.Pop());
                    }
                    operatorStack.Push(token);
                }
            }

            while (operatorStack.Count > 0)
            {
                output.Add(operatorStack.Pop());
            }

            return new string(output.ToArray());
        }

        //static void Main()
        static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                string expression = Console.ReadLine()!;
                string rpn = InfixToRPN(expression);
                Console.WriteLine(rpn);
            }
        }
    }
}