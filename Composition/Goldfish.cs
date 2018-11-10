using System;

namespace csharp_examples.Composition
{
  public class Goldfish : IAnimal, ISwimmable
  {
    public int Age {get; set;}

    public void Eat()
    {
        Console.WriteLine("Eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }

    public void Swim()
    {
        Console.WriteLine("Swimming");
    }
  }
}