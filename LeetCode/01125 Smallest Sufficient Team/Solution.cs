// Smallest Sufficient Team

/*
In a project, you have a list of required skills req_skills, and a list of people. The ith person people[i] contains a list of skills that the person has.

Consider a sufficient team: a set of people such that for every required skill in req_skills, there is at least one person in the team who has that skill. We can represent these teams by the index of each person.

For example, team = [0, 1, 3] represents the people with skills people[0], people[1], and people[3].
Return any sufficient team of the smallest possible size, represented by the index of each person. You may return the answer in any order.

It is guaranteed an answer exists.

 

Example 1:

Input: req_skills = ["java","nodejs","reactjs"], people = [["java"],["nodejs"],["nodejs","reactjs"]]
Output: [0,2]

Example 2:

Input: req_skills = ["algorithms","math","java","reactjs","csharp","aws"], people = [["algorithms","math","java"],["algorithms","math","reactjs"],["java","csharp","aws"],["reactjs","csharp"],["csharp","math"],["aws","java"]]
Output: [1,2]
*/

namespace CompetitiveProgramming.LeetCode.SmallestSufficientTeam
{
    public class Solution
    {
        public static int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people)
        {
            Dictionary<string, int> bitMaskKey = BuildBitMask(req_skills);
            Dictionary<int, List<int>> skillSets = new Dictionary<int, List<int>>();
            skillSets[0] = new List<int>();

            for (int i = 0, bitmask, newBitmask; i < people.Count; ++i)
            {
                bitmask = ConvertPersonToBitMask(bitMaskKey, people[i]);
                foreach (int key in skillSets.Keys.ToArray())
                {
                    if ((key & bitmask) != bitmask)
                    {
                        newBitmask = (key | bitmask);
                        if (!skillSets.ContainsKey(newBitmask) || (skillSets[newBitmask].Count > (skillSets[key].Count + 1)))
                        {
                            skillSets[newBitmask] = new List<int> (skillSets[key]);
                            skillSets[newBitmask].Add(i);
                        }
                    }
                }
            }
            return skillSets[ConvertPersonToBitMask(bitMaskKey, req_skills)].ToArray();
        }

        private static Dictionary<string, int> BuildBitMask(string[] req_skills)
        {
            Dictionary<string, int> bitMaskKey = new Dictionary<string, int>();
            int val = 1;

            foreach (string skill in req_skills)
            {
                bitMaskKey.Add(skill, val);
                val *= 2;
            }
            return bitMaskKey;
        }

        private static int ConvertPersonToBitMask(Dictionary<string, int> bitMaskKey, IEnumerable<string> person)
        {
            int bitmask = 0;
            foreach (string skill in person)
            {
                bitmask += bitMaskKey[skill];
            }
            return bitmask;
        }
    }
}