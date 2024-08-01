// Flatten Nested List Iterator

/*
You are given a nested list of integers nestedList. Each element is either an integer or a list whose elements may also be integers or other lists. Implement an iterator to flatten it.

Implement the NestedIterator class:

NestedIterator(List<NestedInteger> nestedList) Initializes the iterator with the nested list nestedList.
int next() Returns the next integer in the nested list.
boolean hasNext() Returns true if there are still some integers in the nested list and false otherwise.
Your code will be tested with the following pseudocode:

initialize iterator with nestedList
res = []
while iterator.hasNext()
    append iterator.next() to the end of res
return res
If res matches the expected flattened list, then your code will be judged as correct.

 

Example 1:

Input: nestedList = [[1,1],2,[1,1]]
Output: [1,1,2,1,1]
Explanation: By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1,1,2,1,1].

Example 2:

Input: nestedList = [1,[4,[6]]]
Output: [1,4,6]
Explanation: By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1,4,6].
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FlattenNestedListIterator
{
    /**
    * // This is the interface that allows for creating nested lists.
    * // You should not implement it, or speculate about its implementation
    * interface NestedInteger {
    *
    *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
    *     bool IsInteger();
    *
    *     // @return the single integer that this NestedInteger holds, if it holds a single integer
    *     // Return null if this NestedInteger holds a nested list
    *     int GetInteger();
    *
    *     // @return the nested list that this NestedInteger holds, if it holds a nested list
    *     // Return null if this NestedInteger holds a single integer
    *     IList<NestedInteger> GetList();
    * }
    */

    /*
    public class NestedIterator
    {
        private readonly IEnumerator<int> _enumerator;
        private bool _hasNext;

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            _enumerator = GetIntegers(nestedList).GetEnumerator();
            _hasNext = _enumerator.MoveNext();
        }

        public bool HasNext() => _hasNext;

        public int Next()
        {
            int result = _enumerator.Current;
            _hasNext = _enumerator.MoveNext();
            return result;
        }

        private IEnumerable<int> GetIntegers(IList<NestedInteger> nestedIntegers)
        {
            return nestedIntegers
                .Select(
                    nestedInteger => nestedInteger.IsInteger()
                        ? new[] { nestedInteger.GetInteger() }
                        : GetIntegers(nestedInteger.GetList())
                )
                .SelectMany(ints => ints);
        }
    }
    */

    /**
    * Your NestedIterator will be called like this:
    * NestedIterator i = new NestedIterator(nestedList);
    * while (i.HasNext()) v[f()] = i.Next();
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flatten Nested List Iterator");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}