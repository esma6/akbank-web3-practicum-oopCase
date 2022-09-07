using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Entities.Abstract;

namespace app.Core.Logging
{
    public class Logger
    {
        public static double Report(List<IVehicle> vehicles)
        {
            double totalPrice = 0;
            int day = DateTime.Now.Day;
            foreach (IVehicle vehicle in vehicles)
            {
                if (vehicle.Balance > 0 && vehicle.Date.Day == DateTime.Now.Date.Day )
                {
                    totalPrice += vehicle.Balance;
                }
            }
            return totalPrice;


        }
    }
}