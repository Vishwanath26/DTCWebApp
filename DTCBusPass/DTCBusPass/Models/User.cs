using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTCBusPass.Models
{
    public class User
    {
        public string firstName { get; set; }
        public string surName { get; set; }
        public string emailAddress { get; set; }
        public string  password{ get; set; }
        public DateTime birthDate { get; set; }
        public string location { get; set; }
        public string gender { get; set; }
    }
}