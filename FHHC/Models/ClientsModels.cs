using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FHHC.Models
{
    public class ClientsModels
    {
        public int Id { get; set; }

        public string DateStarted { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<PCWsModels> PCWs { get; set; }

        public List<AddressModels> Addresses { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}