using System;
using System.Linq;
using System.Collections.Generic;

namespace SOLID
{

    public interface IDriveableVehicle : IVehicle
    {
        void Drive();
        void Stop();
    }
}