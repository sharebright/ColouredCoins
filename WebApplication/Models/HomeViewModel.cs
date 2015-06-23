using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class HomeViewModel
    {
        public IList<Models.PropertyViewModel> FeaturedProperties { get; set; }

        public HomeViewModel()
        {
            this.FeaturedProperties = new List<PropertyViewModel>();
        }
    }
}