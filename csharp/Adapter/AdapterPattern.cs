namespace design_pattern.csharp.Adapter
{
    internal class Sparrow : IBird
    {
        public void Fly() => Console.WriteLine("Flying...");

        public void MakeSound() => Console.WriteLine("Chirp..Chirp...");
    }

    internal class PlayDuck : IToyDuck
    {
        public void Squeak() => Console.WriteLine("Squeak...");
    }

    internal class BirdAdapter : IToyDuck
    {
        public IBird Bird { get; }

        public BirdAdapter(IBird bird)
        {
            Bird = bird;
        }

        public void Squeak() => Bird.MakeSound();
    }
}