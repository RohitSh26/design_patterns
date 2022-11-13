

using design_pattern.csharp.Adapter;

namespace design_pattern.csharp
{
    public class DesignPatterns
    {
        public static void Main(string[] args)
        {
            // Adapter Pattern Implementation
            var sparrow = new Sparrow();
            var toyDuck = new PlayDuck();

            // wrap a bird in a bird adapter
            // so that it behaves like a toy
            IToyDuck birdAdapter = new BirdAdapter(bird: sparrow);

            Console.WriteLine("Sparrow...");
            sparrow.Fly(); sparrow.MakeSound();

            Console.WriteLine("Toy Duck...");
            toyDuck.Squeak();

            // let adapt some features for a toy
            // make 'em behave like a bird
            Console.WriteLine("Bird Adapter...");
            birdAdapter.Squeak();
        }
    }

}