public class Solution {
    public string MinWindow(string s, string t) {
        var need = new int[52];
        foreach (var c in t) {
            need[char.IsLower(c) ? c - 'a' : c - 'A' + 26]++;
        }

        var window = new int[52];
        var have = 0;
        var total = 0;
        foreach (var n in need) if (n > 0) total++;

        var l = 0;
        var result = int.MaxValue;
        var startingIndex = 0;

        for (int r = 0; r < s.Length; r++) {
            var idx = char.IsLower(s[r]) ? s[r] - 'a' : s[r] - 'A' + 26;
            window[idx]++;

            if (need[idx] > 0 && window[idx] == need[idx])
                have++;

            while (have == total) {
                if (r - l + 1 < result) {
                    result = r - l + 1;
                    startingIndex = l;
                }

                var lIdx = char.IsLower(s[l]) ? s[l] - 'a' : s[l] - 'A' + 26;
                window[lIdx]--;
                if (need[lIdx] > 0 && window[lIdx] < need[lIdx])
                    have--;
                l++;
            }
        }

        return result == int.MaxValue ? "" : s.Substring(startingIndex, result);
    }
}
