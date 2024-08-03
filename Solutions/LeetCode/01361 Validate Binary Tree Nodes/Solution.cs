// Validate Binary Tree Nodes

/*
You have n binary tree nodes numbered from 0 to n - 1 where node i has two children leftChild[i] and rightChild[i], return true if and only if all the given nodes form exactly one valid binary tree.

If node i has no left child then leftChild[i] will equal -1, similarly for the right child.

Note that the nodes have no values and that we only use the node numbers in this problem.

 

Example 1:


Input: n = 4, leftChild = [1,-1,3,-1], rightChild = [2,-1,-1,-1]
Output: true


Example 2:


Input: n = 4, leftChild = [1,-1,3,-1], rightChild = [2,3,-1,-1]
Output: false


Example 3:


Input: n = 2, leftChild = [1,0], rightChild = [-1,-1]
Output: false
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidateBinaryTreeNodes;

public class UnionFind
{
    private readonly int n;
    private readonly int[] parents;
    public int components;

    public UnionFind(int n)
    {
        this.n = n;
        parents = new int[n];
        components = n;

        for (int i = 0; i < n; i++)
        {
            parents[i] = i;
        }
    }

    public bool Union(int parent, int child)
    {
        int parentParent = Find(parent);
        int childParent = Find(child);

        if (childParent != child || parentParent == childParent)
        {
            return false;
        }

        components--;
        parents[childParent] = parentParent;
        return true;
    }

    private int Find(int node)
    {
        if (parents[node] != node)
        {
            parents[node] = Find(parents[node]);
        }

        return parents[node];
    }
}

public class Solution
{
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        UnionFind uf = new UnionFind(n);
        for (int node = 0; node < n; node++)
        {
            int[] children = { leftChild[node], rightChild[node] };
            foreach (int child in children)
            {
                if (child == -1)
                {
                    continue;
                }

                if (!uf.Union(node, child))
                {
                    return false;
                }
            }
        }

        return uf.components == 1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Validate Binary Tree Nodes");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}