// Seven Wonders



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.Kattis.SevenWonders
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            string cards = Console.ReadLine()!;

            int tabletCount = 0, compassCount = 0, gearCount = 0;
            foreach (char card in cards)
            {
                if (card == 'T') tabletCount++;
                else if (card == 'C') compassCount++;
                else if (card == 'G') gearCount++;
            }

            int totalPoints = (tabletCount * tabletCount) + (compassCount * compassCount) + (gearCount * gearCount);
            totalPoints += 7 * Math.Min(Math.Min(tabletCount, compassCount), gearCount);

            Console.WriteLine(totalPoints);
        }
    }
}