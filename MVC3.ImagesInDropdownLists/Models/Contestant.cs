using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3.ImagesInDropdownLists.Models
{
    public class Contestant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int CountryId { get; set; }
    }
}