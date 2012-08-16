using System.Globalization;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using MVC3.ImagesInDropdownLists.Models;
using System.Web.Mvc.Html;
using MVC3.ImagesInDropdownLists.ViewModels;


namespace MVC3.ImagesInDropdownLists
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            Mapper.CreateMap<Country, ImageSelectListItem>()
                .ForMember(dest => dest.ImageFileName, opt => opt.MapFrom(src => src.ImageFile))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ID.ToString(CultureInfo.InvariantCulture)));

            Mapper.CreateMap<CreateContestantViewModel, Contestant>();
        }
    }
}