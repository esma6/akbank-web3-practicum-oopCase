using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Entities.Abstract;

namespace app.Entities.Concrete
{
    public class Minibus : IVehicle
    {
        private double still = 30.0;
        public string HgsNo { get; set; } = string.Empty;
        public string OwnerName { get; set; } = string.Empty;
        public string OwnerSurname { get; set; } = string.Empty;
        public string VehicleType { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public double Balance { get; set; }
        public double Still
        {
            get { return still; }
            set { }
        }
    }
}