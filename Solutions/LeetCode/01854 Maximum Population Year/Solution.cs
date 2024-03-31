// Maximum Population Year


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumPopulationYear
{
    public class Solution
    {
        public static int MaximumPopulation(int[][] logs)
        {
            Dictionary<int,int[]> years = new Dictionary<int,int[]>();

            int lowest = int.MaxValue;
            int highest = int.MinValue;

            foreach( int[] log in logs )
            {
                if(!years.ContainsKey(log[0]))
                {
                    years[log[0]] = new int[2];
                }
                years[log[0]][0]++;

                if(!years.ContainsKey(log[1]))
                {
                    years[log[1]] = new int[2];
                }

                years[log[1]][1]++;
                
                if(log[0] < lowest)
                {
                    lowest = log[0];
                }
                if(log[0] > highest)
                {
                    highest = log[0];
                }
                if(log[1] < lowest)
                {
                    lowest = log[1];
                }
                if(log[1] > highest)
                {
                    highest = log[1];
                }
            }

            int answer = 0;
            int highestAmount = 0;
            int amount = 0;

            for(int i = lowest; i <= highest; i++)
            {
                if(years.ContainsKey(i))
                {
                    amount += years[i][0];
                    amount -= years[i][1];
                    
                    if(amount > highestAmount)
                    {
                        highestAmount = amount;
                        answer = i;
                    }
                }
            }

            return answer;
        }
    }
}