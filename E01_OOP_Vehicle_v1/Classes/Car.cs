using Utility;
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
            RSGymUtility.WriteTitle("Create Road Vehicles", "", "\n\n");

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
                RSGymUtility.WriteTitle("Create Road Vehicles", "", "\n\n");

                RSGymUtility.WriteMessage("Enter speed: ");

                string answer = Console.ReadLine();

                isSpeed = double.TryParse(answer, out speed);

                if (!CheckCarSpeed(speed))
                {
                    RSGymUtility.WriteMessage($"Maximum speed: {MaxSpeed}km/h.");
                    RSGymUtility.PauseConsole();
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
                RSGymUtility.WriteTitle("Create Road Vehicles", "", "\n\n");

                RSGymUtility.WriteMessage("Car registration: ");
                carRegistration = Console.ReadLine();

                if (carRegistration != string.Empty)
                {
                    CarRegistration = carRegistration;
                }
                else
                {
                    RSGymUtility.WriteMessage("You need to enter the car registration.", "\n", "\n");
                    RSGymUtility.PauseConsole();
                }

            } while (carRegistration == string.Empty);
        }

        internal void ShowRoadVehicleBrand()
        { 
            RSGymUtility.WriteTitle("Car Brands", "", "\n\n");

            foreach (EnumRoadVehicleBrand brand in Enum.GetValues(typeof(EnumRoadVehicleBrand)))
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
                RSGymUtility.WriteTitle("Create Road Vehicles", "", "\n\n");

                ShowRoadVehicleBrand();

                RSGymUtility.WriteMessage("Write the Brand: ", "\n");

                string brand = Console.ReadLine();

                isBrand = Enum.TryParse(brand, true, out EnumRoadVehicleBrand carBrand);

                if (isBrand)
                {
                    RoadVehicleBrand = carBrand;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid brand entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isBrand);
        }

        internal void ShowRoadVehicleModel()
        {
            RSGymUtility.WriteTitle("Road Vehicle Models", "", "\n\n");

            foreach (EnumRoadVehicleModel model in Enum.GetValues(typeof(EnumRoadVehicleModel)))
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
                RSGymUtility.WriteTitle("Create Road Vehicles", "", "\n\n");

                ShowRoadVehicleModel();

                RSGymUtility.WriteMessage("Write the Model: ", "\n");

                string model = Console.ReadLine();

                isModel = Enum.TryParse(model, true, out EnumRoadVehicleModel carModel);

                if (isModel)
                {
                    RoadVehicleModel = carModel;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid model entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isModel);
            
        }

        internal void ShowRoadVehicleColor()
        {
            RSGymUtility.WriteTitle("Road Vehicles color: ", "", "\n\n");

            foreach (EnumRoadVehicleColor color in Enum.GetValues(typeof(EnumRoadVehicleColor)))
            {
                RSGymUtility.WriteMessage($"{color}", "", "\n");
            }
        }

        internal void GetCarColor()
        {
            bool isColor;
            do
            {
                Console.Clear();
                RSGymUtility.WriteTitle("Create Road Vehicles", "", "\n\n");

                ShowRoadVehicleColor();

                RSGymUtility.WriteMessage("Write the Color: ", "\n");

                string color = Console.ReadLine();

                isColor = Enum.TryParse(color, true, out EnumRoadVehicleColor carColor);

                if (isColor)
                {
                    RoadVehicleColor = carColor;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid color entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isColor);
        }

        internal void ShowRoadVehicleDoors()
        {
            RSGymUtility.WriteTitle("Road Vehicles Doors", "", "\n\n");

            foreach (EnumRoadVehicleNumberOfDoors door in Enum.GetValues(typeof(EnumRoadVehicleNumberOfDoors)))
            {
                RSGymUtility.WriteMessage($"{door}", "", "\n");
            }
        }

        internal void GetCarNumberOfDoors()
        {
            bool isDoor;
            do
            {
                Console.Clear();
                RSGymUtility.WriteTitle("Create Road Vehicles", "", "\n\n");

                ShowRoadVehicleDoors();

                RSGymUtility.WriteMessage("Number Of Doors: ", "\n");

                string doors = Console.ReadLine();

                isDoor = Enum.TryParse(doors, true, out EnumRoadVehicleNumberOfDoors carDoors);

                if (isDoor)
                {
                    RoadVehicleNumberOfDoors = carDoors;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid number of doors entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
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
            RSGymUtility.WriteMessage("Starting the Car.", "\n", "\n");
        }

        // Polimorphism with Inheritance and Overloading 
        // Overloading method with different parameter (signature) and behavior.
        public void MoveVehicle(double speed)
        {
            CurrentSpeed = speed;

            RSGymUtility.WriteMessage($"Car in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");
        }


        // Polimorphism with Inheritance and Override
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 50;

            RSGymUtility.WriteMessage($"Car in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");
        }


        public void Honk()
        {
            RSGymUtility.WriteMessage($"The Car is honking.", "", "\n");
        }


        public void Park()
        {
            RSGymUtility.WriteMessage($"The Car is parking, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }


        public override void StopVehicle()
        {
            RSGymUtility.WriteMessage($"The Car is stopping, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }

        public override void ListVehicle()
        {
            RSGymUtility.WriteTitle("Car Information", "\n", "\n\n");

            RSGymUtility.WriteMessage($"{FullVehicle}", "", "\n");
        }

        #endregion

    }
}
