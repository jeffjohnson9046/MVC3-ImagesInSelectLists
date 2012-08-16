using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3.ImagesInDropdownLists.DAL
{
    public class MockContestantRepository : IContestantRepository
    {
        public void Add(Models.Contestant newContestant)
        {
            // This is where the database persistence would happen...
        }
    }
}