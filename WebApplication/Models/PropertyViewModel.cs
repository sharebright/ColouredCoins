using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class PropertyViewModel
    {
        public String ID { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public String FeatureSummary { get; set; }

        public Double Value { get; set; }

        public Boolean Featured { get; set; }

        public String AssetAddress { get; set; }

        public IList<Models.Share> Shares { get; set; }
    }
}