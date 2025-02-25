using Utility;
using E01_OOP_Vehicle_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class Submarine : Vehicle, IVehicleWater
    {
        #region Properties

        public string PennantNumber { get; set; }
        public double CurrentDepth { get; set; }
        public double MaxDepth { get; set; }
        public EnumWaterVehicleBrand WaterVehicleBrand { get; set; }
        public EnumWaterVehicleModel WaterVehicleModel { get; set; }
        public EnumWaterVehicleType WaterVehicleType { get; set; }

        public override string FullVehicle => $"{base.FullVehicle}\nPennant number: {PennantNumber}\nCurrent depth: {CurrentDepth}\nMaximum depth: {MaxDepth}\nBrand: {WaterVehicleBrand}\nModel: {WaterVehicleModel}\nType: {WaterVehicleType}";
        #endregion

        #region Constructors

        public Submarine() : base() 
        {
            PennantNumber = "000000";
            CurrentDepth = 0.0;
            MaxDepth = 500.00;
            MaxSpeed = 60.00;
            WaterVehicleBrand = EnumWaterVehicleBrand.Beneteau;
            WaterVehicleModel = EnumWaterVehicleModel.Oceanis;
            WaterVehicleType = EnumWaterVehicleType.Submarine;
        }

        public Submarine(int vehicleYear, string pennantNumber, double currentDepth, EnumWaterVehicleBrand waterVehicleBrand, EnumWaterVehicleModel waterVehicleModel, EnumWaterVehicleType waterVehicleType) : base(vehicleYear)
        {
            PennantNumber = pennantNumber;
            CurrentDepth = currentDepth;
            MaxDepth = 500.00;
            MaxSpeed = 60.00;
            WaterVehicleBrand = waterVehicleBrand;
            WaterVehicleModel = waterVehicleModel;
            WaterVehicleType = waterVehicleType;
        }



        #endregion


        #region Methods

        public override void CreateVehicle()
        {
            RSGymUtility.WriteTitle("Create Water Vehicle", "", "\n\n");

            #region WaterVehicleYear

            base.GetVehicleYear();

            #endregion

            #region WaterVehiclePennantNumber

            GetPennantNumber();

            #endregion

            #region WaterVehicleType

            GetWaterVehicleType();

            #endregion

            #region WaterVehicleBrand

            GetVehicleBrand();

            #endregion

            #region WaterVehicleModel

            GetVehicleModel();

            #endregion

        }

        
        internal void GetPennantNumber()
        {
            string pennantNumber;
            do
            {
                Console.Clear();
                RSGymUtility.WriteTitle("Create a Water Vehicle", "", "\n\n");

                RSGymUtility.WriteMessage("Pennant number: ");
                pennantNumber = Console.ReadLine();

                if (pennantNumber != string.Empty)
                {
                    PennantNumber = pennantNumber;
                }
                else
                {
                    RSGymUtility.WriteMessage("You need to enter the pennant number.", "\n", "\n");
                    RSGymUtility.PauseConsole();
                }

            } while (pennantNumber == string.Empty);
        }

        internal void ShowWaterVehicleType()
        { 
            RSGymUtility.WriteTitle("Water Vehicle Types", "", "\n\n");

            foreach (EnumWaterVehicleType type in Enum.GetValues(typeof(EnumWaterVehicleType)))
            {
                RSGymUtility.WriteMessage($"{type}", "", "\n");
            }
        }

        internal void GetWaterVehicleType()
        {
            bool isType;
            do
            {
                Console.Clear();
                RSGymUtility.WriteTitle("Create a Water Vehicle", "", "\n\n");

                ShowWaterVehicleType();

                RSGymUtility.WriteMessage("Write the Type: ", "\n");

                string type = Console.ReadLine();

                isType = Enum.TryParse(type, true, out EnumWaterVehicleType waterType);

                if (isType)
                {
                    WaterVehicleType = waterType;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid type entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isType);
        }

        internal void ShowWaterVehicleBrand()
        {
            RSGymUtility.WriteTitle("Water Vehicle Brands", "", "\n\n");

            foreach (EnumWaterVehicleBrand brand in Enum.GetValues(typeof(EnumWaterVehicleBrand)))
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
                RSGymUtility.WriteTitle("Create a Water Vehicle", "", "\n\n");

                ShowWaterVehicleBrand();

                RSGymUtility.WriteMessage("Write the Brand: ", "\n");

                string brand = Console.ReadLine();

                isBrand = Enum.TryParse(brand, true, out EnumWaterVehicleBrand waterBrand);

                if (isBrand)
                {
                    WaterVehicleBrand = waterBrand;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid brand entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isBrand);
        }

        internal void ShowWaterVehicleModel()
        {
            RSGymUtility.WriteTitle("Water Vehicle Models", "", "\n\n");

            foreach (EnumWaterVehicleModel model in Enum.GetValues(typeof(EnumWaterVehicleModel)))
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
                RSGymUtility.WriteTitle("Create a Water Vehicle", "", "\n\n");

                ShowWaterVehicleModel();

                RSGymUtility.WriteMessage("Model: ", "\n");

                string model = Console.ReadLine();

                isModel = Enum.TryParse(model, true, out EnumWaterVehicleModel waterModel);
                if (isModel)
                {
                    WaterVehicleModel = waterModel;
                }
                else
                {
                    RSGymUtility.WriteMessage($"Invalid model entered. Choose one of the options.", "\n", "\n\n");
                    RSGymUtility.PauseConsole();
                }
            } while (!isModel);
            
        }

        public override void StartVehicle()
        {
            RSGymUtility.WriteMessage($"Starting the {WaterVehicleType}.", "\n", "\n");
        }

        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 60;

            RSGymUtility.WriteMessage($"{WaterVehicleType} in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");
        }

        public void Dive()
        {
            if (WaterVehicleType == EnumWaterVehicleType.Submarine)
            {
                CurrentDepth = GetVehicleDepth();

                RSGymUtility.WriteMessage($"Submarine is diving with a depth of {CurrentDepth} meters.", "", "\n");
            }
            else
            { 
                RSGymUtility.WriteMessage($"The {WaterVehicleType} is not a submarine and cannot dive.", "", "\n");
                RSGymUtility.PauseConsole();
            }
        }

        internal double GetVehicleDepth()
        {
            double depth;
            bool isDepth;

            if (WaterVehicleType == EnumWaterVehicleType.Submarine)
            {
                do
                {
                    Console.Clear();
                    RSGymUtility.WriteTitle("Create a Water Vehicle", "", "\n\n");

                    RSGymUtility.WriteMessage("Depth: ", "\n");

                    string answer = Console.ReadLine();

                    isDepth = double.TryParse(answer, out depth);

                    if (!CheckVehicleDepth(depth))
                    {
                        RSGymUtility.WriteMessage($"Maximum depth: {MaxDepth}km/h.");
                        RSGymUtility.PauseConsole();
                        isDepth = false;
                    }

                } while (!isDepth);
            }
            else
            {
                depth = 0.0;
                RSGymUtility.WriteMessage($"The {WaterVehicleType} is not a submarine and cannot dive.", "", "\n");
                RSGymUtility.PauseConsole();
            }   
            
            return depth;
        }

        internal bool CheckVehicleDepth(double depth)
        {
            if (depth > MaxDepth)
            {
                return false;
            }
            return true;
        }

        public void Emerge()
        {
            if (WaterVehicleType == EnumWaterVehicleType.Submarine)
            {
                CurrentDepth = 0.0;

                RSGymUtility.WriteMessage($"The {WaterVehicleType} emerged and reached the surface successfully.", "", "\n");
            }
            else
            {
                RSGymUtility.WriteMessage($"The {WaterVehicleType} is not a submarine and cannot emerge.", "", "\n");
                RSGymUtility.PauseConsole();
            }
        }

        public override void StopVehicle()
        {
            RSGymUtility.WriteMessage($"The {WaterVehicleType} is stopping, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }

        public override void ListVehicle()
        {
            RSGymUtility.WriteTitle($"{WaterVehicleType} Information", "\n", "\n\n");

            RSGymUtility.WriteMessage($"{FullVehicle}", "", "\n");
        }

        #endregion




    }
}
