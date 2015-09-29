using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiServer_AzureTest.Models.Pages;

namespace EPiServer_AzureTest.Controllers
{
    public class StartController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}