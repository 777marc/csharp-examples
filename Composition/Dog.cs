namespace csharp_examples.Composition
{
    public class Dog : IAnimal, IWalkable
    {
        public int Age { get; set; }
        
        public void Eat()
        {
            System.Console.WriteLine("Eating");
        }

        public void Sleep()
        {
            System.Console.WriteLine("Sleeping");
        }

        public void Walk()
        {
            System.Console.WriteLine("Walking");
        }
        
    }
}