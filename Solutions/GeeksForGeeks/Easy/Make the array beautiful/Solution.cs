// Make the array beautiful

/*
Given an array of negative and non-negative integers. You have to make the array beautiful. An array is beautiful if two adjacent integers, arr[i] and arr[i+1] are either negative or non-negative. And you can do the following operation any number of times until the array becomes beautiful.

If two adjacent integers are different i.e. one of them is negative and other is non-negative, remove them.
Return the beautiful array after performing the above operation.

Note:An empty array is also a beautiful array. There can be many adjacent integers which are different as stated above. So remove different adjacent integers as described above from left to right.

Example 1:

Input: 4 2 -2 1
Output: 4 1
Explanation: As at indices 1 and 2 , 2 and -2 have
different sign, they are removed. And the  the final
array is: 4 1.

Example 2:

Input: 2 -2 1 -1
Output: []
Explanation: As at indices 0 and 1, 2 and -2 have
different sign, so they are removed. Now the array
is 1 -1.Now 1 and -1 are also removed as they have
different sign. So the final array is empty. 
Your Task:
You don't need to read input or print anything. Your task is to complete the function makeBeautiful() which takes an array as an input parameter and returns an array.
*/


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.Makethearraybeautiful
{
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make the array beautiful");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG);
        }
    }
}