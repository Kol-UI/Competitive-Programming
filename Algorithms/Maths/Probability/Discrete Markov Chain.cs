namespace CompetitiveProgramming.Algorithms
{
    // See State Simulation
    public class MarkovChain
    {
        enum WeatherState { Sunny, Cloudy, Rainy }

        static void Main(string[] args)
        {
            WeatherState currentState = WeatherState.Sunny;
            Random random = new Random();

            double[,] transitionMatrix = {
                { 0.7, 0.2, 0.1 },  // Probabilities from Sunny to {Sunny, Cloudy, Rainy}
                { 0.3, 0.4, 0.3 },  // Probabilities from Cloudy to {Sunny, Cloudy, Rainy}
                { 0.2, 0.3, 0.5 }   // Probabilities from Rainy to {Sunny, Cloudy, Rainy}
            };

            // Simulate 10 days of weather
            for (int day = 0; day < 10; day++)
            {
                Console.WriteLine($"Day {day}: Weather is {currentState}");
                currentState = NextState(currentState, transitionMatrix, random);
            }
        }

        static WeatherState NextState(WeatherState currentState, double[,] transitionMatrix, Random random)
        {
            double rand = random.NextDouble();
            double cumulative = 0.0;
            int stateIndex = (int)currentState;

            for (int i = 0; i < 3; i++)
            {
                cumulative += transitionMatrix[stateIndex, i];
                if (rand < cumulative)
                {
                    return (WeatherState)i;
                }
            }

            throw new InvalidOperationException("Invalid transition");
        }
    }
}