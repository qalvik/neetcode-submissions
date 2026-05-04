public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int[]>();
        var currentHigh = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            var currentHeight = heights[i];
            var currentTop = stack.Count == 0 ? 0 : stack.Peek()[1];
            
            if (currentTop <= currentHeight)
                stack.Push([i, currentHeight]);
            else 
            {
                var startIndex = i;
                while (stack.Count > 0 && stack.Peek()[1] > currentHeight)
                {
                    var item = stack.Pop();
                    var width = i - item[0];
                    var area = item[1] * width;
                    currentHigh = Math.Max(area, currentHigh);
                    startIndex = item[0];
                }
                stack.Push([startIndex, currentHeight]);
            }
        }

        foreach (var itemArr in stack)
        {
            var localTop = (heights.Length - itemArr[0]) * itemArr[1];
            currentHigh = Math.Max(localTop, currentHigh);
        }

        return currentHigh;
    }
}
