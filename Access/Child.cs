namespace csharp_examples.Access
{
    public class Child : Base
    {
        public void Start()
        {
            System.Console.WriteLine("Start");
            this.DoSomething();
            this.DoAProtectedThing();
        }
    }
}