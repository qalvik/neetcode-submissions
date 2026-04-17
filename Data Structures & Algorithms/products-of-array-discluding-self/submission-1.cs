public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // 1 2 3 4
        // output:
        // i[0] = 1 (skipped) * 2 * 3 * 4 = 24
        // i[1] = 1 * 1 (skipped) * 3 * 4 = 12
        // i[2] = 1 * 2 * 1 (skipped) * 4 = 8
        // i[3] = 1 * 2 * 3 * 1 (skipped)

        // pattern = skipped value = ALWAYS 1 = constraint
        // pattern = if all values doesn't have 0, we can simply divide
        // pattern = if ANY value is 0, then all other values besides it would be 0

        var result = new int[nums.Length];

        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];

        prefix[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i-1] * nums[i-1];
        }

        suffix[nums.Length - 1] = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i+1] * nums[i+1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix[i] * suffix[i];
        }    

        return result;
    }

    private int[] NaiveApproach(int[] nums) {
        var result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var localResult = 1;

            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    localResult = localResult * 1;
                }
                else 
                {
                    localResult = localResult * nums[j];
                }
            }

            result[i] = localResult;
        }

        return result;
    }

    private int[] NotWorkingApproach(int[] nums) {
        var result = new int[nums.Length];
        
        // 2, 3, 4
        var initialResult = 1;
        var totalNonZeroResult = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            initialResult = initialResult * nums[i];

            if (nums[i] != 0)
            {
                totalNonZeroResult = totalNonZeroResult * nums[i];
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                result[i] = totalNonZeroResult;
            }
            else 
            {
                result[i] = initialResult;

                var nextIndex = i + 1;
                if (nextIndex < nums.Length)
                {
                    double multiplier = (double)nums[i] / (double)nums[nextIndex];
                    initialResult = (int)(initialResult * multiplier);
                }
            }      
        }

        return result;
    }
}
