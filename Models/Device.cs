using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersourcedUnitTesting.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string OSVersion { get; set; }
        public string Model { get; set; }
        public string Architecture { get; set; }
    }
}