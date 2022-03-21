using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models
{
    public class DataAuth
    {
        public string _csrf { get; set; }
        public string _phase { get; set; }
        public string _process { get; set; }
        public string transaction_id { get; set; }
        public string cancel { get; set; }
        public string identity { get; set; }
        public string credential { get; set; }
    }
}