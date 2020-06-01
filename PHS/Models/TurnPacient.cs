using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHS.Models
{
    public class TurnPacient
    {
        public int TurnPacientId { get; set; }
        public string name { get; set; }
        public int PacientId { get; set; }
        public string time { get; set; }
    }
}