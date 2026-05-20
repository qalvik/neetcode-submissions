public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var inputArr = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            var idx = s1[i] - 'a';

            inputArr[idx]++;
        }   

        var l = 0;
        var r = 0;
        var outputArr = new int[26];

        while (r < s2.Length)
        {
            var idx = s2[r] - 'a';

            if (inputArr[idx] == 0)
            {
                r++;
                l = r;
                outputArr = new int[26];
            }  
            else 
            {
                outputArr[idx]++;

                while (outputArr[idx] > inputArr[idx])
                {
                    outputArr[s2[l] - 'a']--;
                    l++;
                }
               
                r++; 
            }

            var windowSize = r - l;

            if (windowSize == s1.Length)
                return true;
        }

        return false;
    }
}
