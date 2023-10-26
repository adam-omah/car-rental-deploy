using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    internal class RentalModel
    {
        public int Rental_ID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime PickUpDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public char Status { get; set; }

        public string CarRegistration { get; set; }

        public int Client_ID { get; set; }

    }
}
