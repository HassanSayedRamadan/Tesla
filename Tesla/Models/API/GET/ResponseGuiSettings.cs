using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.GET
{
    public class ResponseGuiSettings
    {
        public bool? gui_24_hour_time { get; set; }
        public string gui_charge_rate_units { get; set; }
        public string gui_distance_units { get; set; }
        public string gui_range_display { get; set; }
        public string gui_temperature_units { get; set; }
        public bool? show_range_units { get; set; }
        public long? timestamp { get; set; }
    }
}