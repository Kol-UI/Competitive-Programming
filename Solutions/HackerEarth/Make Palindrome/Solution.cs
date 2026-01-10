// Make Palindrome
namespace CompetitiveProgramming.HackerEarth.MakePalindrome;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.IO;
using System.Linq;

public class HelloWorld
{
    static public void Main()
    {
        String line = Console.ReadLine();
        int T = Convert.ToInt32(line);
        
        for(int t = 0; t < T; t++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int[] freq = new int[26];
            
            foreach(char c in s)
            {
                freq[c - 'a']++;
            }
            
            int oddCount = 0;
            for(int i = 0; i < 26; i++)
            {
                if(freq[i] % 2 == 1)
                {
                    oddCount++;
                }
            }
            
            if(oddCount <= 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(oddCount - 1);
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make Palindrome");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
    }
}