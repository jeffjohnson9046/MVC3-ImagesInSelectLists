using System.Collections.Generic;
using System.Web.Mvc;
using MVC3.ImagesInDropdownLists.ViewModels;
using MVC3.ImagesInDropdownLists.DAL;
using System.Web.Mvc.Html;
using MVC3.ImagesInDropdownLists.Models;
using AutoMapper;

namespace MVC3.ImagesInDropdownLists.Controllers
{
    public class ContestantController : Controller
    {
        private readonly IContestantRepository _contestantRepository;


        public ContestantController()
        {
            this._contestantRepository = new MockContestantRepository();
        }


        public ActionResult Create()
        {
            var reservationViewModel = new CreateContestantViewModel
                                           {
                                               AllCountries = this.GetAllCountries()
                                           };

            return View(reservationViewModel);
        }

        [HttpPost]
        public ActionResult Create(CreateContestantViewModel newContestant)
        {
            if (ModelState.IsValid)
            {
                var employee = Mapper.Map<CreateContestantViewModel, Contestant>(newContestant);
                this._contestantRepository.Add(employee);
            }

            return View("Success", newContestant);
        }


        #region Utility Methods

        /// <summary>
        /// Get all the countries from the "database" and convert them to a collection of <c>ImageSelectListItem</c>s.
        /// </summary>
        /// <returns>A collection of <c>ImageSelectListItem</c>s with the country's ID, name and icon file name.</returns>
        private IEnumerable<ImageSelectListItem> GetAllCountries()
        {
            IEnumerable<Country> countryList = new MockCountryRepository().GetAllCountries();
            return Mapper.Map<IEnumerable<Country>, IEnumerable<ImageSelectListItem>>(countryList);
        }

        #endregion
    }
}
