public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // [30,38,30,36,35,40,28]

        // GET 1 value: 30
        // * if stack != empty - stack.top?()
        // * load to stack? 30
        // when the warmer day occurs?
        // * check if top value from stack < next value
        // * if yes - remove the old value (pop), add the new one
        // * if not - add the value to the stack, iterate over
        // NEXT value from the iteration: 38
        // result: 1

        // GET 2 value: 38 - pick from stack???
        // 38 Needs to be removed first from stack??
        // when the wamer day occurs? 
        // NEXT value from the iteration: 30 - nah
        // NEXT value from the iteration: 36 - nah
        // NEXT value from the iteration: 35 - nah
        // NEXT value from the iteration: 40 - yes
        // result: 4

        // GET 3 value: 30
        // when the wamer day occurs? 
        // NEXT value from the iteration: 36 - yes
        // result: 1

        // next value from the iteration?? hmm
        var result = new int[temperatures.Length];
        var stack = new Stack<int[]>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            var temp = temperatures[i];

            while (stack.Count > 0 && temp > stack.Peek()[0])
            {
                var pair = stack.Pop();
                result[pair[1]] = i - pair[1];
            }

            stack.Push(new int[] { temp, i });
        } 

        return result;
    }
}
