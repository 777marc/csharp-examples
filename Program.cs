using System;
using System.Collections.Generic;
using csharp_examples.ParametersTest;
using csharp_examples.factories;

namespace csharp_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arrayToSum = {1,2,3,4};
            // Console.WriteLine(CustomMath.Add(arrayToSum));

            VehicleFactory factory = new ConcreteVehicleFactory();
            
            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);
            
            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);
            
            Console.ReadKey();            

        }
    }
}
