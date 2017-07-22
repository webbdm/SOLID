using System;

namespace SOLID
{
    public class Delorean : IGroundVehicle, IDriveableVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Flux Capacitor";
        public double EngineVolume { get; set; } = 1.11;
        public double MaxSpeed { get; set; } = 88;

        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Start()
        {
            Console.WriteLine("We don't need roads where we're going");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }
}