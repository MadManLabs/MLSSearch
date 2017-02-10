

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Mls/CityDistrictList", typeof(MLSSearch3.Mls.Pages.CityDistrictListController))]

namespace MLSSearch3.Mls.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Mls/CityDistrictList"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CityDistrictListRow))]
    public class CityDistrictListController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Mls/CityDistrictList/CityDistrictListIndex.cshtml");
        }
    }
}