using System;
using System.Linq;
using System.Collections.Generic;

namespace SOLID
{
    public class Cessna : IAirVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxSpeed { get; set; } = 309.0;

        public void Fly()
        {
            Console.WriteLine("The Cessna effortlessly glides through my clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            Console.WriteLine("Taking off");
        }

        public void Land()
        {
            Console.WriteLine("Landing");

        }
    }
}