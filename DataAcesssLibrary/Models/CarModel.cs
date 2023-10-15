using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class CarModel
    {
        public string Registration { get; set; }
        public string FuelType { get; set; }

        public string Model { get; set; }

        public int NumberOfPassengers { get; set; }

        public float CostPerDay { get; set; }

        public char Status {get; set; }

        public string CarType { get; set; }
    }
}
