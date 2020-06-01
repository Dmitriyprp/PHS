using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHS.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string mail { get; set; }
        public int passport { get; set; }
        public string NSP { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string working { get; set; }
    }
}