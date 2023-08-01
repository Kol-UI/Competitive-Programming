// Dota2 Senate

/*
In the world of Dota2, there are two parties: the Radiant and the Dire.

The Dota2 senate consists of senators coming from two parties. Now the Senate wants to decide on a change in the Dota2 game. The voting for this change is a round-based procedure. In each round, each senator can exercise one of the two rights:

Ban one senator's right: A senator can make another senator lose all his rights in this and all the following rounds.
Announce the victory: If this senator found the senators who still have rights to vote are all from the same party, he can announce the victory and decide on the change in the game.
Given a string senate representing each senator's party belonging. The character 'R' and 'D' represent the Radiant party and the Dire party. Then if there are n senators, the size of the given string will be n.

The round-based procedure starts from the first senator to the last senator in the given order. This procedure will last until the end of voting. All the senators who have lost their rights will be skipped during the procedure.

Suppose every senator is smart enough and will play the best strategy for his own party. Predict which party will finally announce the victory and change the Dota2 game. The output should be "Radiant" or "Dire".

 

Example 1:

Input: senate = "RD"
Output: "Radiant"
Explanation: 
The first senator comes from Radiant and he can just ban the next senator's right in round 1. 
And the second senator can't exercise any rights anymore since his right has been banned. 
And in round 2, the first senator can just announce the victory since he is the only guy in the senate who can vote.

Example 2:

Input: senate = "RDD"
Output: "Dire"
Explanation: 
The first senator comes from Radiant and he can just ban the next senator's right in round 1. 
And the second senator can't exercise any rights anymore since his right has been banned. 
And the third senator comes from Dire and he can ban the first senator's right in round 1. 
And in round 2, the third senator can just announce the victory since he is the only guy in the senate who can vote.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Dota2Senate
{
    public class Solution
    {
        public static string PredictPartyVictory(string senate)
        {
            const string radian = "Radiant";
            const string dire = "Dire";
            int banR = 0;
            int banD = 0;
            bool noR = false;
            bool noD = false;
            Queue<char> vote = new Queue<char>();

            foreach (char senator in senate)
            {
                vote.Enqueue(senator);
            }
            
            while (vote.Count > 1 )
            {
                int length = vote.Count;
                noR = true;
                noD = true;
                
                for (int i = 0; i < length; i++)
                {
                    var senator = vote.Dequeue();
                    if (senator == 'R')
                    {
                        noR = false;
                        if (banR == 0)
                        {
                            banD++;
                            vote.Enqueue(senator);
                        }
                        else
                        {
                            banR--;
                        }
                    } 
                    if (senator == 'D')
                    {
                        noD = false;
                        if (banD == 0)
                        {
                            banR++;
                            vote.Enqueue(senator);
                        }
                        else
                        {
                            banD--;
                        }
                    } 
                }
                if (noD || noR)
                {
                    break;
                }
            }
            return (vote.Dequeue() == 'R') ? radian : dire;
        }
    }

    public class Test
    {
        public static bool[] TestDota2Senate()
        {
            string senate1 = "RD";
            string senate2 = "RDD";

            string result1 = LeetCode.Dota2Senate.Solution.PredictPartyVictory(senate1);
            string result2 = LeetCode.Dota2Senate.Solution.PredictPartyVictory(senate2);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, "Radiant"),
                ResultTester.CheckResult<string>(result2, "Dire")
            };
            return results;
        }
    }
}