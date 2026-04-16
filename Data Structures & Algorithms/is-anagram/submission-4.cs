
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        char[] chars1 = s.ToCharArray();
        Array.Sort(chars1);

        char[] chars2 = t.ToCharArray();
        Array.Sort(chars2);

        return System.Linq.Enumerable.SequenceEqual(chars1, chars2);
    }
}