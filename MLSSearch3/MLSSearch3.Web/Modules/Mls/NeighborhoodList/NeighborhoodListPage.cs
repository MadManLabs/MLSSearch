

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Mls/NeighborhoodList", typeof(MLSSearch3.Mls.Pages.NeighborhoodListController))]

namespace MLSSearch3.Mls.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Mls/NeighborhoodList"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.NeighborhoodListRow))]
    public class NeighborhoodListController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Mls/NeighborhoodList/NeighborhoodListIndex.cshtml");
        }
    }
}