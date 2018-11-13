using System;
using System.Collections.Generic;
using csharp_examples.ParametersTest;
using csharp_examples.factories;
using csharp_examples.Indexers;
using csharp_examples.Composition;
//using csharp_examples.Access;
using csharp_examples.BaseConstructors;
using csharp_examples.Boxing;
using csharp_examples.OverRideLoad;
using csharp_examples.Interfaces;

namespace csharp_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var doer = new DoerImplementation(new Doer(123));
            doer.MakeItHappen();
            Console.ReadKey(); 
        }
    }
}
