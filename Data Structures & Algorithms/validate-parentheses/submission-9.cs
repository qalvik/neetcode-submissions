public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        
        if (s.Length % 2 != 0)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (c == '(' || c == '[' || c == '{')
                stack.Push(c);
            else 
            {   
                if (stack.Count == 0)
                    return false;

                var element = stack.Pop();

                if (element == '(' && c != ')')
                    return false;

                if (element == '[' && c != ']')
                    return false;

                if (element == '{' && c != '}')
                    return false;
            }
        }

        if (stack.Count != 0)
            return false;

        return true;
    }
}
