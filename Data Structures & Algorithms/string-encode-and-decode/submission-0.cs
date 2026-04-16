public class Solution {

    public string Encode(IList<string> strs) {
        var result = string.Empty;

        foreach (var str in strs)
        {
            result += $"{str.Length}#{str}";
        }

        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();

        var predictedLengthIndicator = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '#')
            {
                var currentExtractedLength = int.Parse(s.Substring(
                    i - predictedLengthIndicator, predictedLengthIndicator));

                var firstString = s.Substring(i + 1, currentExtractedLength);
                result.Add(firstString);

                i += currentExtractedLength;
                predictedLengthIndicator = 0;
            }
            else
            {
                predictedLengthIndicator++;
            }
        }

        return result;
    }
}
