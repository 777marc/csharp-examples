namespace csharp_examples.OverRideLoad
{
    public class Child : Parent
    {
        public override void DoSomething()
        {
            System.Console.WriteLine("Do something override");
        }
    }
}