using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composition_over_inheritance
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public virtual void ShiftTransmission()
        {
            Console.WriteLine("Transmission shifted.");
        }

        public virtual void RotateWheels()
        {
            Console.WriteLine("Wheel rotated.");
        }

        public virtual void Drive()
        {
            StartEngine();
            ShiftTransmission();
            RotateWheels();
            Console.WriteLine("Vehicle is driving.");
        }
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public override void ShiftTransmission()
        {
            Console.WriteLine("Car transmission shifted.");
        }

        public override void RotateWheels()
        {
            Console.WriteLine("Car wheel rotated.");
        }
    }

    public class Truck : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started.");
        }

        public override void ShiftTransmission()
        {
            Console.WriteLine("Truck transmission shifted.");
        }

        public override void RotateWheels()
        {
            Console.WriteLine("Truck wheel rotated.");
        }
    }

}
//In this example, we have a Vehicle class that defines a set of methods for starting the engine, shifting the transmission, rotating the wheels, and driving the vehicle. We then have two subclasses, Car and Truck, that inherit from Vehicle and override these methods to provide their own specific implementations.

//By using inheritance in this way, we can create a hierarchy of classes that share common behavior, but can also be extended and customized in specific ways. However, this approach can lead to problems such as code duplication and tight coupling between classes, especially as the class hierarchy becomes more complex.



