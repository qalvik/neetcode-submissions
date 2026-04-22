public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Starting solution:
        // Check each row
        // Check each column
        // Check each 3x3

        // IF I visit the first row, then:
        // I visited 1/3 of 3 first 3x3 sub-boxes
        // I visited 1/9 of 9 columns

        // IF I visit the second row, then:
        // I visited 2/3 of the 3 first 3x3 sub-boxes
        // I visited 2/9 of 9 columns
        var rows = new bool[9, 10];
        var columns = new bool[9, 10];
        var thirds = new bool[9, 10];
        
        // 1st third: i: 0 - 2, j: 0 - 2 = < 3, < 3
        // 2nd third: i: 0 - 2, j: 3 - 5 = < 3, < 6
        // 3rd third: i: 0 - 2, j: 6 - 8 = SUM: 6 - 10
        // 4th third: i: 3 - 5, j: 0 - 2 = SUM: 3 - 7
        // 5th third: i: 3 - 5, j: 3 - 5
        // 4th third: i: 3 - 5, j: 6 - 8

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                int number;
                var sudokuField = board[i][j];
                bool isNumber = int.TryParse([sudokuField], out number);

                if (!isNumber)
                {
                    continue;
                }

                if (rows[i, number] == true)
                {
                    return false;
                }

                if (columns[j, number] == true)
                {
                    return false;
                }
                
                var thirdIndex = (i / 3) * 3 + (j / 3);

                if (thirds[thirdIndex, number] == true)
                {
                    return false;
                }

                rows[i, number] = true;
                columns[j, number] = true;
                thirds[thirdIndex, number] = true;
            }
        }

        return true;
    }

    
}
