﻿using Utility;
using E01_OOP_Vehicle_v1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RSGymUtility.SetUnicodeConsole();
           
            #region Air Vehicles
            
            Airplane plane01 = new Airplane();

            plane01.CreateVehicle();
            RSGymUtility.PauseConsole();

            plane01.ListVehicle();
            RSGymUtility.PauseConsole();

            plane01.StartVehicle();
            plane01.MoveVehicle();
            plane01.TakeOff();
            plane01.Land();
            plane01.StopVehicle();
            RSGymUtility.PauseConsole();

            Airplane plane02 = new Airplane(1999, "N45632", EnumAirVehicleBrand.Boing, EnumAirVehicleModel.A350, EnumAirVehicleType.Airplane);

            plane02.ListVehicle();
            RSGymUtility.PauseConsole();

            plane02.StartVehicle();
            plane02.MoveVehicle();
            plane02.TakeOff();
            plane02.Land();
            plane02.StopVehicle();
            RSGymUtility.PauseConsole();

            #endregion
            

            #region Road Vehicles

            Car car01 = new Car();

            car01.CreateVehicle();
            RSGymUtility.PauseConsole();

            car01.ListVehicle();
            RSGymUtility.PauseConsole();

            car01.StartVehicle();
            car01.MoveVehicle(car01.CurrentSpeed);
            car01.Honk();
            car01.Park();
            car01.StopVehicle();
            RSGymUtility.PauseConsole();

            #endregion


            #region Water Vehicles

            Submarine submarine01 = new Submarine();

            submarine01.CreateVehicle();
            RSGymUtility.PauseConsole();

            submarine01.ListVehicle();
            RSGymUtility.PauseConsole();

            submarine01.StartVehicle();
            submarine01.MoveVehicle();
            submarine01.Dive();
            submarine01.Emerge();
            submarine01.StopVehicle();

            #endregion

            RSGymUtility.TerminateConsole();
        }
    }
}
