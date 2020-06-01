using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHS.Models
{
    public class Disease
    {
        public int DiseaseId { get; set; }
        public string name { get; set; }
        public string start { get; set; }
        public string finish { get; set; }
        public string text { get; set; }
        public int PacientId { get; set; }
    }
}