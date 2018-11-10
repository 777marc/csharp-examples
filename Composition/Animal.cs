namespace csharp_examples.Composition
{
    public class Animal : IAnimal
    {
        public int Age { get; set; }
        
        public void Eat()
        {
            System.Console.WriteLine("Eating");
        }

        public void Sleep()
        {
            System.Console.WriteLine();
        }
    }
}