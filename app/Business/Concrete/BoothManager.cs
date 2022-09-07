using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Entities.Abstract;

namespace app.Business.Concrete
{
    public class BoothManager : IBoothService
    {
        public int DailyPass(List<IVehicle> vehicles)
        {
            int day = DateTime.Now.Day;
            int pass = 0;
            foreach (IVehicle vehicle in vehicles)
            {
                if (vehicle.Date.Day == DateTime.Now.Date.Day )
                {
                    pass++;
                }
            }
            return pass;
        }

        public double Payment(IVehicle vehicle)
        {
            //REFACTOR
            // if(vehicle.VehicleType.Equals("Car") ){
            //     return vehicle.Balance*2.5;
            // }
            // else if(vehicle.VehicleType.Equals("Minibus") ){
            //     return vehicle.Balance*3;
            // }
            // else if(vehicle.VehicleType.Equals("Otobus")) {
            //     return vehicle.Still;
            // }
            // else{
            //     return -1;
            // }

            double result = (vehicle.Balance) - (vehicle.Still);
            return result;

        }
    }
}