public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            // 4 = 7 - 3 
            var complement = target - nums[i];

            if (dictionary.ContainsKey(complement))
            {
                return [dictionary[complement], i];
            }

            dictionary[nums[i]] = i;
        }

        return [];
    }
}
