// Check If N and Its Double Exist

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckIfNandItsDoubleExist
{
    /*
        Given an array arr of integers, check if there exist two indices i and j such that :

        i != j
        0 <= i, j < arr.length
        arr[i] == 2 * arr[j]
        

        Example 1:
        Input: arr = [10,2,5,3]
        Output: true
        Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
        
        Example 2:
        Input: arr = [3,1,7,11]
        Output: false
        Explanation: There is no i and j that satisfy the conditions.
    */
    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            var hashSet = new HashSet<int>();
            foreach (var n in arr)
            {
                if (hashSet.Contains(n * 2) || ( (n % 2) == 0 && hashSet.Contains(n / 2)))
                {
                    return true;
                }
                hashSet.Add(n);
            }
            return false;
        }
    }

    public class Solution2
    {
        public bool CheckIfExist(int[] arr)
        {
            if (arr is null || arr.Length < 2)
            {
                return false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == 2 * arr[j] && i != j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCheckIfNandItsDoubleExist()
        {
            Solution solution = new();
            Solution2 solution2 = new();

            // Case 1
            int[] arr2346_1 = {10,2,5,3};
            bool result2346_1 = solution.CheckIfExist(arr2346_1);
            
            // Case 2
            int[] arr2346_2 = {3,1,7,11};
            bool result2346_2 = solution.CheckIfExist(arr2346_2);

            int[] array1 = { 0, 0 };
            int[] array2 = { -2, 0, 10, -19, 4, 6, -8 };
            int[] array3 = { -16, -13, 8 };
            int[] array4 = { 10, 2, 7, 3, 0, 0, -13 };
            int[] array5 = { 7, 15, 3, 4, 30 };
            int[] array6 = { 0, 2, -7, 11, 4, 18 };
            int[] array7 = { 
                357, -53, 277, -706, 980, 826, 93, -352, -669, 989, -193, 920, 209, -574, -389, 221, 
                383, 352, 665, 873, 759, -480, -64, -103, -721, -623, -642, -680, 20, -168, 528, -336, 
                -656, 264, 581, -714, -458, 721, 815, 106, 328, 476, 351, 325, -954, 890, -174, 635, 
                95, -443, 338, 907, -648, 113, -278, 498, 532, -778, 95, -487, -909, -642, 774, 296, 
                417, -132, -951, 857, -867, 321, -960, 180, 108, -984, -54, 103, 703, -118, -252, 235, 
                577, -703, 842, -638, -888, -981, -246, 484, 202, 328, 661, 447, -831, 946, -888, -749, 
                -702
            };
            int[] array8 = { 
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 
                89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 
                181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 
                277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 
                383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 
                487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 
                601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 
                709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 
                827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 
                947, 953, 967, 971, 977, 983, 991, 997
            };


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result2346_1, true),
                ResultTester.CheckResult<bool>(result2346_2, false),
                ResultTester.CheckResult<bool>(solution.CheckIfExist(array1), true),
                ResultTester.CheckResult<bool>(solution.CheckIfExist(array2), false),
                ResultTester.CheckResult<bool>(solution.CheckIfExist(array3), false),
                ResultTester.CheckResult<bool>(solution.CheckIfExist(array4), true),
                ResultTester.CheckResult<bool>(solution.CheckIfExist(array5), true),
                ResultTester.CheckResult<bool>(solution.CheckIfExist(array6), true),
                ResultTester.CheckResult<bool>(solution.CheckIfExist(array7), true),
                ResultTester.CheckResult<bool>(solution.CheckIfExist(array8), false),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(arr2346_1), true),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(arr2346_2), false),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(array1), true),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(array2), false),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(array3), false),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(array4), true),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(array5), true),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(array6), true),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(array7), true),
                ResultTester.CheckResult<bool>(solution2.CheckIfExist(array8), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If N and Its Double Exist");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCheckIfNandItsDoubleExist());
        }
    }
}