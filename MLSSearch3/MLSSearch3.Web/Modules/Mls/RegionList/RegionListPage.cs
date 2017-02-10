

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Mls/RegionList", typeof(MLSSearch3.Mls.Pages.RegionListController))]

namespace MLSSearch3.Mls.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Mls/RegionList"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RegionListRow))]
    public class RegionListController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Mls/RegionList/RegionListIndex.cshtml");
        }
    }
}