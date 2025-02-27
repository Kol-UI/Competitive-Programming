// Design a Number Container System

namespace CompetitiveProgramming.LeetCode.DesignaNumberContainerSystem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class NumberContainers
{
    private Dictionary<int, int> indexToNumber; 
    private Dictionary<int, SortedSet<int>> numberToIndices;

    public NumberContainers()
    {
        indexToNumber = new Dictionary<int, int>();
        numberToIndices = new Dictionary<int, SortedSet<int>>();
    }
    
    public void Change(int index, int number)
    {
        if (indexToNumber.ContainsKey(index))
        {
            int oldNumber = indexToNumber[index];
            if (numberToIndices.ContainsKey(oldNumber))
            {
                numberToIndices[oldNumber].Remove(index);
                if (numberToIndices[oldNumber].Count == 0)
                {
                    numberToIndices.Remove(oldNumber);
                }
            }
        }
        indexToNumber[index] = number;
        if (!numberToIndices.ContainsKey(number)) numberToIndices[number] = new SortedSet<int>();
        numberToIndices[number].Add(index);
    }
    
    public int Find(int number)
    {
        if (numberToIndices.ContainsKey(number) && numberToIndices[number].Count > 0) return numberToIndices[number].Min;
        return -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Design a Number Container System");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}