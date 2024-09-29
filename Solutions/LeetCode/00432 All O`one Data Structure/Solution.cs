// All O`one Data Structure

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AllOoneDataStructure
{
    /*
    public class AllOne
    {
        private class Node
        {
            public int Count;
            public HashSet<string> Keys;
            public Node Prev;
            public Node Next;

            public Node(int count)
            {
                Count = count;
                Keys = new HashSet<string>();
            }
        }

        private readonly Dictionary<string, Node> keyCount;
        private readonly Node head;
        private readonly Node tail;

        public AllOne()
        {
            keyCount = new Dictionary<string, Node>();
            head = new Node(0);
            tail = new Node(0);
            head.Next = tail;
            tail.Prev = head;
        }

        private void AddNodeAfter(Node newNode, Node prevNode)
        {
            newNode.Next = prevNode.Next;
            newNode.Prev = prevNode;
            prevNode.Next.Prev = newNode;
            prevNode.Next = newNode;
        }

        private void RemoveNode(Node node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
        }

        public void Inc(string key)
        {
            if (keyCount.ContainsKey(key))
            {
                Node currentNode = keyCount[key];
                currentNode.Keys.Remove(key);

                if (currentNode.Next == tail || currentNode.Next.Count > currentNode.Count + 1)
                {
                    Node newNode = new Node(currentNode.Count + 1);
                    AddNodeAfter(newNode, currentNode);
                }

                currentNode.Next.Keys.Add(key);
                keyCount[key] = currentNode.Next;

                if (currentNode.Keys.Count == 0)
                {
                    RemoveNode(currentNode);
                }
            }
            else
            {
                if (head.Next == tail || head.Next.Count > 1)
                {
                    Node newNode = new Node(1);
                    AddNodeAfter(newNode, head);
                }

                head.Next.Keys.Add(key);
                keyCount[key] = head.Next;
            }
        }

        public void Dec(string key)
        {
            if (!keyCount.ContainsKey(key))
                return;

            Node currentNode = keyCount[key];
            currentNode.Keys.Remove(key);

            if (currentNode.Count > 1)
            {
                if (currentNode.Prev == head || currentNode.Prev.Count < currentNode.Count - 1)
                {
                    Node newNode = new Node(currentNode.Count - 1);
                    AddNodeAfter(newNode, currentNode.Prev);
                }

                currentNode.Prev.Keys.Add(key);
                keyCount[key] = currentNode.Prev;
            }
            else
            {
                keyCount.Remove(key);
            }

            if (currentNode.Keys.Count == 0)
            {
                RemoveNode(currentNode);
            }
        }

        public string GetMaxKey()
        {
            if (tail.Prev == head)
                return "";

            foreach (var key in tail.Prev.Keys)
            {
                return key;
            }

            return "";
        }

        public string GetMinKey()
        {
            if (head.Next == tail)
                return "";

            foreach (var key in head.Next.Keys)
            {
                return key;
            }

            return "";
        }
    }
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("All O`one Data Structure");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }

    /**
    * Your AllOne object will be instantiated and called as such:
    * AllOne obj = new AllOne();
    * obj.Inc(key);
    * obj.Dec(key);
    * string param_3 = obj.GetMaxKey();
    * string param_4 = obj.GetMinKey();
    */
}