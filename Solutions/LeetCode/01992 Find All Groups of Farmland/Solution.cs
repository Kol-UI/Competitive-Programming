using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindAllGroupsofFarmland
{
    public class Solution 
    {
        public static int[][] FindFarmland(int[][] land) 
        {
            List<int[]> farmlandList = new List<int[]>();
            
            for (int row = 0; row < land.Length; row++) 
            {
                for (int col = 0; col < land[row].Length; col++) 
                {
                    if (IsTopLeftCorner(row, col, land)) 
                    {
                        int bottomRightRow, bottomRightCol;
                        GetBottomRightCorner(row, col, land, out bottomRightRow, out bottomRightCol);
                        farmlandList.Add(new[]{row, col, bottomRightRow, bottomRightCol});
                        col = bottomRightCol + 1;
                    }
                }
            }
            
            return farmlandList.ToArray();
        }
        
        private static bool IsTopLeftCorner(int row, int col, int[][] land) 
        {
            if (land[row][col] == 0) 
            {
                return false;
            }
            
            return (row == 0 || land[row - 1][col] == 0) && (col == 0 || land[row][col - 1] == 0);
        }
        
        private static void GetBottomRightCorner(int row, int col, int[][] land, out int bottomRightRow, out int bottomRightCol) 
        {
            bottomRightRow = row;
            bottomRightCol = col;
            
            while (bottomRightRow + 1 < land.Length && land[bottomRightRow + 1][col] == 1 && bottomRightCol + 1 < land[bottomRightRow].Length && land[bottomRightRow][bottomRightCol + 1] == 1) 
            {
                bottomRightRow++;
                bottomRightCol++;
            }
            
            while (bottomRightRow + 1 < land.Length && land[bottomRightRow + 1][col] == 1) 
            {
                bottomRightRow++;
            }
            
            while (bottomRightCol + 1 < land[bottomRightRow].Length && land[bottomRightRow][bottomRightCol + 1] == 1) 
            {
                bottomRightCol++;
            }
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find All Groups of Farmland");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}