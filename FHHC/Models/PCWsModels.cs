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

        public DateTime? FirstCheck { get; set; }

        public DateTime? LastCheck { get; set; }

        public DateTime? NextCheck { get; set; }
    }
}