using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.GET
{
    public class SoftwareUpdate
    {
        public int? download_perc { get; set; }
        public int? expected_duration_sec { get; set; }
        public int? install_perc { get; set; }
        public string status { get; set; }
        public string version { get; set; }
    }
}