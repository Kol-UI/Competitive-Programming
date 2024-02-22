// Similar Words


using System;
using System.Collections.Generic;
using CompetitiveProgramming.TestDrivenDevelopment;
using System.IO;

namespace CompetitiveProgramming.CSAcademy.SimilarWords
{
    class Solution
    {
        //static void Main(string[] args)
        static void Test()
        {
            int N = int.Parse(Console.ReadLine()!);
            string specialWord = Console.ReadLine()!;

            int similarCount = 0;

            for (int i = 0; i < N; i++) {
                string word = Console.ReadLine()!;
                if (IsSimilar(word, specialWord))
                {
                    similarCount++;
                }
            }

            Console.WriteLine(similarCount);
        }

        static bool IsSimilar(string word, string specialWord)
        {
            if (Math.Abs(word.Length - specialWord.Length) > 1)
            {
                return false;
            }

            if (word == specialWord)
            {
                return true;
            }

            if (word.Length == specialWord.Length)
            {
                int diffCount = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != specialWord[i])
                    {
                        diffCount++;
                        if (diffCount > 1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            int minLength = Math.Min(word.Length, specialWord.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (word[i] != specialWord[i])
                {
                    return word.Substring(i) == specialWord.Substring(i + 1) || specialWord.Substring(i) == word.Substring(i + 1);
                }
            }
            
            return true;
        }
    }
}