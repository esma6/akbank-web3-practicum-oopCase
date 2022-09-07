using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Entities.Abstract
{
    public interface IVehicle
    {
        string HgsNo {get;set;}
        string OwnerName {get;set;}
        string OwnerSurname {get;set;}
        string VehicleType {get;set;}
        DateTime Date {get;set;}
        double Balance {get;set;}
        double Still{get;set;}
    }
}