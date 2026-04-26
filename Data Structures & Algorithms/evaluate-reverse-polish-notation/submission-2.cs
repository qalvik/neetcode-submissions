public class Solution {
    public int EvalRPN(string[] tokens) {
        // FEED the stack:
        // 1, 2, + detected!
        // FREE the stack 
        // 2 (place the operand) + (1) = 3
        // add the RESULT to stack

        // NEXT iteration
        // 3, 3, * detected!
        // 3 (place the operand) * 3 = 9
        // add the RESULT to stack

        // NEXT iteration
        // 9, 4, - detected!
        // 9 (place the operand) - 4 = 5

        // NO more items in tokens arr - DONE!  
        // STEPS:
        // 1. iterate over tokens
        // 2. feed the stack until OPERAND is detected
        // 3. pop the items from stack, compute RESULT
        // 4. add result to the stack
        // 5. repeat until there are no items in the stack
        // 6. EXTRA: division by 0 - handle it

        var stack = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            var token = tokens[i];
            if (DetectOperand(token))
            {
                // Actually, there always should be only two numbers
                var left = stack.Pop();
                var right = stack.Pop();

                if (token == "+")
                    stack.Push(left + right);
                else if (token == "-")
                    stack.Push(right - left);
                else if (token == "*")
                    stack.Push(left * right);
                else 
                {
                    if (right == 0)
                        stack.Push(0);
                    else 
                       stack.Push(right / left); 
                }    
            }
            else
            {
                stack.Push(Int32.Parse(token));
            }
        }

        return stack.Pop();
    }

    private bool DetectOperand(string c) => 
        c == "+" || c == "-" || c == "*" || c == "/";
}
