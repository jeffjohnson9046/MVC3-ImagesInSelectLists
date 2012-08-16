using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC3.ImagesInDropdownLists.Models;

namespace MVC3.ImagesInDropdownLists.DAL
{
    public class MockCountryRepository : ICountryRepository
    {
        public IEnumerable<Country> GetAllCountries()
        {
            return new List<Country>
                       {
                           new Country { ID = 1, Name = "Germany", ImageFile = "de.png" },
                           new Country { ID = 2, Name = "United Kingdom", ImageFile = "gb.png" },
                           new Country { ID = 3, Name = "United States", ImageFile = "us.png" },
                           new Country { ID = 4, Name = "Samoa", ImageFile = "ws.png" }
                       }.AsEnumerable();
        }
    }
}