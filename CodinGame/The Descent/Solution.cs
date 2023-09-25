// The Descent

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodinGame.TheDescent;
class Player
{
    //static void Main(string[] args)
    static void Solution()
    {
        // game loop
        while (true)
        {
            int maxHeight = 0;
            int targetIndex = 0;
            for (int i = 0; i < 8; i++)
            {
                int mountainHeight = int.Parse(Console.ReadLine()!);

                if (mountainHeight > maxHeight)
                {
                    maxHeight = mountainHeight;
                    targetIndex = i;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(targetIndex); // The index of the mountain to fire on.

        }
    }
}