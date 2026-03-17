// Design Auction System
namespace CompetitiveProgramming.LeetCode.DesignAuctionSystem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
public class AuctionSystem
{
    Dictionary<(int userId, int itemId), int> users = [];
    Dictionary<int, SortedDictionary<int, SortedSet<int>>> bids = [];

    public AuctionSystem()
    {
        this.users = [];
        this.bids = [];
    }

    public void AddBid(int userId, int itemId, int bidAmount)
    {
        this.bids.TryAdd(itemId, new(Comparer<int>.Create((x, y) => y - x)));
        this.bids[itemId].TryAdd(bidAmount, []);

        if (this.users.TryGetValue((userId, itemId), out int currentBid))
        {
            this.bids[itemId][currentBid].Remove(userId);
            if (this.bids[itemId][currentBid].Count == 0)
                this.bids[itemId].Remove(currentBid);
        }

        this.users[(userId, itemId)] = bidAmount;
        this.bids[itemId][bidAmount].Add(userId);
    }

    public void UpdateBid(int userId, int itemId, int newAmount)
    {
        int currentBid = this.users[(userId, itemId)];
        this.bids[itemId][currentBid].Remove(userId);
        if (this.bids[itemId][currentBid].Count == 0)
            this.bids[itemId].Remove(currentBid);

        this.users[(userId, itemId)] = newAmount;
        this.bids[itemId].TryAdd(newAmount, []);
        this.bids[itemId][newAmount].Add(userId);
    }

    public void RemoveBid(int userId, int itemId)
    {
        int currentBid = this.users[(userId, itemId)];
        this.users.Remove((userId, itemId));
        this.bids[itemId][currentBid].Remove(userId);
        if (this.bids[itemId][currentBid].Count == 0)
            this.bids[itemId].Remove(currentBid);

        if (this.bids[itemId].Count == 0)
            this.bids.Remove(itemId);
    }

    public int GetHighestBidder(int itemId)
    {
        if (!this.bids.TryGetValue(itemId, out var bidAmounts))
            return -1;

        return bidAmounts.First().Value.Max;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Design Auction System");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}