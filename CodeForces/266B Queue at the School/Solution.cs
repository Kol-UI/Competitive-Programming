// Queue at the School

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.QueueattheSchool
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string[] input = Console.ReadLine()!.Split();
            int numStudents = int.Parse(input[0]);
            int time = int.Parse(input[1]);
            string initialQueue = Console.ReadLine()!;
    
            char[] queueArray = initialQueue.ToCharArray();
    
            for (int i = 0; i < time; i++)
            {
                for (int j = 0; j < numStudents - 1; j++)
                {
                    if (queueArray[j] == 'B' && queueArray[j + 1] == 'G')
                    {
                        (queueArray[j + 1], queueArray[j]) = (queueArray[j], queueArray[j + 1]);
                        j++;
                    }
                }
            }
    
            Console.WriteLine(new string(queueArray));
        }
    }


    public class Test
    {
        public static string SolutionTest(string input)
        {
            string[] inputParts = input.Split('\n');
            string[] firstLineParts = inputParts[0].Split(' ');
            int numStudents = int.Parse(firstLineParts[0]);
            int time = int.Parse(firstLineParts[1]);
            string initialQueue = inputParts[1];

            char[] queueArray = initialQueue.ToCharArray();

            for (int i = 0; i < time; i++)
            {
                for (int j = 0; j < numStudents - 1; j++)
                {
                    if (queueArray[j] == 'B' && queueArray[j + 1] == 'G')
                    {
                        (queueArray[j + 1], queueArray[j]) = (queueArray[j], queueArray[j + 1]);
                        j++;
                    }
                }
            }

            return new string(queueArray);
        }

        public static bool[] TestCases()
        {
            string[] inputs =
            {
                "5 1\nBGGBG",
                "5 2\nBGGBG",
                "4 1\nGGGB",
                "2 1\nBB",
                "2 1\nBG",
                "6 2\nBBGBBG",
                "8 3\nBBGBGBGB",
                "10 3\nBBGBBBBBBG",
                "22 7\nGBGGBGGGGGBBBGGBGBGBBB",
                "50 4\nGBBGBBBGGGGGBBGGBBBBGGGBBBGBBBGGBGGBGBBBGGBGGBGGBG"
            };

            string[] expectedOutputs =
            {
                "GBGGB",
                "GGBGB",
                "GGGB",
                "BB",
                "GB",
                "GBBGBB",
                "GGBGBBBB",
                "GBBBBBGBBB",
                "GGGGGGGGBGGBGGBBBBBBBB",
                "GGBGBGBGBGBGGGBBGBGBGBGBBBGBGBGBGBGBGBGBGBGBGGBGBB"
            };

            bool[] results = new bool[] { };

            for (int i = 0; i < inputs.Length; i++)
            {
                string input = inputs[i];
                string expectedOutput = expectedOutputs[i];

                string result = SolutionTest(input);
                bool caseResult = ResultTester.CheckResult<string>(result, expectedOutput);
                results.Append(caseResult);
            }

            return results;
        }
    }
}