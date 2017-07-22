using System;
using System.Linq;
using System.Collections.Generic;

namespace SOLID
{
    public class JetSki : IWaterVehicle, IDriveableVehicle
    {

        public int PassengerCapacity { get; set; } = 1;
        public string TransmissionType { get; set; } = "Turbo";
        public double EngineVolume { get; set; } = 3.1;
        public double MaxSpeed { get; set; } = 70;
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            Console.WriteLine("Hey y'all watch this");
        }

        public void Stop()
        {
            Console.WriteLine("Stoppin the jet ski");
        }
    }
}