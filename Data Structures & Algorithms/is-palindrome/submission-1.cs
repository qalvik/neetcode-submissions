public class Solution {
    public bool IsPalindrome(string s) {
        // ignore whitespace
        // ignore case

        var fordwardPointer = 0;
        var backwardPointer = s.Length - 1;

        while (backwardPointer > fordwardPointer)
        {   
            // same, last letter
            if (backwardPointer == fordwardPointer)
                return true;
            
            while (!char.IsLetterOrDigit(s[fordwardPointer])
                && backwardPointer > fordwardPointer)
            {
                fordwardPointer++;
            }
            while (!char.IsLetterOrDigit(s[backwardPointer])
                && backwardPointer > fordwardPointer)
            {
                backwardPointer--;
            }

            if (char.ToLower(s[fordwardPointer]) 
                != char.ToLower(s[backwardPointer]))
                return false;

            fordwardPointer++;
            backwardPointer--;
        }

        return true;
    }
}
