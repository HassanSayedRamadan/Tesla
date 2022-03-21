using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.GET
{
    public class ResponseDriveState
    {
        public int? gps_as_of { get; set; }
        public int? heading { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public double? native_latitude { get; set; }
        public int? native_location_supported { get; set; }
        public double? native_longitude { get; set; }
        public string native_type { get; set; }
        public int? power { get; set; }
        public string shift_state { get; set; }
        public string speed { get; set; }
        public long? timestamp { get; set; }
    }
}