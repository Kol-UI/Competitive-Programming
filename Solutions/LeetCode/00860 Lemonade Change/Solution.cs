// Lemonade Change

/*
At a lemonade stand, each lemonade costs $5. Customers are standing in a queue to buy from you and order one at a time (in the order specified by bills). Each customer will only buy one lemonade and pay with either a $5, $10, or $20 bill. You must provide the correct change to each customer so that the net transaction is that the customer pays $5.

Note that you do not have any change in hand at first.

Given an integer array bills where bills[i] is the bill the ith customer pays, return true if you can provide every customer with the correct change, or false otherwise.

 

Example 1:

Input: bills = [5,5,5,10,20]
Output: true
Explanation: 
From the first 3 customers, we collect three $5 bills in order.
From the fourth customer, we collect a $10 bill and give back a $5.
From the fifth customer, we give a $10 bill and a $5 bill.
Since all customers got correct change, we output true.

Example 2:

Input: bills = [5,5,10,10,20]
Output: false
Explanation: 
From the first two customers in order, we collect two $5 bills.
For the next two customers in order, we collect a $10 bill and give back a $5 bill.
For the last customer, we can not give the change of $15 back because we only have two $10 bills.
Since not every customer received the correct change, the answer is false.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LemonadeChange
{
    public class Solution
    {
        public static bool LemonadeChange(int[] bills)
        {
            Span<int> money = stackalloc int[4];
            // change by denomination 0: 5, 1: 10, 3: not used, 4: 20

            for (int i = 0; i < bills.Length; i++)
            {
                int change = bills[i] - 5;

                for (int j = 1; j >= 0 && change > 0; j--)// try to give change using 10s then 5s
                {
                    // determine how much can be changes using current banknote decomination
                    int required = Math.Min(money[j], change - 5 * j);
                    change -= required;
                    money[j] -= required;
                }

                if (change != 0) // if couldn't find proper change
                    return false;

                money[(bills[i] / 5) - 1] += bills[i];  // add new banknote by its denomination
            }

            return true;
        }
    }

    public class Test
    {
        public static bool[] TestLemonadeChange()
        {
            int[] bills1 = {5,5,5,10,20};
            int[] bills2 = {5,5,10,10,20};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.LemonadeChange(bills1), true),
                ResultTester.CheckResult<bool>(Solution.LemonadeChange(bills2), false),
            };
            return results;
        }
    }
}