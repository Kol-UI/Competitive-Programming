// Implement Router
namespace CompetitiveProgramming.LeetCode.ImplementRouter;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Router {
    private int maxSize;
    private int curSize;
    private SortedDictionary<int, List<(int, int)>> packs = new();
    private Dictionary<int, List<int>> destWithT = new();
    public Router(int memoryLimit) {
        maxSize = memoryLimit;
        curSize = 0;
    }
    
    public void RemoveFirst()
    {
        int tims = packs.Keys.First();
        (int src, int dst) p = packs[tims].First();
        packs[tims].RemoveAt(0);
        if(packs[tims].Count == 0)
            packs.Remove(tims);

        int idx = destWithT[p.dst].BinarySearch(tims);
        destWithT[p.dst].RemoveAt(idx);

        if(destWithT[p.dst].Count == 0)
            destWithT.Remove(p.dst);

        curSize--;
    }

    public bool AddPacket(int source, int destination, int timestamp) {
        if(packs.ContainsKey(timestamp))
        {
            foreach((int, int)cur in packs[timestamp])
            {
                if(cur.Item1 == source && cur.Item2 == destination)
                    return false;
            }
        }
        
        if(curSize == maxSize)
            RemoveFirst();

        if(!packs.ContainsKey(timestamp))
            packs.Add(timestamp, new List<(int, int)>());

        packs[timestamp].Add((source, destination));
        if(!destWithT.ContainsKey(destination))
            destWithT.Add(destination, new List<int>());

        int idx = destWithT[destination].BinarySearch(timestamp);
        if(idx < 0)
            idx = ~idx;

        destWithT[destination].Insert(idx, timestamp);
        curSize++;

        return true;
    }
    
    public int[] ForwardPacket() {
        if(curSize == 0)
            return new int[0];

        int tims = packs.Keys.First();
        (int src, int dst) p = packs[tims][0];
        packs[tims].RemoveAt(0);

        if(packs[tims].Count == 0)
            packs.Remove(tims);

        int idx = destWithT[p.dst].BinarySearch(tims);
        destWithT[p.dst].RemoveAt(idx);
        
        if(destWithT[p.dst].Count == 0)
            destWithT.Remove(p.dst);

        curSize--;
        return [p.src, p.dst, tims];
    }
    
    public int GetCount(int destination, int startTime, int endTime) {
        if (!destWithT.ContainsKey(destination))
            return 0;

        int sId = destWithT[destination].BinarySearch(startTime);
        if (sId >= 0)
        {
            while (sId >= 0 && destWithT[destination][sId] == startTime)
            {
                sId--;
            }

            sId++;
        }
        else
            sId = ~sId;

        int eId = destWithT[destination].BinarySearch(endTime);
        if (eId >= 0)
        {
            while (eId < destWithT[destination].Count && destWithT[destination][eId] == endTime)
            {
                eId++;
            }
        }
        else
            eId = ~eId;

        return eId-sId;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Implement Router");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}