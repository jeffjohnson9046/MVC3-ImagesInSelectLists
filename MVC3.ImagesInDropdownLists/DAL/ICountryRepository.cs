using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVC3.ImagesInDropdownLists.Models;

namespace MVC3.ImagesInDropdownLists.DAL
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
    }
}
