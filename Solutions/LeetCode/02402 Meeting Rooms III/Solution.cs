// Meeting Rooms III

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MeetingRoomsIII
{
    public class Solution
    {
        public static int MostBooked(int n, int[][] meetings)
        {
            int[] rooms = new int[n];
            
            PriorityQueue<List<long>, long> occupiedRooms = new PriorityQueue<List<long>, long>(Comparer<long>.Create((x, y) => x.CompareTo(y)));
            
            PriorityQueue<long, long> freeRooms = new PriorityQueue<long, long>();
            for (int i = 0; i < n; i++)
            {
                freeRooms.Enqueue(i, i);
            }
            
            Array.Sort(meetings, (x, y) => x[0].CompareTo(y[0]));
            long currentTime = 0;

            for (int i = 0; i < meetings.Length; i++)
            {
                int[] meeting = meetings[i];
                currentTime = Math.Max(meeting[0], currentTime);
                
                if (freeRooms.Count == 0)
                {
                    long earliestFreeTime = occupiedRooms.Peek()[1];
                    currentTime = Math.Max(earliestFreeTime, currentTime);
                }            
                
                while (occupiedRooms.Count > 0 && occupiedRooms.Peek()[1] <= currentTime)
                {
                    long freedRoom = occupiedRooms.Dequeue()[2];
                    freeRooms.Enqueue(freedRoom, freedRoom);
                }
                
                
                long nextRoom = freeRooms.Dequeue();
                rooms[nextRoom] += 1;
                occupiedRooms.Enqueue(new List<long>{ currentTime, currentTime + (meeting[1] - meeting[0]), nextRoom }, currentTime + (meeting[1] - meeting[0]));
            }
            
            int max = 0, result = 0;
            for (int i = n-1; i >= 0; i--)
            {
                if (rooms[i] >= max)
                {
                    max = rooms[i];
                    result = i;
                }
            }
            return result;   
        }

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 0, 10 },
                new int[] { 1, 5 },
                new int[] { 2, 7 },
                new int[] { 3, 4 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 1, 20 },
                new int[] { 2, 10 },
                new int[] { 3, 5 },
                new int[] { 4, 9 },
                new int[] { 6, 8 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MostBooked(2, matrix1), 0),
                ResultTester.CheckResult<int>(Solution.MostBooked(3, matrix2), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("2402");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}