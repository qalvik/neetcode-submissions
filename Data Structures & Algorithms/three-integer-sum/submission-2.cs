public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var triplets = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i-1])
                continue;

            if (i + 1 < nums.Length)
            {
                var leftPointer = i + 1; 
                var rightPointer = nums.Length - 1;

                while (leftPointer < rightPointer)
                {
                    if (nums[leftPointer] + nums[rightPointer] + nums[i] < 0)
                        leftPointer++;          
                    else if (nums[leftPointer] + nums[rightPointer] + nums[i] > 0)
                        rightPointer--;
                    else 
                    {
                        triplets.Add([nums[leftPointer], nums[rightPointer], nums[i]]);
                        leftPointer++;
                        rightPointer--;

                        while (leftPointer < rightPointer 
                            && nums[leftPointer] == nums[leftPointer - 1]) leftPointer++;

                    }
                }
            }       
        }

        return triplets;
    }
}
