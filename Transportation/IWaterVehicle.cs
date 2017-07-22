using System;
using System.Linq;
using System.Collections.Generic;

namespace SOLID
{

   public interface IWaterVehicle : IVehicle
    {
        double MaxSpeed { get; set; }
    }
}