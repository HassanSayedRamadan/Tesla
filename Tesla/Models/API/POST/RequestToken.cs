using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.POST
{
    public class RequestToken
    {
        public string email { get; set; }
        public string password { get; set; }
        public string client_secret { get; set; }
        public string client_id { get; set; }
        public string grant_type { get; set; }
    }
}