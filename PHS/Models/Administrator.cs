using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHS.Models
{
    public class Administrator
    {
        public int AdministratorId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string NSP { get; set; }
    }
}