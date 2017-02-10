

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Mls/CitySubAreaList", typeof(MLSSearch3.Mls.Pages.CitySubAreaListController))]

namespace MLSSearch3.Mls.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Mls/CitySubAreaList"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CitySubAreaListRow))]
    public class CitySubAreaListController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Mls/CitySubAreaList/CitySubAreaListIndex.cshtml");
        }
    }
}