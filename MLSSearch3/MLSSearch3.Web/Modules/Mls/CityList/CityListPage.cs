

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Mls/CityList", typeof(MLSSearch3.Mls.Pages.CityListController))]

namespace MLSSearch3.Mls.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Mls/CityList"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CityListRow))]
    public class CityListController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Mls/CityList/CityListIndex.cshtml");
        }
    }
}