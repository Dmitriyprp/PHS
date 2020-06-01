using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHS.Models
{
    public class Pacient
    {
        public int PacientId { get; set; }
        public string birthDay { get; set; }
        public int DoctorId { get; set; }
        public string mail { get; set; }
        public string NSP { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}