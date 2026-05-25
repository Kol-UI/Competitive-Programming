// Check if All Characters Have Equal Number of Occurrences
namespace CompetitiveProgramming.LeetCode.CheckifAllCharactersHaveEqualNumberofOccurrences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool AreOccurrencesEqual(string s)
    {
        
        int[] freq = new int[26]; 

        foreach(char c in s)
        {
            int index= c-'a';
            freq[index]++;
        }
        
        int check=0;
        bool ignoreFirst=true;

        foreach(int value in freq)
        {
            if(ignoreFirst && value!=0 )
            {
                check=value;
                ignoreFirst= false;
            }
            else{
                if(value==0){continue;}
                if(check!= value ){ return false;}
            } 
        }

        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.AreOccurrencesEqual("abacbc"), true),
            ResultTester.CheckResult<bool>(solution.AreOccurrencesEqual("aaabb"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if All Characters Have Equal Number of Occurrences");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}