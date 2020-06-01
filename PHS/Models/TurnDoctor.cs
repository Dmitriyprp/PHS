using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHS.Models
{
    public class TurnDoctor
    {
        public int TurnDoctorId { get; set; }
        public int DoctorId { get; set; }
        public string name { get; set; }
        public string time { get; set; }
    }
}