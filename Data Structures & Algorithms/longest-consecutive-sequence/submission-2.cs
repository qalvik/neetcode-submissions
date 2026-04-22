public class Solution {
    public int LongestConsecutive(int[] nums) {
        // 1. naiive approach: sort the array O(log n)
        // 2. not working approach: numer as the array index.
        // Not working because numbers can be negative
        // 3. Hashset lookups?

        if (nums.Length == 0)
        {
            return 0;
        }
        
        var elements = new HashSet<int>(nums);
        var longestSequence = 1;

        foreach (var element in elements)
        {
            // Start of a sequence - if value with -1 doesn't exist
            if (!elements.Contains(element - 1))
            {
                var localSequence = 1;
                while (elements.Contains(element + localSequence))
                {
                    localSequence++;

                    if (localSequence > longestSequence)
                    {
                        longestSequence = localSequence;
                    }
                }
            }
        }

        return longestSequence;
    }
}
