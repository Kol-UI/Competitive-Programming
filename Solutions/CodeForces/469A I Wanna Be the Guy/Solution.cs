// I Wanna Be the Guy



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.IWannaBetheGuy
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            int levels = int.Parse(Console.ReadLine()!);
            HashSet<int> levelsSet = new HashSet<int>();

            string[] line = Console.ReadLine()!.Split();
            int littleXLevels = int.Parse(line[0]);
            
            for (int i = 1; i <= littleXLevels; i++)
            {
                int level = int.Parse(line[i]);
                levelsSet.Add(level);
            }

            line = Console.ReadLine()!.Split();
            int littleYLevels = int.Parse(line[0]);
            
            for (int i = 1; i <= littleYLevels; i++)
            {
                int level = int.Parse(line[i]);
                levelsSet.Add(level);
            }

            if (levelsSet.Count == levels)
            {
                Console.WriteLine("I become the guy.");
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!");
            }
        }
    }
}