// Unique Number of Occurrences

/*
Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.

Example 1:

Input: arr = [1,2,2,1,1,3]
Output: true
Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.

Example 2:

Input: arr = [1,2]
Output: false

Example 3:

Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
Output: true
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.UniqueNumberofOccurrences
{
    public class Solution
    {
        public static bool UniqueOccurrences(int[] arr) => arr.GroupBy(e => e).Select(e => e.Count()).Distinct().Count() == arr.Distinct().Count();
    }

    public class Test
    {
        public static bool[] TestUniqueNumberofOccurrences()
        {
            int[] Case1 = { -1, -2, -3, -4, 3, 2, 1};
            int[] Case2 = { 1, 5, 0, 2,-3 };
            int[] Case3 = { -1, 1, -1, 1, -1 };
            int[] Case4 = { 1000, 2000, 3000 };
            int[] Case5 = { 4000, 3000, 1000, 2000 };
            int[] Case6 = { 3, 5, 1 };
            int[] Case7 = { 1, 2, 4 };
            int[] Case8 = { 1, 2, 2, 3 };
            int[] Case9 = { 6, 5, 4, 4 };
            int[] Case10 = { 1, 3, 2 };
            int[] Case11 = { 30, 11, 23, 4, 20 };
            int[] Case12 = { 3, 6, 7, 11 };
            int[] Case13 = { -30, -11, 23, 4, 20 };
            int[] Case14 = { -10, -3, 0, 5, 9 };
            int[] Case15 = { 1, 3 };
            int[] Case16 = { 1, 2, 2 };
            int[] Case17 = { 1, 2 };
            int[] Case18 = { 5, 3, 4 };
            int[] Case19 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int[] Case20 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int[] Case21 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int[] Case22 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int[] Case23 = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int[] Case24 = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int[] Case25 = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int[] Case26 = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int[] Case27 = { -1, -2 };
            int[] Case28 = { 78, 56, 232, 12, 11, 43 };
            int[] Case29 = { 78, 56, -2, 12, 8, -33 };
            int[] Case30 = { 34, 15, 88, 2 };
            int[] Case31 = { 34, -345, -1, 100 };
            int[] Case32 = { 12, 35, 1, 10, 34, 1 };
            int[] Case33 = { 10, 5, 10 };
            int[] Case34 = { 1, 0, 0, 0, 1 };
            int[] Case35 = { 1, 0, 0, 0, 0, 0, 1 };
            int[] Case36 = { 1, 3, 0, 0, 2, 0, 0, 4 };
            int[] Case37 = { 0, 0, 0, 2, 0, 0 };
            int[] Case38 = { 1, 2, 3, 4 };
            int[] Case39 = { -1, 1, 0, -3, 3 };
            int[] Case40 = { 1, 2, 3, 4, 5 };
            int[] Case41 = { 5, 4, 3, 2, 1 };
            int[] Case42 = { 2, 1, 5, 0, 4, 6 };
            int[] Case43 = { 3, 2, 1, 5, 6, 4 };
            int[] Case44 = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int[] Case45 = { 1, 3, 3, 2 };
            int[] Case46 = { 2, 1, 3, 4 };
            int[] Case47 = { 4, 2, 3, 1, 1 };
            int[] Case48 = { 7, 5, 10, 9, 6 };

            bool result1 = Solution.UniqueOccurrences(Case1);
            bool result2 = Solution.UniqueOccurrences(Case2);
            bool result3 = Solution.UniqueOccurrences(Case3);
            bool result4 = Solution.UniqueOccurrences(Case4);
            bool result5 = Solution.UniqueOccurrences(Case5);
            bool result6 = Solution.UniqueOccurrences(Case6);
            bool result7 = Solution.UniqueOccurrences(Case7);
            bool result8 = Solution.UniqueOccurrences(Case8);
            bool result9 = Solution.UniqueOccurrences(Case9);
            bool result10 = Solution.UniqueOccurrences(Case10);
            bool result11 = Solution.UniqueOccurrences(Case11);
            bool result12 = Solution.UniqueOccurrences(Case12);
            bool result13 = Solution.UniqueOccurrences(Case13);
            bool result14 = Solution.UniqueOccurrences(Case14);
            bool result15 = Solution.UniqueOccurrences(Case15);
            bool result16 = Solution.UniqueOccurrences(Case16);
            bool result17 = Solution.UniqueOccurrences(Case17);
            bool result18 = Solution.UniqueOccurrences(Case18);
            bool result19 = Solution.UniqueOccurrences(Case19);
            bool result20 = Solution.UniqueOccurrences(Case20);
            bool result21 = Solution.UniqueOccurrences(Case21);
            bool result22 = Solution.UniqueOccurrences(Case22);
            bool result23 = Solution.UniqueOccurrences(Case23);
            bool result24 = Solution.UniqueOccurrences(Case24);
            bool result25 = Solution.UniqueOccurrences(Case25);
            bool result26 = Solution.UniqueOccurrences(Case26);
            bool result27 = Solution.UniqueOccurrences(Case27);
            bool result28 = Solution.UniqueOccurrences(Case28);
            bool result29 = Solution.UniqueOccurrences(Case29);
            bool result30 = Solution.UniqueOccurrences(Case30);
            bool result31 = Solution.UniqueOccurrences(Case31);
            bool result32 = Solution.UniqueOccurrences(Case32);
            bool result33 = Solution.UniqueOccurrences(Case33);
            bool result34 = Solution.UniqueOccurrences(Case34);
            bool result35 = Solution.UniqueOccurrences(Case35);
            bool result36 = Solution.UniqueOccurrences(Case36);
            bool result37 = Solution.UniqueOccurrences(Case37);
            bool result38 = Solution.UniqueOccurrences(Case38);
            bool result39 = Solution.UniqueOccurrences(Case39);
            bool result40 = Solution.UniqueOccurrences(Case40);
            bool result41 = Solution.UniqueOccurrences(Case41);
            bool result42 = Solution.UniqueOccurrences(Case42);
            bool result43 = Solution.UniqueOccurrences(Case43);
            bool result44 = Solution.UniqueOccurrences(Case44);
            bool result45 = Solution.UniqueOccurrences(Case45);
            bool result46 = Solution.UniqueOccurrences(Case46);
            bool result47 = Solution.UniqueOccurrences(Case47);
            bool result48 = Solution.UniqueOccurrences(Case48);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, result1),
                ResultTester.CheckResult<bool>(result2, result2),
                ResultTester.CheckResult<bool>(result3, result3),
                ResultTester.CheckResult<bool>(result4, result4),
                ResultTester.CheckResult<bool>(result5, result5),
                ResultTester.CheckResult<bool>(result6, result6),
                ResultTester.CheckResult<bool>(result7, result7),
                ResultTester.CheckResult<bool>(result8, result8),
                ResultTester.CheckResult<bool>(result9, result9),
                ResultTester.CheckResult<bool>(result10, result10),
                ResultTester.CheckResult<bool>(result11, result11),
                ResultTester.CheckResult<bool>(result12, result12),
                ResultTester.CheckResult<bool>(result13, result13),
                ResultTester.CheckResult<bool>(result14, result14),
                ResultTester.CheckResult<bool>(result15, result15),
                ResultTester.CheckResult<bool>(result16, result16),
                ResultTester.CheckResult<bool>(result17, result17),
                ResultTester.CheckResult<bool>(result18, result18),
                ResultTester.CheckResult<bool>(result19, result19),
                ResultTester.CheckResult<bool>(result20, result20),
                ResultTester.CheckResult<bool>(result21, result21),
                ResultTester.CheckResult<bool>(result22, result22),
                ResultTester.CheckResult<bool>(result23, result23),
                ResultTester.CheckResult<bool>(result24, result24),
                ResultTester.CheckResult<bool>(result25, result25),
                ResultTester.CheckResult<bool>(result26, result26),
                ResultTester.CheckResult<bool>(result27, result27),
                ResultTester.CheckResult<bool>(result28, result28),
                ResultTester.CheckResult<bool>(result29, result29),
                ResultTester.CheckResult<bool>(result30, result30),
                ResultTester.CheckResult<bool>(result31, result31),
                ResultTester.CheckResult<bool>(result32, result32),
                ResultTester.CheckResult<bool>(result33, result33),
                ResultTester.CheckResult<bool>(result34, result34),
                ResultTester.CheckResult<bool>(result35, result35),
                ResultTester.CheckResult<bool>(result36, result36),
                ResultTester.CheckResult<bool>(result37, result37),
                ResultTester.CheckResult<bool>(result38, result38),
                ResultTester.CheckResult<bool>(result39, result39),
                ResultTester.CheckResult<bool>(result40, result40),
                ResultTester.CheckResult<bool>(result41, result41),
                ResultTester.CheckResult<bool>(result42, result42),
                ResultTester.CheckResult<bool>(result43, result43),
                ResultTester.CheckResult<bool>(result44, result44),
                ResultTester.CheckResult<bool>(result45, result45),
                ResultTester.CheckResult<bool>(result46, result46),
                ResultTester.CheckResult<bool>(result47, result47),
                ResultTester.CheckResult<bool>(result48, result48),
                
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1207");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestUniqueNumberofOccurrences());
        }
    }
}