using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.GET
{
    public class SpeedLimitMode
    {
        public bool? active { get; set; }
        public double? current_limit_mph { get; set; }
        public double? max_limit_mph { get; set; }
        public double? min_limit_mph { get; set; }
        public bool? pin_code_set { get; set; }
    }
}