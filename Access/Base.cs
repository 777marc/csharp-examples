namespace csharp_examples.Access
{
    public class Base
    {
        public void DoSomething()
        {
            System.Console.WriteLine("Do something");
        }

        protected void DoAProtectedThing()
        {
            System.Console.WriteLine("Do protected something");
        }
    }
}