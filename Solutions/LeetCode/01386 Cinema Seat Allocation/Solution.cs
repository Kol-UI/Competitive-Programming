// Cinema Seat Allocation
namespace CompetitiveProgramming.LeetCode.CinemaSeatAllocation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
    {
        int maxNumberOfFamilies = 0;

        Dictionary<int, bool[]> cinemaRowsWithAllocation = new Dictionary<int, bool[]>();

        foreach(int[] reservedSeat in reservedSeats)
        {
            int row = reservedSeat[0];
            int seat = reservedSeat[1];

            bool[] rowAllocationDetails;
            if(!cinemaRowsWithAllocation.ContainsKey(row))
            {
                rowAllocationDetails = new bool[]{true, true, true};
                cinemaRowsWithAllocation.Add(row, rowAllocationDetails);
            }
            rowAllocationDetails = cinemaRowsWithAllocation[row];

            if(seat == 1 || seat == 10)
                continue;

            if(seat == 2 || seat == 3)
                rowAllocationDetails[0] = false;

            if(seat == 8 || seat == 9)
                rowAllocationDetails[2] = false;

            if(seat == 4 || seat == 5)
            {
                rowAllocationDetails[0] = false;
                rowAllocationDetails[1] = false;
            }

            if(seat == 6 || seat == 7)
            {
                rowAllocationDetails[1] = false;
                rowAllocationDetails[2] = false;
            }

            cinemaRowsWithAllocation[row] =  rowAllocationDetails;
        }

        foreach(KeyValuePair<int, bool[]> row in cinemaRowsWithAllocation)
        {
            bool[] rowDetails = row.Value;
            if(rowDetails[0] && rowDetails[2] == false)
                maxNumberOfFamilies++;
            else if(rowDetails[2] && rowDetails[0] == false)
                maxNumberOfFamilies++;
            else if(rowDetails[0] && rowDetails[2])
                maxNumberOfFamilies = maxNumberOfFamilies + 2;
            else if(rowDetails[1])
                maxNumberOfFamilies++;
        }

        int remainingRows = (n - cinemaRowsWithAllocation.Count);
        maxNumberOfFamilies = maxNumberOfFamilies + remainingRows*2;

        return maxNumberOfFamilies;

    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxNumberOfFamilies(3, [[1,2],[1,3],[1,8],[2,6],[3,1],[3,10]]), 4),
            ResultTester.CheckResult<int>(solution.MaxNumberOfFamilies(2, [[2,1],[1,8],[2,6]]), 2),
            ResultTester.CheckResult<int>(solution.MaxNumberOfFamilies(4, [[4,3],[1,4],[4,6],[1,7]]), 4)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cinema Seat Allocation");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}