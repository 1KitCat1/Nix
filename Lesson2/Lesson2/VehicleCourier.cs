using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class VehicleCourier : Courier
    {
        private bool isVehicleRented;
        private string vehicleStatus;

        public VehicleCourier(string id, string name) : base(id, name)
        {

        }
    }
}
