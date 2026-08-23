
You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.

Return the length of the longest substring containing the same letter you can get after performing the above operations. 


Example 1:

Input: s = "ABAB", k = 2

Output: 4

Explanation: Replace the two 'A's with two 'B's or vice versa.


Example 2:

Input: s = "AABABBA", k = 1

Output: 4

Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".

The substring "BBBB" has the longest repeating letters, which is 4.

There may exists other ways to achieve this answer too. 


```cs
public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0, maxCount = 0, maxLength = 0;
        int[] count = new int[26];

        for (int right = 0; right < s.Length; right++)
        {
            // Increment character count for the character at 'right'
            maxCount = Math.Max(maxCount, ++count[s[right] - 'A']);

            // Window size: right - left + 1
            // Calculate if replacements exceed k
            if (right - left + 1 - maxCount > k)
            {
                count[s[left] - 'A']--;
                left++;
            }

            // Update maximum length of the window
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}

/* EXAMPLE TRACE: s = "AABAB", k = 1
---------------------------------------------------------------------------
Step 1: right = 0 ('A')
   - Window: [A] | Size: 1
   - count: {A:1} | maxCount: 1
   - Budget: 1 (size) - 1 (maxCount) = 0. (0 <= k) -> VALID
   - maxLength: 1

Step 2: right = 1 ('A')
   - Window: [A, A] | Size: 2
   - count: {A:2} | maxCount: 2
   - Budget: 2 - 2 = 0. (0 <= k) -> VALID
   - maxLength: 2

Step 3: right = 2 ('B')
   - Window: [A, A, B] | Size: 3
   - count: {A:2, B:1} | maxCount: 2
   - Budget: 3 - 2 = 1. (1 <= k) -> VALID (We use our 1 change on 'B')
   - maxLength: 3

Step 4: right = 3 ('A')
   - Window: [A, A, B, A] | Size: 4
   - count: {A:3, B:1} | maxCount: 3
   - Budget: 4 - 3 = 1. (1 <= k) -> VALID
   - maxLength: 4

Step 5: right = 4 ('B')
   - Window: [A, A, B, A, B] | Size: 5
   - count: {A:3, B:2} | maxCount: 3
   - Budget: 5 - 3 = 2. (2 > k) -> INVALID (Budget exceeded!)
   - ACTION: Shrink from left (left++). 
   - New Window: [A, B, A, B] | Size: 4
   - maxLength stays 4.

Final Result: 4
---------------------------------------------------------------------------
Logic: Window Size - maxCount = Number of characters to replace.
If this exceeds k, the window is invalid and must slide.
*/
```
