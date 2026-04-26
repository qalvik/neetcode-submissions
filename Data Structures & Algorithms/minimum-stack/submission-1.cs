public class MinStack {
    private List<int> initialList;
    private List<int> minValues;
    // offset for first item
    int topIndex = -1;
    int minimumElementIndex = -1;

    public MinStack() {
        initialList = new();
        minValues = new();
    }
    
    public void Push(int val) {
        initialList.Add(val);
        topIndex++;

        if (minimumElementIndex == -1)
        {
            minValues.Add(val);
            minimumElementIndex++;
        }
        else 
        {
            if (val <= minValues[minimumElementIndex])
            {
                minValues.Add(val);
                minimumElementIndex++;
            }
        }
    }
    
    public void Pop() {
        var val = initialList[topIndex];
        initialList.RemoveAt(topIndex);
        topIndex--;

        if (val == minValues[minimumElementIndex])
        {
            minValues.RemoveAt(minimumElementIndex);
            minimumElementIndex--;
        }
    }
    
    public int Top() {
        return initialList[topIndex];
    }
    
    public int GetMin() {
        return minValues[minimumElementIndex];
    }
}
