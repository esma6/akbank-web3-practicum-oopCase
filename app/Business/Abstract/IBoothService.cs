using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Entities.Abstract;

namespace app.Business
{
    public interface IBoothService
    {
        double Payment(IVehicle vehicle);
        int DailyPass(List<IVehicle> vehicles);
    }
}