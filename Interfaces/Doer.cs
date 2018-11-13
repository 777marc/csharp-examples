namespace csharp_examples.Interfaces
{
    public class Doer : IDoer
    {
        private readonly int _doerId;

        public Doer(int doerId)
        {
            this._doerId = doerId;
        }

        public void GetDoerId()
        {
            System.Console.WriteLine("Doer id {0}", this._doerId);
        }

    }
}