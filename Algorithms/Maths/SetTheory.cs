namespace CompetitiveProgramming.Algorithms
{
    public class SetTheory
    {
        // Set Theory, Intersection = values in both arrays
        public static int[] FindIntersection(int[] A, int[] B)
        {
            HashSet<int> setA = new HashSet<int>(A);
            List<int> intersection = new List<int>();

            foreach (int item in B)
            {
                if (setA.Contains(item))
                {
                    intersection.Add(item);
                }
            }

            return intersection.ToArray();
        }

        // Set Theory, Union = regroup arrays, no duplicates
        public static int[] FindUnion(int[] A, int[] B)
        {
            HashSet<int> unionSet = new HashSet<int>(A);

            foreach (int item in B)
            {
                unionSet.Add(item);
            }

            return unionSet.ToArray();
        }

        // Set Theory, find what is not in A
        public static int[] FindDifference(int[] A, int[] B)
        {
            HashSet<int> setA = new HashSet<int>(A);
            List<int> difference = new List<int>();

            foreach (int item in B)
            {
                if (!setA.Contains(item))
                {
                    difference.Add(item);
                }
            }

            return difference.ToArray();
        }
    }
}