using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01_OOP_Vehicle_v1.Classes;

namespace E01_OOP_Vehicle_v1.Interfaces
{
    internal interface IVehicleRoad : IVehicle
    {
        // declara intenção das propriedades que pertencem unicamente a IVehicleRoad
        #region Properties

        string CarRegistration { get; }
        EnumRoadVehicleColor RoadVehicleColor  { get; }
        EnumRoadVehicleNumberOfDoors RoadVehicleNumberOfDoors { get; }

        #endregion

        #region Methods

        // declara intenção dos métodos que pertencem a IVehicleRoad
        void MoveVehicle(double speed);
        void Park();
        void Honk();

        #endregion
    }
}
