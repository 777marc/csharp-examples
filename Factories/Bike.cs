using System;

namespace csharp_examples.factories
{
    public class Bike : IFactory
    {
        public void Drive(int miles)        
        {
             Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }
}