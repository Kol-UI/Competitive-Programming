// Count All Valid Pickup and Delivery Options

/*
Given n orders,each order consists of a pickup and a delivery service.

Count all valid pickup/delivery possible sequences such that delivery(i) is always after of pickup(i). 

Since the answer may be too large, return it modulo 10^9 + 7.

 

Example 1:

Input: n = 1
Output: 1
Explanation: Unique order (P1, D1), Delivery 1 always is after of Pickup 1.

Example 2:

Input: n = 2
Output: 6
Explanation: All possible orders: 
(P1,P2,D1,D2), (P1,P2,D2,D1), (P1,D1,P2,D2), (P2,P1,D1,D2), (P2,P1,D2,D1) and (P2,D2,P1,D1).
This is an invalid order (P1,D2,P2,D1) because Pickup 2 is after of Delivery 2.

Example 3:

Input: n = 3
Output: 90
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CountAllValidPickupandDeliveryOptions
{
    public class Solution
    {
        public static int CountOrders(int n)
        {
            long MOD = 1000000007;
            long result = 1;
            
            for (int i = 1; i <= n; i++)
            {
                long spaces = 2 * i - 1;
                result = (result * spaces * (spaces + 1) / 2) % MOD;
            }
            
            return (int)result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountOrders(1), 1),
                ResultTester.CheckResult<int>(Solution.CountOrders(2), 6),
                ResultTester.CheckResult<int>(Solution.CountOrders(3), 90),
                ResultTester.CheckResult<int>(Solution.CountOrders(4), 2520),
                ResultTester.CheckResult<int>(Solution.CountOrders(5), 113400),
                ResultTester.CheckResult<int>(Solution.CountOrders(6), 7484400),
                ResultTester.CheckResult<int>(Solution.CountOrders(7), 681080400),
                ResultTester.CheckResult<int>(Solution.CountOrders(8), 729647433),
                ResultTester.CheckResult<int>(Solution.CountOrders(9), 636056472),
                ResultTester.CheckResult<int>(Solution.CountOrders(10), 850728840),
            };
            return results;
        }
    }
}