using System;
namespace CompetitiveProgramming.LeetCode.MaxPointsonaLine
{
	public class Solution
	{
        // Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane, return the maximum number of points that lie on the same straight line.
        // Exemple 1:
        //Input: points = [[1,1],[2,2],[3,3]]
        //Output: 3
        //Exemple 2:
        //Input: points = [[1,1],[3,2],[5,3],[4,1],[2,3],[1,4]]
        //Output: 4

        public static int MaxPoints(int[][] points)
        {
            int max = 2;
            if (points.Length == 1)
                return 1;
            for (int i = 0; i < points.Length; ++i)
            {
                var maxi = 2;
                var dictionary = new Dictionary<float, int>();
                for (int j = i + 1; j < points.Length; ++j)
                {
                    float m = 0;
                    m = (points[j][1] - points[i][1]) / (float)(points[j][0] - points[i][0]);
                    if (m == float.NegativeInfinity)
                        m = float.PositiveInfinity;
                    if (dictionary.ContainsKey(m))
                    {
                        dictionary[m]++;
                        if (max < dictionary[m])
                            max = dictionary[m];
                    }
                    else
                        dictionary.Add(m, 2);
                }
                if (max < maxi)
                    max = maxi;
            }
            return max;
        }
    }
}

