using System;
namespace CompetitiveProgramming.LeetCode.NumberofWaysofCuttingaPizza
{
    public class Solution
    {
        /*
            Given a rectangular pizza represented as a rows x cols matrix containing the following characters: 'A' (an apple) and '.' (empty cell) and given the integer k. You have to cut the pizza into k pieces using k-1 cuts. 
            For each cut you choose the direction: vertical or horizontal, then you choose a cut position at the cell boundary and cut the pizza into two pieces. If you cut the pizza vertically, give the left part of the pizza to a person. If you cut the pizza horizontally, give the upper part of the pizza to a person. Give the last piece of pizza to the last person.
            Return the number of ways of cutting the pizza such that each piece contains at least one apple. Since the answer can be a huge number, return this modulo 10^9 + 7.

            Example 1:
            Input: pizza = ["A..","AAA","..."], k = 3
            Output: 3 
            Explanation: The figure above shows the three ways to cut the pizza. Note that pieces must contain at least one apple.
            
            Example 2:
            Input: pizza = ["A..","AA.","..."], k = 3
            Output: 1
            Example 3:
            Input: pizza = ["A..","A..","..."], k = 1
            Output: 1
        */

        static int[,] presum = null!;
        public static int Ways(string[] pizza, int K)
        {
            int PizzaLength = pizza.Length;
            int PizzaSlice = pizza[0].Length;
            long LongModulo = (long)(1e9 + 7);
            long[,,] dp = new long[ PizzaLength , PizzaSlice, K];
            presum = new int[PizzaLength + 1, PizzaSlice + 1];

            for(int i = 1; i <= PizzaLength; i++)
            {
                int temp = 0;
                for (int j = 1; j <= PizzaSlice; j++)
                {
                    if(pizza[i-1][j-1] == 'A')
                    {
                        temp++;
                    }
                    presum[i,j] = temp + presum[i-1,j];
                }
            }

            for(int i = PizzaLength - 1; i >= 0; i--)
            {
                for(int j = PizzaSlice - 1; j >= 0; j--)
                {
                    for(int k = 0; k < K; k++)
                    {
                        if(k == 0)
                        {
                            int cnt = GetCnt(pizza, i, j, PizzaLength, PizzaSlice);
                            if(cnt == 0)
                            {
                                dp[i,j,k] = 0;
                            }
                            else
                            {
                                dp[i,j,k] = 1;
                            }
                        }
                        else
                        {
                            long result = 0;
                            // horizontal
                            for(int x = i; x < PizzaLength - 1; x++)
                            {
                                if(GetCnt(pizza, i, j, x + 1, PizzaSlice) > 0)
                                {
                                    result = result + dp[ x + 1 , j , k - 1];
                                    result = result % LongModulo;
                                }
                            }
                            // vertical
                            for(int y = j; y < PizzaSlice - 1; y++)
                            {
                                if(GetCnt(pizza, i, j, PizzaLength, y + 1) > 0)
                                {
                                    result = result + dp[ i, y + 1, k - 1 ];
                                    result = result % LongModulo;
                                }
                            }
                            dp[i,j,k] = result % LongModulo;
                        }
                    }
                }
            }
            return (int)(dp[0,0,K-1] % LongModulo);
        }

        private static int GetCnt(string[] pizza, int x, int y, int PizzaLength, int PizzaSlice)
        {
            return presum[PizzaLength,PizzaSlice] + presum[x,y] - presum[PizzaLength,y] - presum[x,PizzaSlice];
        }
    }
}