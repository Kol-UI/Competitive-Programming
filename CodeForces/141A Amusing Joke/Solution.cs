// Amusing Joke




using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.AmusingJoke
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string guest = Console.ReadLine()!;
            string host = Console.ReadLine()!;
            string pile = Console.ReadLine()!;

            string combined = guest + host;
            char[] combinedArray = combined.ToCharArray();
            char[] pileArray = pile.ToCharArray();

            Array.Sort(combinedArray);
            Array.Sort(pileArray);

            bool isValid = Enumerable.SequenceEqual(combinedArray, pileArray);

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}