using D00_Utility;
using E01_OOP_Vehicle_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class Car : Vehicle, IVehicleRoad
    {
        #region Properties

        public string CarRegistration { get; set; }
        public EnumRoadVehicleBrand RoadVehicleBrand { get; set; }
        public EnumRoadVehicleModel RoadVehicleModel { get; set; }
        public EnumRoadVehicleColor RoadVehicleColor { get; set; }
        public EnumRoadVehicleNumberOfDoors RoadVehicleNumberOfDoors { get; set; }

        public override string FullVehicle => $"{base.FullVehicle}\nCar registration: {CarRegistration}\nBrand: {RoadVehicleBrand}\nModel: {RoadVehicleModel}\nColor: {RoadVehicleColor}\nDoors: {RoadVehicleNumberOfDoors}.";

        #endregion

        #region Constructors

        public Car() : base()
        {
            CarRegistration = "000000";
            RoadVehicleBrand = EnumRoadVehicleBrand.Mercedez;
            RoadVehicleModel = EnumRoadVehicleModel.EQC;
            RoadVehicleColor = EnumRoadVehicleColor.Preto;
            RoadVehicleNumberOfDoors = EnumRoadVehicleNumberOfDoors.Quatro;
            MaxSpeed = 180;
        }

        public Car(int vehicleYear, string carRegistration, EnumRoadVehicleBrand roadVehicleBrand, EnumRoadVehicleModel roadVehicleModel, EnumRoadVehicleColor roadVehicleColor, EnumRoadVehicleNumberOfDoors roadVehicleNumberOfDoors) : base(vehicleYear)
        {
            CarRegistration = carRegistration;
            RoadVehicleBrand = roadVehicleBrand;
            RoadVehicleModel = roadVehicleModel;
            RoadVehicleColor = roadVehicleColor;
            RoadVehicleNumberOfDoors = roadVehicleNumberOfDoors;
            MaxSpeed = 180;
        }

        #endregion

        #region Methods

        public override void CreateVehicle()
        {
            Utility.WriteTitle("Create Road Vehicles", "", "\n\n");

            #region RoadVehicleYear

            base.GetVehicleYear();

            #endregion

            #region RoadVehicleCurrentSpeed

            GetCarSpeed();

            #endregion

            #region RoadVehicleRegistration

            GetCarRegistration();

            #endregion

            #region RoadVehicleBrand

            GetVehicleBrand();

            #endregion

            #region RoadVehicleModel

            GetVehicleModel();

            #endregion

            #region RoadVehicleColor

            GetCarColor();

            #endregion

            #region RoadVehicleNumberOfDoors

            GetCarNumberOfDoors();

            #endregion

        }

        internal void GetCarSpeed()
        {
            bool isSpeed;
            double speed;

            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Road Vehicles", "", "\n\n");

                Utility.WriteMessage("Enter speed: ");

                string answer = Console.ReadLine();

                isSpeed = double.TryParse(answer, out speed);

                if (!CheckCarSpeed(speed))
                {
                    Utility.WriteMessage($"Maximum speed: {MaxSpeed}km/h.");
                    Utility.PauseConsole();
                    isSpeed = false;
                }

            } while (!isSpeed);

            CurrentSpeed = speed;
        }

        internal void GetCarRegistration()
        {
            string carRegistration;
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Road Vehicles", "", "\n\n");

                Utility.WriteMessage("Car registration: ");
                carRegistration = Console.ReadLine();

                if (carRegistration != string.Empty)
                {
                    CarRegistration = carRegistration;
                }
                else
                {
                    Utility.WriteMessage("You need to enter the car registration.", "\n", "\n");
                    Utility.PauseConsole();
                }

            } while (carRegistration == string.Empty);
        }

        internal void ShowRoadVehicleBrand()
        { 
            Utility.WriteTitle("Car Brands", "", "\n\n");

            foreach (EnumRoadVehicleBrand brand in Enum.GetValues(typeof(EnumRoadVehicleBrand)))
            {
                Utility.WriteMessage($"{brand}", "", "\n");
            }
        }

        public override void GetVehicleBrand()
        {
            bool isBrand;
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Road Vehicles", "", "\n\n");

                ShowRoadVehicleBrand();

                Utility.WriteMessage("Write the Brand: ", "\n");

                string brand = Console.ReadLine();

                isBrand = Enum.TryParse(brand, true, out EnumRoadVehicleBrand carBrand);

                if (isBrand)
                {
                    RoadVehicleBrand = carBrand;
                }
                else
                {
                    Utility.WriteMessage($"Invalid brand entered. Choose one of the options.", "\n", "\n\n");
                    Utility.PauseConsole();
                }
            } while (!isBrand);
        }

        internal void ShowRoadVehicleModel()
        {
            Utility.WriteTitle("Road Vehicle Models", "", "\n\n");

            foreach (EnumRoadVehicleModel model in Enum.GetValues(typeof(EnumRoadVehicleModel)))
            {
                Utility.WriteMessage($"{model}", "", "\n");
            }
        }

        public override void GetVehicleModel()
        {
            bool isModel;
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Road Vehicles", "", "\n\n");

                ShowRoadVehicleModel();

                Utility.WriteMessage("Write the Model: ", "\n");

                string model = Console.ReadLine();

                isModel = Enum.TryParse(model, true, out EnumRoadVehicleModel carModel);

                if (isModel)
                {
                    RoadVehicleModel = carModel;
                }
                else
                {
                    Utility.WriteMessage($"Invalid model entered. Choose one of the options.", "\n", "\n\n");
                    Utility.PauseConsole();
                }
            } while (!isModel);
            
        }

        internal void ShowRoadVehicleColor()
        {
            Utility.WriteTitle("Road Vehicles color: ", "", "\n\n");

            foreach (EnumRoadVehicleColor color in Enum.GetValues(typeof(EnumRoadVehicleColor)))
            {
                Utility.WriteMessage($"{color}", "", "\n");
            }
        }

        internal void GetCarColor()
        {
            bool isColor;
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Road Vehicles", "", "\n\n");

                ShowRoadVehicleColor();

                Utility.WriteMessage("Write the Color: ", "\n");

                string color = Console.ReadLine();

                isColor = Enum.TryParse(color, true, out EnumRoadVehicleColor carColor);

                if (isColor)
                {
                    RoadVehicleColor = carColor;
                }
                else
                {
                    Utility.WriteMessage($"Invalid color entered. Choose one of the options.", "\n", "\n\n");
                    Utility.PauseConsole();
                }
            } while (!isColor);
        }

        internal void ShowRoadVehicleDoors()
        {
            Utility.WriteTitle("Road Vehicles Doors", "", "\n\n");

            foreach (EnumRoadVehicleNumberOfDoors door in Enum.GetValues(typeof(EnumRoadVehicleNumberOfDoors)))
            {
                Utility.WriteMessage($"{door}", "", "\n");
            }
        }

        internal void GetCarNumberOfDoors()
        {
            bool isDoor;
            do
            {
                Console.Clear();
                Utility.WriteTitle("Create Road Vehicles", "", "\n\n");

                ShowRoadVehicleDoors();

                Utility.WriteMessage("Number Of Doors: ", "\n");

                string doors = Console.ReadLine();

                isDoor = Enum.TryParse(doors, true, out EnumRoadVehicleNumberOfDoors carDoors);

                if (isDoor)
                {
                    RoadVehicleNumberOfDoors = carDoors;
                }
                else
                {
                    Utility.WriteMessage($"Invalid number of doors entered. Choose one of the options.", "\n", "\n\n");
                    Utility.PauseConsole();
                }
            } while (!isDoor);
            
        }

        internal bool CheckCarSpeed(double speed)
        {

            if (speed > MaxSpeed)
            {
                return false;
            }
            return true;
        }

        public override void StartVehicle()
        {
            Utility.WriteMessage("Starting the Car.", "\n", "\n");
        }

        // Polimorphism with Inheritance and Overloading 
        // Overloading method with different parameter (signature) and behavior.
        public void MoveVehicle(double speed)
        {
            CurrentSpeed = speed;

            Utility.WriteMessage($"Car in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");
        }


        // Polimorphism with Inheritance and Override
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 50;

            Utility.WriteMessage($"Car in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");
        }


        public void Honk()
        {
            Utility.WriteMessage($"The Car is honking.", "", "\n");
        }


        public void Park()
        {
            Utility.WriteMessage($"The Car is parking, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }


        public override void StopVehicle()
        {
            Utility.WriteMessage($"The Car is stopping, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }

        public override void ListVehicle()
        {
            Utility.WriteTitle("Car Information", "\n", "\n\n");

            Utility.WriteMessage($"{FullVehicle}", "", "\n");
        }

        #endregion

    }
}
