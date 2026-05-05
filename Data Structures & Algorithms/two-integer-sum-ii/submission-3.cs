public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // [1, 2, 3, 4, 7]  target: 6

        // pointer 1: val < 6
        // pointer 2: val < 6
        // p1: 1
        // p2: 7, 4
        // p1: 2
        // p2: 4, goog

        var leftPointer = 0;
        var rightPointer = numbers.Length - 1;

        while (leftPointer < rightPointer &&
            numbers[leftPointer] + numbers[rightPointer] != target)
        {
            if (numbers[leftPointer] + numbers[rightPointer] < target)
                leftPointer++;

            if (numbers[leftPointer] + numbers[rightPointer] > target)
                rightPointer--;
        }

        return [leftPointer + 1, rightPointer + 1];
    }
}
