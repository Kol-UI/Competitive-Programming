// Soft Drinking



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.SoftDrinking
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    
            int friends = inputs[0];
            int bottles = inputs[1];
            int mlPerDrink = inputs[2];
            int limes = inputs[3];
            int slicesPerLime = inputs[4];
            int gramsOfSalt = inputs[5];
            int mlPerToast = inputs[6];
            int gramsPerToast = inputs[7];
    
            int maxDrinks = (bottles * mlPerDrink) / mlPerToast;
            int maxLimes = (limes * slicesPerLime);
            int maxSalt = gramsOfSalt / gramsPerToast;
    
            int maxPossibleToasts = Math.Min(maxDrinks, Math.Min(maxLimes, maxSalt));
            int toastsPerFriend = maxPossibleToasts / friends;
    
            Console.WriteLine(toastsPerFriend);
        }
    }
}