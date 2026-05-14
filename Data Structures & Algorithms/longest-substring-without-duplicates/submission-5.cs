public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dict = new Dictionary<char, int>();
        var maxLength = 0;
        var left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (dict.TryGetValue(s[right], out int prevIndex) && prevIndex >= left)
                left = prevIndex + 1;

            dict[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
