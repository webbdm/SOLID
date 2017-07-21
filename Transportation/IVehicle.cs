using System;
using System.Linq;
using System.Collections.Generic;

namespace SOLID
{

    public interface IVehicle
    {
        
        int PassengerCapacity { get; set; }
        
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }


        //int Wheels { get; set; }
        //int Doors { get; set; }
        //bool Winged { get; set; }
        //double MaxWaterSpeed { get; set; }
        //double MaxLandSpeed { get; set; }
        //double MaxAirSpeed { get; set; }
        
        void Start();
        void Stop();
        void Drive();
        void Fly();
    }
}