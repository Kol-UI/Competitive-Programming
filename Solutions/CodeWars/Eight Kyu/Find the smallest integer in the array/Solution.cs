using System;
using CompetitiveProgramming.Helpers.Generaters;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.Findthesmallestintegerinthearray
{
    /*
        Given an array of integers your solution should find the smallest integer.
        For example:
        Given [34, 15, 88, 2] your solution will return 2
        Given [34, -345, -1, 100] your solution will return -345
        You can assume, for the purpose of this kata, that the supplied array will not be empty.
    */

    public class Kata
    {
        // For Loop
        public static int FindSmallestInt(int[] args) 
        {
            int temp = 0;
        
            for(int i = 0; i < args.Length; i++)
            {
                if(args[i] <= args[0])
                {
                    args[0] = args[i];    
                    temp = args[i];
                }
            }
            return temp;
        }

        // Linq + Clever
        public static int FindSmallestIntCleverLinq(int[] args) => args.Min();

    }


    public class Test
    {
        public static bool[] TestFindthesmallestintegerinthearray()
        {
            

            // Case 1
            int[] case1_Findthesmallestintegerinthearray = { -1, -2 };
            int case1_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case1_Findthesmallestintegerinthearray);

            // Case 2
            int[] case2_Findthesmallestintegerinthearray = { 1, 2, 2 };
            int case2_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case2_Findthesmallestintegerinthearray);

            // Case 3
            int[] case3_Findthesmallestintegerinthearray = { 1, 2 };
            int case3_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case3_Findthesmallestintegerinthearray);

            // Case 4
            int[] case4_Findthesmallestintegerinthearray = { 5, 3, 4 };
            int case4_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case4_Findthesmallestintegerinthearray);

            // Case 5
            int[] case5_Findthesmallestintegerinthearray = RandomGeneraters.GenerateRandomNumber(10, 100);
            int case5_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case5_Findthesmallestintegerinthearray);

            // Case 6
            int[] Case6_Findthesmallestintegerinthearray = RandomGeneraters.GenerateRandomNumber(10, 100);
            int Case6_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case6_Findthesmallestintegerinthearray);

            // Case 7
            int[] Case7_Findthesmallestintegerinthearray = RandomGeneraters.GenerateRandomNumber(10, 100);
            int Case7_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case7_Findthesmallestintegerinthearray);

            // Case 8
            int[] Case8_Findthesmallestintegerinthearray = RandomGeneraters.GenerateRandomNumber(10, 100);
            int Case8_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case8_Findthesmallestintegerinthearray);

            // Case 9
            int[] Case9_Findthesmallestintegerinthearray = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int Case9_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case9_Findthesmallestintegerinthearray);

            // Case 10
            int[] Case10_Findthesmallestintegerinthearray = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int Case10_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case10_Findthesmallestintegerinthearray);

            // Case 11
            int[] Case11_Findthesmallestintegerinthearray = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int Case11_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case11_Findthesmallestintegerinthearray);

            // Case 12
            int[] Case12_Findthesmallestintegerinthearray = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int Case12_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case12_Findthesmallestintegerinthearray);

            // Case 13
            int[] case13_Findthesmallestintegerinthearray = { 78, 56, 232, 12, 11, 43 };
            int case13_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case13_Findthesmallestintegerinthearray);

            // Case 14
            int[] case14_Findthesmallestintegerinthearray = { 78, 56, -2, 12, 8, -33 };
            int case14_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case14_Findthesmallestintegerinthearray);

            // Case 15
            int[] case15_Findthesmallestintegerinthearray = { 34, 15, 88, 2 };
            int case15_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case15_Findthesmallestintegerinthearray);

            // Case 16
            int[] case16_Findthesmallestintegerinthearray = { 34, -345, -1, 100 };
            int case16_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case16_Findthesmallestintegerinthearray);

            
            // Case 1 Clever Linq
            int case1_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case1_Findthesmallestintegerinthearray);

            // Case 2 Clever Linq
            int case2_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case2_Findthesmallestintegerinthearray);

            // Case 3 Clever Linq
            int case3_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case3_Findthesmallestintegerinthearray);

            // Case 4 Clever Linq
            int case4_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case4_Findthesmallestintegerinthearray);

            // Case 5 Clever Linq
            int case5_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case5_Findthesmallestintegerinthearray);

            // Case 6 Clever Linq
            int Case6_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case6_Findthesmallestintegerinthearray);

            // Case 7 Clever Linq
            int Case7_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case7_Findthesmallestintegerinthearray);

            // Case 8 Clever Linq
            int Case8_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case8_Findthesmallestintegerinthearray);

            // Case 9 Clever Linq
            int Case9_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case9_Findthesmallestintegerinthearray);

            // Case 10 Clever Linq
            int Case10_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case10_Findthesmallestintegerinthearray);

            // Case 11 Clever Linq
            int Case11_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case11_Findthesmallestintegerinthearray);

            // Case 12 Clever Linq
            int Case12_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case12_Findthesmallestintegerinthearray);

            // Case 13 Clever Linq
            int case13_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case13_Findthesmallestintegerinthearray);

            // Case 14 Clever Linq
            int case14_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case14_Findthesmallestintegerinthearray);

            // Case 15 Clever Linq
            int case15_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case15_Findthesmallestintegerinthearray);

            // Case 16 Clever Linq
            int case16_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case16_Findthesmallestintegerinthearray);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(case1_FindthesmallestintegerinthearrayResult, case1_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(case2_FindthesmallestintegerinthearrayResult, case2_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(case3_FindthesmallestintegerinthearrayResult, case3_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(case4_FindthesmallestintegerinthearrayResult, case4_FindthesmallestintegerinthearrayResultCleverLinq),
                
                ResultTester.CheckResult<int>(case5_FindthesmallestintegerinthearrayResult, case5_FindthesmallestintegerinthearrayResult),
                ResultTester.CheckResult<int>(Case6_FindthesmallestintegerinthearrayResult, Case6_FindthesmallestintegerinthearrayResult),
                ResultTester.CheckResult<int>(Case7_FindthesmallestintegerinthearrayResult, Case7_FindthesmallestintegerinthearrayResult),
                ResultTester.CheckResult<int>(Case8_FindthesmallestintegerinthearrayResult, Case8_FindthesmallestintegerinthearrayResult),
                ResultTester.CheckResult<int>(Case9_FindthesmallestintegerinthearrayResult, Case9_FindthesmallestintegerinthearrayResult),
                ResultTester.CheckResult<int>(Case10_FindthesmallestintegerinthearrayResult, Case10_FindthesmallestintegerinthearrayResult),
                ResultTester.CheckResult<int>(Case11_FindthesmallestintegerinthearrayResult, Case11_FindthesmallestintegerinthearrayResult),
                ResultTester.CheckResult<int>(Case12_FindthesmallestintegerinthearrayResult, Case12_FindthesmallestintegerinthearrayResult),

                ResultTester.CheckResult<int>(case13_FindthesmallestintegerinthearrayResult, case13_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(case14_FindthesmallestintegerinthearrayResult, case14_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(case15_FindthesmallestintegerinthearrayResult, case15_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(case16_FindthesmallestintegerinthearrayResult, case16_FindthesmallestintegerinthearrayResultCleverLinq),

                ResultTester.CheckResult<int>(case5_FindthesmallestintegerinthearrayResultCleverLinq, case5_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(Case6_FindthesmallestintegerinthearrayResultCleverLinq, Case6_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(Case7_FindthesmallestintegerinthearrayResultCleverLinq, Case7_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(Case8_FindthesmallestintegerinthearrayResultCleverLinq, Case8_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(Case9_FindthesmallestintegerinthearrayResultCleverLinq, Case9_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(Case10_FindthesmallestintegerinthearrayResultCleverLinq, Case10_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(Case11_FindthesmallestintegerinthearrayResultCleverLinq, Case11_FindthesmallestintegerinthearrayResultCleverLinq),
                ResultTester.CheckResult<int>(Case12_FindthesmallestintegerinthearrayResultCleverLinq, Case12_FindthesmallestintegerinthearrayResultCleverLinq),
            };
            return results;
        }
    }
}