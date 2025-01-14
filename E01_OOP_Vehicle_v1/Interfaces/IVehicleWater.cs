using E01_OOP_Vehicle_v1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Interfaces
{
    internal interface IVehicleWater : IVehicle
    {
        string PennantNumber { get; }
        double CurrentDepth { get; }
        double MaxDepth { get; }
        EnumWaterVehicleType WaterVehicleType { get; }

        #region Methods

        void Dive();
        void Emerge();

        #endregion
    }
}
