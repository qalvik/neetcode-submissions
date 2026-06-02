public class Solution {
    public int Search(int[] nums, int target) {
       return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    private int BinarySearch(int[] nums, int target, int l, int r)
    {
        if (l > r) return -1;
        
        var m = (l + r) / 2;
    
        if (nums[m] == target)
            return m;
        if (nums[m] > target)
            return BinarySearch(nums, target, l, m - 1);
        else 
            return BinarySearch(nums, target, m + 1 , r);
    }
}
