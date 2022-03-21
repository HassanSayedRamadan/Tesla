using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models
{
    public class NewRequestToken
    {
        public string audience { get; set; }
        public string client_id { get; set; }
        public string code_challenge { get; set; }
        public string code_challenge_method { get; set; }
        public string locale { get; set; }
        public string prompt { get; set; }
        public string redirect_uri { get; set; }
        public string response_type { get; set; }
        public string scope { get; set; }
        public string state { get; set; }
    }
}