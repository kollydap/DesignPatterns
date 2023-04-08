using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator_Pattern
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }

    public class Transmission
    {
        public void Shift()
        {
            Console.WriteLine("Transmission shifted.");
        }
    }

    public class Wheel
    {
        public void Rotate()
        {
            Console.WriteLine("Wheel rotated.");
        }
    }

    public class Vehicle
    {
        private readonly Engine engine;
        private readonly Transmission transmission;
        private readonly List<Wheel> wheels;

        public Vehicle(Engine engine, Transmission transmission, List<Wheel> wheels)
        {
            this.engine = engine;
            this.transmission = transmission;
            this.wheels = wheels;
        }

        public void Drive()
        {
            engine.Start();
            transmission.Shift();

            foreach (var wheel in wheels)
            {
                wheel.Rotate();
            }

            Console.WriteLine("Vehicle is driving.");
        }
    }

}
//In this example, we have three component classes (Engine, Transmission, and Wheel) that each provide specific functionality. We then have a Vehicle class that takes these components as constructor arguments and uses them to perform a Drive operation.

//By using composition in this way, we can easily create different types of vehicles by mixing and matching different implementations of each component. For example, we could create a sports car by using a high-performance engine, a manual transmission, and sporty wheels, or we could create a truck by using a larger engine, an automatic transmission, and heavy-duty wheels.

//This demonstrates the flexibility and modularity that can be achieved through composition, rather than relying on a complex hierarchy of inheritance.