public class Solution {
    public int MaxArea(int[] heights) {
        var l = 0;
        var r = heights.Length - 1;

        var max = 0;
    
        while (l < r)
        {
            var area = Math.Min(heights[l], heights[r]) * (r - l);
            max = Math.Max(max, area);

            if (heights[l] > heights[r])
                r--;
            else if (heights[r] > heights[l])
                l++;
            else 
            {
                l++;
                r--;
            }
        }

        return max;
    }
}
