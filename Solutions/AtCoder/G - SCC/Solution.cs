// SCC

using System;
using System.Collections.Generic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.AtCoder.GSCC
{
    class Program
    {
        private static int N, M;
        private static List<int>[]? graph, reverseGraph;
        private static bool[]? visited;
        private static Stack<int>? stack;
        
        private static void SCCMain()
        {
            string[] input = Console.ReadLine()!.Split();
            N = int.Parse(input[0]);
            M = int.Parse(input[1]);

            graph = new List<int>[N];
            reverseGraph = new List<int>[N];
            for (int i = 0; i < N; i++)
            {
                graph[i] = new List<int>
                {
                    [i] = new()
                };
            }

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine()!.Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                graph[a].Add(b);
                reverseGraph[b].Add(a);
            }

            visited = new bool[N];
            stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                if (!visited[i])
                {
                    DFS(i);
                }
            }

            Array.Clear(visited, 0, visited.Length);

            List<List<int>> components = new();
            while (stack.Count > 0)
            {
                int v = stack.Pop();
                if (!visited[v])
                {
                    List<int> component = new();
                    ReverseDFS(v, component);
                    components.Add(component);
                }
            }

            Console.WriteLine(components.Count);
            foreach (var component in components)
            {
                Console.Write(component.Count);
                foreach (var vertex in component)
                {
                    Console.Write(" " + vertex);
                }
                Console.WriteLine();
            }
        }

        static void DFS(int v)
        {
            visited![v] = true;
            foreach (var neighbor in graph![v])
            {
                if (!visited[neighbor])
                {
                    DFS(neighbor);
                }
            }
            stack!.Push(v);
        }

        static void ReverseDFS(int v, List<int> component)
        {
            visited![v] = true;
            component.Add(v);
            foreach (var neighbor in reverseGraph![v])
            {
                if (!visited[neighbor])
                {
                    ReverseDFS(neighbor, component);
                }
            }
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("SCC");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder, ProblemCategory.BeginnerAC);
        }
    }
}