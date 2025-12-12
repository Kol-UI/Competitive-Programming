// Count Mentions Per User
namespace CompetitiveProgramming.CodeForces.CountMentionsPerUser;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] CountMentions(int totalUsers, IList<IList<string>> allEvents)
    {
        int[] result = new int[totalUsers];
        var eventQueue = new PriorityQueue<(int time, string action, string data), (int time, int priority)>();

        foreach (var ev in allEvents)
        {
            int timestamp = int.Parse(ev[1]);
            eventQueue.Enqueue((timestamp, ev[0], ev[2]), (timestamp, ev[0] == "OFFLINE" ? 1 : 2));
        }

        var offlineMap = new Dictionary<string, int>();
        var offlineSet = new HashSet<string>();

        while (eventQueue.Count > 0)
        {
            var current = eventQueue.Dequeue();
            int currentTime = current.time;
            string currentType = current.action;
            string currentData = current.data;

            if (currentType == "OFFLINE")
            {
                string[] userIds = currentData.Split(' ');
                foreach (string uid in userIds)
                {
                    offlineMap[uid] = currentTime;
                    offlineSet.Add(uid);
                }
            }
            else
            {
                var expired = new List<string>();
                foreach (var entry in offlineMap)
                {
                    if (entry.Value + 60 <= currentTime)
                    {
                        expired.Add(entry.Key);
                    }
                }
                foreach (string expiredId in expired)
                {
                    offlineSet.Remove(expiredId);
                }

                if (currentData == "ALL")
                {
                    for (int i = 0; i < totalUsers; i++) result[i]++;
                }
                else if (currentData == "HERE")
                {
                    for (int i = 0; i < totalUsers; i++)
                    {
                        if (!offlineSet.Contains(i.ToString())) result[i]++;
                    }
                }
                else
                {
                    string[] mentioned = currentData.Split(' ');
                    foreach (string mention in mentioned)
                    {
                        int userId = int.Parse(mention.Substring(2));
                        result[userId]++;
                    }
                }
            }
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Mentions Per User");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}