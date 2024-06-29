// All Ancestors of a Node in a Directed Acyclic Graph

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AllAncestorsofaNodeinaDirectedAcyclicGraph
{
    public class Solution
    {
        private readonly Dictionary<int, List<int>> _dictionary = new Dictionary<int, List<int>>();
        
        public IList<IList<int>> GetAncestors(int n, int[][] edges)
        {
            var result = new List<IList<int>>();

            Initialize(n);
            Fill(edges);

            for (int i = 0; i < n; i++)
            {
                result.Add(Transform(TraversePath(i)));
            }
            
            return result;
        }

        void Initialize(int size)
        {
            for (int i = 0; i < size; i++)
            {
                _dictionary[i] = new List<int>();
            }
        }

        void Fill(int[][] edges)
        {
            foreach (var edge in edges)
            {
                _dictionary[edge[1]].Add(edge[0]);
            }
        }

        Stack<int> TraversePath(int vertix)
        {
            var path = new Stack<int>();
            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            
            queue.Enqueue(vertix);
            visited.Add(vertix);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current != vertix)
                {
                    path.Push(current);
                }

                for (int i = _dictionary[current].Count - 1; i >= 0; i--)
                {
                    var nextVertix = _dictionary[current][i];
                    if (!visited.Contains(nextVertix))
                    {
                        visited.Add(nextVertix);
                        queue.Enqueue(nextVertix);
                    }
                }
            }

            return path;
        }

        List<int> Transform(Stack<int> values)
        {
            var result = new List<int>(values.Count);
            
            while (values.Count != 0)
            {
                result.Add(values.Pop());
            }

            result.Sort();

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("All Ancestors of a Node in a Directed Acyclic Graph");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}