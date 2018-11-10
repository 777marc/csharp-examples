namespace csharp_examples.BaseConstructors
{
  public class Vehicle
  {
    private readonly int _id;
    public Vehicle(int id)
    {
      this._id = id;
      System.Console.WriteLine("vehicle initialized");
    }
  }
}