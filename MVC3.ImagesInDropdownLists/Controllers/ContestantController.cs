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
        public JsonResult Create(CreateContestantViewModel newReservation)
        {
            if (ModelState.IsValid)
            {
                var employee = Mapper.Map<CreateContestantViewModel, Contestant>(newReservation);
                this._contestantRepository.Add(employee);
            }

            return Json("Oh joy!  You've signed up for our Extreme Shark Wrestling Competition!", JsonRequestBehavior.AllowGet);
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
