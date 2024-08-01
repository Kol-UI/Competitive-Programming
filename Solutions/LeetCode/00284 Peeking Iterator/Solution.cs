using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PeekingIterator
{
    public class Solution
	{
        //Design an iterator that supports the peek operation on an existing iterator in addition to the hasNext and the next operations.

        //Implement the PeekingIterator class:
        //PeekingIterator(Iterator<int> nums) Initializes the object with the given integer iterator iterator.
        //int next() Returns the next element in the array and moves the pointer to the next element.
        //boolean hasNext() Returns true if there are still elements in the array.
        //int peek() Returns the next element in the array without moving the pointer.
        //Note: Each language may have a different implementation of the constructor and Iterator, but they all support the int next() and boolean hasNext() functions.

        //Example 1:

        //Input
        //["PeekingIterator", "next", "peek", "next", "next", "hasNext"]
        //[[[1, 2, 3]], [], [], [], [], []]
        //Output
        //[null, 1, 2, 2, 3, false]
        //Explanation
        //PeekingIterator peekingIterator = new PeekingIterator([1, 2, 3]); // [1,2,3]
        //peekingIterator.next();    // return 1, the pointer moves to the next element [1,2,3].
        //peekingIterator.peek();    // return 2, the pointer does not move [1,2,3].
        //peekingIterator.next();    // return 2, the pointer moves to the next element [1,2,3]
        //peekingIterator.next();    // return 3, the pointer moves to the next element [1,2,3]
        //peekingIterator.hasNext(); // return False

        class PeekingIterator
        {
            IEnumerator<int> _iterator;
            bool hasNext;

            // iterators refers to the first element of the array.
            public PeekingIterator(IEnumerator<int> iterator)
            {
                // initialize any member here.
                _iterator = iterator;
                hasNext = true;
            }

            // Returns the next element in the iteration without advancing the iterator.
            public int Peek()
            {
                return _iterator.Current;
            }

            // Returns the next element in the iteration and advances the iterator.
            public int Next()
            {
                var result = _iterator.Current; ;
                hasNext = _iterator.MoveNext();

                return result;
            }

            // Returns false if the iterator is refering to the end of the array of true otherwise.
            public bool HasNext()
            {
                return hasNext;
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Peeking Iterator");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}