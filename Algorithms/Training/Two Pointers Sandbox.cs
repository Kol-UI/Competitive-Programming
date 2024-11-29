namespace CompetitiveProgramming.Algorithms.Training
{
    public class TwoPointersSandbox
    {
        // Trouver si deux nombres dans un tableau trié ont une somme donnée.
        public static bool TargetSum(int[] array, int target)
        {
            if (array == null || array.Length < 2)
            {
                return false;
            }

            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int sum = array[left] + array[right];
                if (sum == target)
                {
                    return true;
                }
                else if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
            }

            return false;
        }


        // Trouver dans un tableau trié les deux nombres dont la somme est la plus proche d'une cible donnée
        public static int[] ClosestTargetSum(int[] array, int target)
        {
            if (array == null || array.Length < 2)
            {
                return new int[2];
            }

            int left = 0;
            int right = array.Length - 1;
            int closestSum = int.MaxValue;
            int[] closestPair = new int[2];

            while (left < right)
            {
                int sum = array[left] + array[right];
                if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                {
                    closestSum = sum;
                    closestPair[0] = array[left];
                    closestPair[1] = array[right];
                }

                if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                { 
                    right--;
                }
                else
                {
                    return new int[] { array[left], array[right] };
                }
            }

            return closestPair;
        }


        // Vérification de palindrome
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(input[left]))
                {
                    left++;
                }
                while (left < right && !char.IsLetterOrDigit(input[right]))
                {
                    right--;
                }

                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                {
                    return false;
                }

                left++;
                right--;
            }
            
            return true;
        }


        // Déplacer tous les zéros à la fin de l'array tout en gardant l'order des non-zéros
        public static void MoveZeroes(int[] nums)
        {
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;

                    left++;
                }
            }
        }


        // Inverser une array avec la technique Two Pointers
        public static void ReverseArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }


        // Vérifier si un tableau trié contient une paire dont le produit est égal à une cible donnée
        public static bool ContainsProductPair(int[] array, int target)
        {
            if (array == null || array.Length < 2)
            {
                return false;
            }

            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int product = array[left] * array[right];
                if (product == target)
                { 
                    return true;
                }
                else if (product < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return false;
        }


        // Trouver la plus longue sous-séquence sans répétition dans une chaîne de caractères
        public static int LongestSubstringWithoutRepeating(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int right = 0;
            int left = 0;
            Dictionary<char,int> seenCharacters = new();
            int maxLength = 0;

            while(right < input.Length)
            {
                char currentChar = input[right];
                if (seenCharacters.ContainsKey(currentChar) && seenCharacters[currentChar] >= left)
                {
                    left = seenCharacters[currentChar] + 1;
                }
                seenCharacters[currentChar] = right;
                int currentLength = right - left + 1;
                maxLength = Math.Max(maxLength, currentLength);

                right++;
            }
            return maxLength;
        }


        // Fusionner deux tableaux triés
        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int i = 0;
            int j = 0;
            List<int> mergedArray = new();

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    mergedArray.Add(array1[i]);
                    i++;
                }
                else
                {
                    mergedArray.Add(array2[j]);
                    j++;
                }
            }

            while (i < array1.Length)
            {
                mergedArray.Add(array1[i]);
                i++;
            }

            while (j < array2.Length)
            {
                mergedArray.Add(array2[j]);
                j++;
            }

            return mergedArray.ToArray();
        }


        // Étant donné un entier non négatif c, déterminer s'il existe deux entiers non négatifs a et b tels que a^2 + b^2 = c
        public static bool SumOfSquareNumbers(int c)
        {
            if (c < 0)
            {
                return false;
            }

            int left = 0;
            int right = (int)Math.Sqrt(c);

            while (left <= right)
            {
                int sum = left * left + right * right;

                if (sum == c)
                {
                    return true;
                }
                else if (sum < c)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return false;
        }


        // Étant donné une chaîne de caractères s et un caractère c, retourner un tableau d'entiers où chaque élément indique la distance minimale entre cet index et une occurrence de c dans la chaîne
        public static int[] ShortestDistanceToChar(string s, char c)
        {
            int n = s.Length;
            int[] result = new int[n];
            int left = -1;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == c)
                {
                    left = i;
                }
                result[i] = left == -1 ? int.MaxValue : i - left;
            }

            int right = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (s[i] == c)
                {
                    right = i;
                }
                if (right != -1)
                {
                    result[i] = Math.Min(result[i], right - i);
                }
            }

            return result;
        }


        // Trouver des doublons adjacents dans une liste triée
        public static bool ContainsAdjacentDuplicates(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return false;
            }

            int left = 0;
            int right = 1;

            while (right < array.Length)
            {
                if (array[left] == array[right])
                {
                    return true;
                }

                left++;
                right++;
            }

            return false;
        }
    }
}