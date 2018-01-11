using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FHHC.Models
{
    public class PCWsModels
    {
        public int Id { get; set; }

        public DateTime? DateHired { get; set; }

        public List<DateTime?> DateCheck { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> Clients { get; set; }

        public List<string> Addresses { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }


    }
}