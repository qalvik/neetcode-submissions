public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // Check for anagrams

        var mainDictionary = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var englishArray = new int[26];

            for (int j = 0; j < strs[i].Length; j++)
            {
                var letterPosition = strs[i][j] - 'a';

                englishArray[letterPosition]++;
            }

            var dictionaryKey = string.Join(",", englishArray);
            
            if (!mainDictionary.ContainsKey(dictionaryKey))
            {
                mainDictionary[dictionaryKey] = new List<string>();
            }

            mainDictionary[dictionaryKey].Add(strs[i]);
        }

        return mainDictionary.Values.ToList();
    }
}
