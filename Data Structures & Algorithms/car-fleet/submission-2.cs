public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        // Target: 10
        // CAR 1: START: 1, SPEED: 3
        // CAR 2: START: 4, SPEED: 2

        // Req 1: number of iterations = 
        // UNTIL every car arrives at the destination

        // One Challenge: track groups without scanning the array
        // SORT the array.

        // Iteration ONE
        // CAR 1: 4
        // CAR 2: 1
        // CAR 3: 0
        // CAR 4: 7

        // IT 2
        // CAR 1: 6 (+2)
        // CAR 2: 3 (+2)
        // CAR 3: 1 (+1)
        // CAR 4: 8 (+1)
        
        // IT 3
        // CAR 1: 8 (+2)
        // CAR 2: 5 (+2)
        // CAR 3: 2 (+1)
        // CAR 4: 9 (+1)
        
        // IT 4
        // CAR 1: 10 (+2) (Finished)
        // CAR 2: 7 (+2) 
        // CAR 3: 3 (+1)
        // CAR 4: 10 (+1) (Finished)

        // IT 4
        // CAR 1: (Finished)
        // CAR 2: 9 (+2) 
        // CAR 3: 4 (+1)
        // CAR 4: (Finished)

        var cars = position
            .Select((pos, i) => (Index: i, Position: pos))
            .OrderByDescending(x => x.Position)
            .ToArray();

        // Iteration ONE
        // CAR 4: 7 (+1) - distance to destnation: 3
        // CAR 1: 4 (+2) - distance to destination: 3
        // CAR 2: 1 (+2) - distance to destination: 4.5
        // CAR 3: 0 (+1) - distance to destination: 5

        var stack = new Stack<double>();

        foreach (var car in cars)
        {
            var carSpeed = speed[car.Index];
            var distanceToDestination = (double)(target - car.Position) / carSpeed;

            if (stack.Count == 0 )
                stack.Push(distanceToDestination);
            else if (stack.Peek() < distanceToDestination)
                stack.Push(distanceToDestination);
        }
        
        return stack.Count;
    }
}
