using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Repositories
{
    public class Mock : IPropertyRepository
    {
        public IQueryable<Models.PropertyViewModel> All
        {
            get
            {
                List<Models.PropertyViewModel> mocks = new List<Models.PropertyViewModel>(1);
                mocks.Add(new Models.PropertyViewModel()
                    {
                        Name = "Bondi Beach",
                        Value = 2000000,
                        ID = "1",
                        Featured = true
                    });

                return mocks.AsQueryable<Models.PropertyViewModel>();
            }
        }
    }
}