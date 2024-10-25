// Remove Sub-Folders from the Filesystem

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveSubFoldersfromtheFilesystem
{
    public class Solution
    {
        public IList<string> RemoveSubfolders(string[] folder)
        {
            List<string> res = new();
            HashSet<string> set = folder.ToHashSet();
            foreach(var f in folder)
            {
                string cur = "";
                var arr = f.Split('/');
                bool IsSub = false;
                for(int i = 1; i < arr.Length - 1;i++)
                {
                    cur = cur + $"/{arr[i]}";
                    if(set.Contains(cur))
                    {
                        IsSub = true;
                        break;
                    }
                }
                if(!IsSub) res.Add(f);
            }
            return res;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Sub-Folders from the Filesystem");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}