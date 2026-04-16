public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dictionary.ContainsKey(nums[i]))
                dictionary[nums[i]] = 0;

            dictionary[nums[i]]++;
        }

        var bucket = new List<int>[nums.Length + 1];
        for (int i = 0; i < bucket.Length; i++)
            bucket[i] = new List<int>();

        foreach (var item in dictionary)
        {
            bucket[item.Value].Add(item.Key);
        }

        var result = new List<int>();

        for (int i = bucket.Length - 1; i >= 0 && result.Count < k; i--)
        {
            result.AddRange(bucket[i]);
        }

        return result.ToArray();
    }
}
