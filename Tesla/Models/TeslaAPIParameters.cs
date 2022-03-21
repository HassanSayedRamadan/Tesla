using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models
{
    public class TeslaAPIParameters
    {
        public double? DriverTemp { get; set; }
        public double? PassengerTemp { get; set; }
        public double? LimitValue { get; set; }
        public string State { get; set; }
        public List<string> States { get; set; }
        public double? Percent { get; set; }
        public bool? On { get; set; }
    }
}