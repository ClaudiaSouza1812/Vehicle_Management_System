using E01_OOP_Vehicle_v1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Interfaces
{
    internal interface IVehicleAir : IVehicle
    {
        // declara intenção das propriedades que pertencem unicamente a IVehicleAir
        string PlaneRegistration { get; }
        double CurrentAltitude { get; }
        double MaxAltitude { get; }
        EnumAirVehicleType AirVehicleType { get; }

        #region Methods

        // declara intenção dos métodos que pertencem a IVehicleAir

        void TakeOff();
        void Land();

        #endregion
    }
}
