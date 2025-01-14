using D00_Utility;
using E01_OOP_Vehicle_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal abstract class Vehicle : IVehicle
    {
        #region Properties

        public int VehicleId { get; }
        private static int NextId { get; set; } = 1;
        public int VehicleYear { get; set; }
        public Enum Brand { get; set; }
        public Enum Model { get; set; }
        public double CurrentSpeed { get; set; }
        public double MaxSpeed { get; set; }

        public virtual string FullVehicle => $"Vehicle nº: {VehicleId}\nFabrication year: {VehicleYear}\nCurrent speed: {CurrentSpeed}\nMaximum speed: {MaxSpeed}";

        #endregion

        #region Constructors

        public Vehicle()
        {
            VehicleId = NextId++;
            VehicleYear = DateTime.Now.Year;
            CurrentSpeed = 0;
            MaxSpeed = 0;
        }

        public Vehicle(int vehicleYear)
        {
            VehicleId = NextId++;
            VehicleYear = vehicleYear;
            CurrentSpeed = 0;
            MaxSpeed = 0;
        }

        #endregion
        // métodos não devem ser implementados na classe abstrata, pois não temos informações suficientes para implementá-los, rever arquitetura do projeto para implementar corretamente nas classes filhas
        // métodos abstratos devem ser implementados nas classes filhas
        #region Methods

        public abstract void CreateVehicle();

        public abstract void StartVehicle();

        public abstract void MoveVehicle();

        public abstract void StopVehicle();

        public abstract void ListVehicle();

        public abstract void GetVehicleBrand();

        public abstract void GetVehicleModel();

        // Checar com Milena
        public virtual void GetVehicleYear()
        {
            bool isYear;
            int year;

            do
            {
                Utility.WriteMessage("Vehicle fabrication year: ");

                string answer = Console.ReadLine();

                isYear = int.TryParse(answer, out year);

                if (!isYear)
                {
                    Utility.WriteMessage("Enter a valid year.", "\n", "\n");
                    Utility.PauseConsole();
                }
                else if (!VehicleUtility.CheckVehicleYear(year))
                {
                    Utility.WriteMessage($"Year range between 1950 and {DateTime.Now.Year}.", "\n", "\n");
                    Utility.PauseConsole();
                    isYear = false;
                }

            } while (!isYear);

            VehicleYear = year;
        }

        #endregion

    }
}
