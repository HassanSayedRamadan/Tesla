using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.POST
{
    public class RequestRefreshToken
    {
        public string refresh_token { get; set; }
        public string grant_type { get; set; }
    }
}