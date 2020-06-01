using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHS.Models
{
    public class UsePreparation
    {
        public int UsePreparationId { get; set; }
        public int PreparationId { get; set; }
        public string start { get; set; }
        public string finish { get; set; }
        public int PacientId { get; set; }
    }
}