using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class User
    {
        public String Name { get; set; }

        public String AssetAddress { get; set; }

        public String BTCAddress { get; set; }

        public String WIFKey { get; set; }
    }
}