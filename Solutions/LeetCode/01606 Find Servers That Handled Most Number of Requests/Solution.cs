// Find Servers That Handled Most Number of Requests
namespace CompetitiveProgramming.LeetCode.FindServersThatHandledMostNumberofRequests;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public IList<int> BusiestServers(int k, int[] arrival, int[] load) {
        int[] count = new int[k];
        IList<int> result = new List<int>();
        PriorityQueue<int,int> free = new PriorityQueue<int,int>();
        PriorityQueue<(int,int),int> busy = new PriorityQueue<(int,int),int>();

        for(int i=0;i<k;i++) {
            free.Enqueue(i,i);
        }

        for(int i=0;i<arrival.Length;i++) {
            int start = arrival[i];

            while(busy.Count>0 && busy.Peek().Item1 <=start){
                var curr = busy.Dequeue();
                int serverId = curr.Item2;
                int modifiedId = ((serverId-i)%k+k)%k+i;
                free.Enqueue(modifiedId,modifiedId);
            }

            if(free.Count>0) {
                int busyId = free.Dequeue()%k;
                busy.Enqueue((start+load[i],busyId),start+load[i]);
                count[busyId]++;
            }
        }
        int max = Int32.MinValue;
        foreach(int c in count) {
            max = Math.Max(max,c);
        }

        for(int i=0;i<count.Length;i++) {
            if(max==count[i]) {
                result.Add(i);
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<int>>(solution.BusiestServers(3, [1,2,3,4,5], [5,2,3,3,3]), [1]),
            ResultTester.CheckResult<IList<int>>(solution.BusiestServers(3, [1,2,3,4], [1,2,1,2]), [0]),
            ResultTester.CheckResult<IList<int>>(solution.BusiestServers(3, [1,2,3], [10,12,11]), [0,1,2]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Servers That Handled Most Number of Requests");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}