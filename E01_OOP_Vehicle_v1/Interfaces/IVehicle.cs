using E01_OOP_Vehicle_v1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Interfaces
{
    internal interface IVehicle
    {
        #region Properties (public or internal)

        #region IVehicle own properties to be inherited by other interfaces and classes

        // declara intenção das propriedades que pertencem a IVehicle
        int VehicleId { get; }
        int VehicleYear { get; }
        Enum Brand { get; }
        Enum Model { get; }
        // checar com Milena
        double CurrentSpeed { get; }
        double MaxSpeed { get; }

        #endregion

        #endregion

        #region Methods

        #region IVehicle own methods to be inherited and implemented by other interfaces and classes

        // declara intenção dos métodos que pertencem a IVehicle
        void CreateVehicle();
        void StartVehicle();
        void MoveVehicle();
        void StopVehicle();
        // checar com Milena
        void GetVehicleBrand();
        void GetVehicleModel();
        void ListVehicle();

        #endregion

        #endregion

    }
}
