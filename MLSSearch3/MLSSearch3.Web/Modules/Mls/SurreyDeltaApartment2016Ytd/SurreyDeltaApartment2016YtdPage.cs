

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Mls/SurreyDeltaApartment2016Ytd", typeof(MLSSearch3.Mls.Pages.SurreyDeltaApartment2016YtdController))]

namespace MLSSearch3.Mls.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Mls/SurreyDeltaApartment2016Ytd"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.SurreyDeltaApartment2016YtdRow))]
    public class SurreyDeltaApartment2016YtdController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Mls/SurreyDeltaApartment2016Ytd/SurreyDeltaApartment2016YtdIndex.cshtml");
        }
    }
}