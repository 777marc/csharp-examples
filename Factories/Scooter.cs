using System;

namespace csharp_examples.factories
{
    public class Scooter : IFactory
    {
        public void Drive(int miles) 
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }

}