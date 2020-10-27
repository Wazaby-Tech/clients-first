using System;
using System.Collections.Generic;
using System.Text;

namespace ClientsManager.Core.Model
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string StreetAbbr { get; set; }
        public string Unit { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
