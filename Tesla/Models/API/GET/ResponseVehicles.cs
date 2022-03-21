using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.GET
{
    public class ResponseVehicles
    {
        public List<ResponseVehicle> response { get; set; }
        public int? count { get; set; }
    }
}