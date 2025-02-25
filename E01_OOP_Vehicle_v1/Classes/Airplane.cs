using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using E01_OOP_Vehicle_v1.Interfaces;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class Airplane : Vehicle, IVehicleAir
    {
        #region Properties

        public string PlaneRegistration { get; set; }
        public double CurrentAltitude { get; set; }
        public double MaxAltitude { get; }
        public EnumAirVehicleBrand AirVehicleBrand { get; set; }
        public EnumAirVehicleModel AirVehicleModel { get; set; }
        public EnumAirVehicleType AirVehicleType { get; set; }

        public override string FullVehicle => $"{base.FullVehicle}\nPlane registration: {PlaneRegistration}\nCurrent altitude: {CurrentAltitude}\nMax altitude: {MaxAltitude:F3} feet\nBrand: {AirVehicleBrand}\nModel: {AirVehicleModel}\nType: {AirVehicleType}.";

        #endregion


        #region Constructors

        public Airplane() : base()
        { 
            PlaneRegistration = "N00000";
            MaxSpeed = 900;
            MaxAltitude = 45.000;
            AirVehicleBrand = EnumAirVehicleBrand.Embraer;
            AirVehicleModel = EnumAirVehicleModel.Phenom;
            AirVehicleType = EnumAirVehicleType.Airplane;
        }

        public Airplane(int vehicleYear, string planeRegistration, EnumAirVehicleBrand airVehicleBrand, EnumAirVehicleModel airVehicleModel, EnumAirVehicleType airVehicleType) : base(vehicleYear)
        {
            PlaneRegistration = planeRegistration;
            MaxSpeed = 900;
            MaxAltitude = 45.000;
            AirVehicleBrand = airVehicleBrand;
            AirVehicleModel = airVehicleModel;
            AirVehicleType = airVehicleType;
        }

        #endregion

         
        #region Methods
        // Polimorphism with Inheritance and Override methods
        // Override the Vehicle method adding Airplane properties

        public override void CreateVehicle()
        {
            RSGymUtility.WriteTitle("Create Air Vehicles", "", "\n\n");

            #region AirVehicleYear

            base.GetVehicleYear();

            #endregion

            #region AirVehicleRegistration

            GetPlaneRegistration();

            #endregion

            #region AirVehicleType

            GetPlaneType();

            #endregion

            #region AirVehicleBrand

            GetVehicleBrand();

            #endregion

            #region AirVehicleModel

            GetVehicleModel();

            #endregion
        }

        internal void GetPlaneRegistration()
        {
            string planeRegistration;
            do
            {
                Console.Clear();
                RSGymUtility.WriteTitle("Create Air Vehicles", "", "\n\n");

                RSGymUtility.WriteMessage("Registration: ");
                planeRegistration = Console.ReadLine();

                if (planeRegistration != string.Empty)
                {
                    PlaneRegistration = planeRegistration;
                }
                else
                {
                    RSGymUtility.WriteMessage("You need to enter the registration.", "\n", "\n");
                    RSGymUtility.PauseConsole();
                }

            } while (planeRegistration == string.Empty);
        }

        internal void ShowAirVehicles()
        {
            RSGymUtility.WriteTitle("Available Air Vehicle Types: ", "", "\n\n");

            foreach (EnumAirVehicleType type in Enum.GetValues(typeof(EnumAirVehicleType)))
            {
                RSGymUtility.WriteMessage($"{type}", "", "\n");
            }
        }

        internal void GetPlaneType()
        {
            bool isType;
            do
            {
                Console.Clear();
                RSGymUtility.WriteTitle("Create Air Vehicles", "", "\n\n");

                ShowAirVehicles();

                RSGymUtility.WriteMessage("Write the Type: ", "\n");

                string type = Console.ReadLine();

                isType = Enum.TryParse(type, true, out EnumAirVehicleType planeType);

                if (isType)
                {
                    AirVehicleType = planeType;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid type entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isType);
        }

        internal void ShowAirVehicleBrand()
        {
            RSGymUtility.WriteTitle("Available Air Vehicle Brands: ", "", "\n\n");

            foreach (EnumAirVehicleBrand brand in Enum.GetValues(typeof(EnumAirVehicleBrand)))
            {
                RSGymUtility.WriteMessage($"{brand}", "", "\n");
            }
        }

        public override void GetVehicleBrand()
        {
            bool isBrand;
            do
            {
                Console.Clear();
                RSGymUtility.WriteTitle("Create Air Vehicles", "", "\n\n");

                ShowAirVehicleBrand();

                RSGymUtility.WriteMessage("Write the Brand: ", "\n");

                string brand = Console.ReadLine();

                isBrand = Enum.TryParse(brand, true, out EnumAirVehicleBrand planeBrand);

                if (isBrand)
                {
                    AirVehicleBrand = planeBrand;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid brand entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isBrand);
        }

        internal void ShowAirVehicleModel()
        { 
            RSGymUtility.WriteTitle("Available Air Vehicle Models: ", "", "\n\n");

            foreach (EnumAirVehicleModel model in Enum.GetValues(typeof(EnumAirVehicleModel)))
            {
                RSGymUtility.WriteMessage($"{model}", "", "\n");
            }
        }

        public override void GetVehicleModel()
        {
            bool isModel;
            do
            {
                Console.Clear();
                RSGymUtility.WriteTitle("Create Air Vehicles", "", "\n\n");

                ShowAirVehicleModel();

                RSGymUtility.WriteMessage("Write the Model: ", "\n");

                string model = Console.ReadLine();

                isModel = Enum.TryParse(model, true, out EnumAirVehicleModel planeModel);

                if (isModel)
                {
                    AirVehicleModel = planeModel;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid model entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isModel);
            
        }

        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method specifying the vehicle name
        public override void StartVehicle()
        {
            RSGymUtility.WriteMessage($"Starting {AirVehicleType}.", "", "\n");
        }


        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 280;

            RSGymUtility.WriteMessage($"{AirVehicleType} in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");

        }

        public void TakeOff()
        {
            CurrentAltitude = 35.000;
            
            RSGymUtility.WriteMessage($"The {AirVehicleType} is taking off and has gone from 0 feet to {CurrentAltitude:F3} feet.", "", "\n");
        }


        public void Land()
        {
            CurrentAltitude = 0.0;

            RSGymUtility.WriteMessage($"The {AirVehicleType} landed successfully.", "", "\n");
        }


        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void StopVehicle()
        {
            RSGymUtility.WriteMessage($"The {AirVehicleType} is stopping, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }

        public override void ListVehicle()
        {
            RSGymUtility.WriteTitle($"{AirVehicleType} Information", "\n", "\n\n");

            RSGymUtility.WriteMessage($"{FullVehicle}", "", "\n");
        }

        #endregion

    }
}
