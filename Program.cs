using System;
using System.Linq;
using System.Collections.Generic;

namespace SOLID
{
    public class Program
    {

        public static void Main()
        {

            Console.WriteLine("Vehicles Exercise");

            var airVehicles = new List<IAirVehicle>{
                    new Cessna(), new Helicopter()
            };

            foreach (var vehicle in airVehicles)
            {
                vehicle.Fly();
                vehicle.Land();
                Console.WriteLine();
            }

            var roadVehicles = new List<IDriveableVehicle>{
                new Delorean(),
                new Motorcycle()
            };

            foreach (var vehicle in roadVehicles)
            {
                vehicle.Drive();
                vehicle.Stop();
                Console.WriteLine();
            }

            var waterVehicles = new List<IWaterVehicle>{
                new JetSki(), new RowBoat()
            };

            foreach (var vehicle in waterVehicles)
            {
                vehicle.Start();

                var driveableVehicle = vehicle as IDriveableVehicle;
                if (driveableVehicle != null)
                {
                    driveableVehicle.Drive();
                    driveableVehicle.Stop();
                }
            }
            // Build a collection of all vehicles that fly

            // With a single `foreach`, have each vehicle Fly()

            // Build a collection of all vehicles that operate on roads

            // With a single `foreach`, have each road vehicle Drive()



            // Build a collection of all vehicles that operate on water

            // With a single `foreach`, have each water vehicle Drive()
        }

    }
}