using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ClientModel
    {

        public int Client_id { get; set; }
        public string Name { get; set; }

        public DateTime DOB { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string LicenceType { get; set; }

        public string Company { get; set; }
        
    }
}
