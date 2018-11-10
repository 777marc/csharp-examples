namespace csharp_examples.BaseConstructors
{
    public class Car : Vehicle
    {
        public Car(int id) : base(id)
        {
            System.Console.WriteLine("car initialized");
        }
    }
}