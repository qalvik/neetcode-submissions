public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 1)
            return StandardBinarySearch(matrix, target, 0, 0, matrix[0].Length - 1);

        var row = ColumnBinarySearch(matrix, target, 0, matrix.Length - 1);
        
        if (row == -1)     
            return false;
        else
            return StandardBinarySearch(matrix, target, row, 0, matrix[row].Length - 1);
    }

    private int ColumnBinarySearch(int[][] matrix, int target, int l, int r)
    {
        if (l > r)
            return -1;
        
        var m = (l + r) / 2;

        if (matrix[m][0] == target)
            return m;
        else if (matrix[m][0] > target)
            return ColumnBinarySearch(matrix, target, l, m - 1);
        else 
        {   
            if (m + 1 >= matrix.Length)
                return m;
            else if (matrix[m + 1][0] > target)
                return m;
            else 
                return ColumnBinarySearch(matrix, target, m + 1, r);
        }
    }

    private bool StandardBinarySearch(int[][] matrix, int target, int row, int l, int r)
    {
        if (l > r)
            return false;
        
        var m = (l + r) / 2;

        if (matrix[row][m] == target)
            return true;
        else if (matrix[row][m] > target)
            return StandardBinarySearch(matrix, target, row, l, m - 1);
        else 
            return StandardBinarySearch(matrix, target, row, m + 1, r);
    }
}
