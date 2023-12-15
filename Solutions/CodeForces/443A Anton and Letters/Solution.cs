// Anton and Letters


using System;
using System.Collections.Generic;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.AntonandLetters
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            string input = Console.ReadLine()!.Trim('{', '}');
            
            string[] letters = input.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                                    .Where(c => char.IsLetter(c[0])).ToArray();

            HashSet<char> uniqueLetters = new(letters.SelectMany(s => s));

            Console.WriteLine(uniqueLetters.Count);
        }
    }
}