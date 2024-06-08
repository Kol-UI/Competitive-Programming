// Word Ordering


using System;
using System.Collections.Generic;
using CompetitiveProgramming.TestDrivenDevelopment;
using System.IO;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;

namespace CompetitiveProgramming.CSAcademy.WordOrdering
{
    class Solution
    {
        static Dictionary<char, int> map = new Dictionary<char, int>();

        //public static void Main(string[] args)
        public static void Test()
        {
            string s = Console.ReadLine()!;
            int N = int.Parse(Console.ReadLine()!);
            string[] w = new string[N];
            
            for(int i = 0; i < N; i++)
            {
                w[i] = Console.ReadLine()!;
            }
            
            for(int i = 0; i < 26; i++)
            {
                char c = s[i];
                char C = (char)(c - 'a' + 'A');
                map[c] = i;
                map[C] = 26 + i;
            }

            Array.Sort(w, new MyComparator());

            foreach(string t in w)
            {
                Console.WriteLine(t);
            }
        }

        class MyComparator : IComparer<string>
        {
            public int Compare(string? s0, string? s1)
            {
                int l = Math.Min(s0!.Length, s1!.Length);
                
                if(s0.Substring(0, l) == s1.Substring(0, l))
                {
                    if(s0.Length == s1.Length)
                    {
                        return 0;
                    }
                    else if(s0.Length > s1.Length)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    for(int i = 0; i < l; i++)
                    {
                        char c0 = s0[i];
                        char c1 = s1[i];
                        
                        if(c0 == c1) continue;
                        
                        if(map[c0] > map[c1])
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    
                    if(s0.Length == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Ordering");
            ResultTester.SpecialTestCase(ProblemOrigin.CSAcademy, ProblemCategory.EasyCSA);
        }
    }
}