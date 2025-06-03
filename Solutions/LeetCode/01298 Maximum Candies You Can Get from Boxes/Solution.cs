// Maximum Candies You Can Get from Boxes
namespace CompetitiveProgramming.LeetCode.MaximumCandiesYouCanGetfromBoxes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        if (initialBoxes.Length == 0)
            return 0;

        int totalCandies = 0;
        Queue<int> availableBoxToOpen = new Queue<int>();
        int currentBox;
        List<int> obtainedBox = new List<int>();

        foreach (int box in initialBoxes)
        {
            if (status[box] == 1)
                availableBoxToOpen.Enqueue(box);
            else
                obtainedBox.Add(box);
        }

        while (availableBoxToOpen.Count != 0)
        {
            currentBox = availableBoxToOpen.Dequeue();
            totalCandies += candies[currentBox];

            if (keys[currentBox].Length > 0)
            {
                foreach(int key in keys[currentBox])
                {
                    status[key] = 1;
                }
            }

            if (containedBoxes[currentBox].Length > 0)
            {
                foreach (int box in containedBoxes[currentBox])
                {
                    obtainedBox.Add(box);
                }
            }

            for(int i = 0; i<obtainedBox.Count; i++)
            {
                if (status[obtainedBox[i]] == 1)
                {
                    availableBoxToOpen.Enqueue(obtainedBox[i]);
                    obtainedBox.Remove(obtainedBox[i]);
                }
            }
           
            status[currentBox] = -1;
        }

        return totalCandies;
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Maximum Candies You Can Get from Boxes");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
	}
}