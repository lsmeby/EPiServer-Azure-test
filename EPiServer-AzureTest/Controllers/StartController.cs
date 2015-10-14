using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiServer_AzureTest.Models.Pages;
using EPiServer_AzureTest.Models.ViewModels;
using static System.Math;

namespace EPiServer_AzureTest.Controllers
{
    public class StartController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            const double cSharpVersion = 6.0;
            return View(new StartPageViewModel
            {
                CurrentPage = currentPage,
                CSharpVersion = $"This is a C#{cSharpVersion} format string",
                SquareRoot = Sqrt(25)
        });
        }
    }
}