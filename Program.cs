using System;
using System.Collections.Generic;
using csharp_examples.ParametersTest;
using csharp_examples.factories;
using csharp_examples.Indexers;
using csharp_examples.Composition;
using csharp_examples.Access;
using csharp_examples.BaseConstructors;

namespace csharp_examples
{
    public class MyClass
    {
        public int Id { get; set; }
        public MyClass()
        {
            System.Console.WriteLine("...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // int[] arrayToSum = {1,2,3,4};
            // Console.WriteLine(CustomMath.Add(arrayToSum));
            // VehicleFactory factory = new ConcreteVehicleFactory();
            // IFactory scooter = factory.GetVehicle("Scooter");
            // scooter.Drive(10);
            // IFactory bike = factory.GetVehicle("Bike");
            // bike.Drive(20);

            // var mylist = new Dictionary<string, string>();
            // var indexedList = new IndexedList(mylist);
            // indexedList["name"] = "Marcos Mendoza";
            // System.Console.WriteLine(mylist["name"]);

            // var human = new Human();
            // human.Walk();
            // var goldfish = new Goldfish();
            // goldfish.Swim();

            // var child = new Child();
            // child.Start();

            var car = new Car(12345);
            
            Console.ReadKey(); 

        }
    }
}
