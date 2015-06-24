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

    public class MockUserRepo : IUserRepository
    {
        public IQueryable<Models.User> All
        {
            get
            {
                List<Models.User> mocks = new List<Models.User>(3);
                mocks.Add(new Models.User()
                {
                    Name = "Alice",
                    AssetAddress = "mgJbos81tWctowDWD1q3EjkZhGmcysj5rr",
                    BTCAddress = "mgJbos81tWctowDWD1q3EjkZhGmcysj5rr",
                    WIFKey = "cN2DYQQaxDXCp8EJTP9Y8wFMpjQCc7VKThf7ZuxgCvLMaCpoW2x3"
                });

                mocks.Add(new Models.User()
                {
                    Name = "Bob",
                    AssetAddress = "mzx9qRvqc3SV7RjmQVJo3MY315oTnwsLjh",
                    BTCAddress = "mzx9qRvqc3SV7RjmQVJo3MY315oTnwsLjh",
                    WIFKey = "cS4wZpG8WZVHAo8hKfHUJDzEzZyz1LEP288kBXH45fHE96KhjXB2"
                });

                return mocks.AsQueryable<Models.User>();
            }
        }
    }
}