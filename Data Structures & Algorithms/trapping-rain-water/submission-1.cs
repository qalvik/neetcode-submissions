public class Solution {
    public int Trap(int[] height) {
        var l = 0;
        var r = height.Length - 1;
        var lMax = 0;
        var rMax = 0;
        var trappedWater = 0;

        while (l < r)
        {
            lMax = Math.Max(lMax, height[l]);
            rMax = Math.Max(rMax, height[r]);

            if (lMax < rMax)
                trappedWater += lMax - height[l++];
            else
                trappedWater += rMax - height[r--];
        }

        return trappedWater;
    }
}