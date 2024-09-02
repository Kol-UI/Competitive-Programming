namespace CompetitiveProgramming.Algorithms
{
    // See Discrete Markov Chain
    public class TrafficLight
    {
        enum LightState { Red, Green, Yellow }

        static void Main(string[] args)
        {
            LightState currentState = LightState.Red;
            int time = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Time {time}: Light is {currentState}");
                currentState = NextState(currentState);
                time += 1;
            }
        }

        static LightState NextState(LightState currentState)
        {
            switch (currentState)
            {
                case LightState.Red:
                    return LightState.Green;
                case LightState.Green:
                    return LightState.Yellow;
                case LightState.Yellow:
                    return LightState.Red;
                default:
                    throw new InvalidOperationException("Invalid state");
            }
        }
    }
}