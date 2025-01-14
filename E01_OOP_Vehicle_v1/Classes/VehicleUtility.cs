using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class VehicleUtility
    {
        public static bool CheckVehicleYear(int year)
        {
            if (year >= 1950 && year <= DateTime.Today.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
